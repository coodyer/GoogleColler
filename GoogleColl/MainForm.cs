using GoogleColl.entity;
using GoogleColl.handle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GoogleColl
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static int data_view_index = 0;

        public static Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe");

        public static Object base_lock = new object();

        private void MainForm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.Icon = icon;
            loadConfig();
        }

        private void TabBrowser_Resize(object sender, EventArgs e)
        {
            WebControler.Width = TabBrowser.Width - 6;
            UrlTextBox.Left = 3;
            UrlTextBox.Width = TabBrowser.Width - UrlRequestButton.Width - 24;
            UrlRequestButton.Left = UrlTextBox.Width + UrlTextBox.Left + 3;
            UrlRequestButton.Top = 6;
            UrlTextBox.Top = 6;
            WebControler.Top = UrlTextBox.Top + UrlTextBox.Height + 8;
            WebControler.Height = TabBrowser.Height - UrlTextBox.Top - UrlTextBox.Height - 16;
            WebControler.Left = 3;


        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            MenuTabControl.Left = 0;
            MenuTabControl.Top = 0;
            MenuTabControl.Width = this.Width;
            MenuTabControl.Height = this.Height-24;
        }

        private void TabDataList_Resize(object sender, EventArgs e)
        {
            DataListView.Width = TabDataList.Width;
            DataListView.Height = TabDataList.Height;
            DataListView.Left = 0;
            DataListView.Top = 0;
            int totalWidth = TabDataList.Width;
            double sumColumnsWidth = 0;
            for (int i = 0; i < DataListView.Columns.Count; i++)
            {
                sumColumnsWidth += DataListView.Columns[i].Width;
            }
            for (int i = 0; i < DataListView.Columns.Count; i++)
            {
                double thisWidth = (DataListView.Columns[i].Width / sumColumnsWidth) * totalWidth;
                DataListView.Columns[i].Width = Convert.ToInt32(Math.Round(thisWidth, 0));
            }

        }

        private void SignWebView_LoadCompleted(object sender, EO.WebBrowser.LoadCompletedEventArgs e)
        {
            UrlTextBox.Text = SignWebView.Url.ToString();
            String jsCode = "";
            String nextPageCode = "";
            for (int i = 0; i < ConfigListView.Items.Count; i++)
            {
                if (!SignWebView.Url.ToString().Contains(ConfigListView.Items[i].SubItems[1].Text))
                {
                    ConfigListView.Items[i].ForeColor = Color.DarkGray;
                    continue;
                }
                if (String.IsNullOrEmpty(ConfigListView.Items[i].SubItems[2].Text) && String.IsNullOrEmpty(ConfigListView.Items[i].SubItems[3].Text))
                {
                    ConfigListView.Items[i].ForeColor = Color.DarkGray;
                    continue;
                }
                jsCode = ConfigListView.Items[i].SubItems[2].Text;
                nextPageCode = ConfigListView.Items[i].SubItems[3].Text;
                ConfigListView.Items[i].Selected = true;
                ConfigListView.Items[i].ForeColor = Color.Green;
            }
            if (!String.IsNullOrEmpty(jsCode))
            {
                Object obj = SignWebView.EvalScript(jsCode);
                String json = Convert.ToString(obj);
                if (String.IsNullOrEmpty(json) || "[]".Equals(json))
                {
                    return;
                }
                try
                {
                    List<UrlInfo> users = (List<UrlInfo>)JsonHandle.toBean<List<UrlInfo>>(json);
                    foreach (UrlInfo urlInfo in users)
                    {
                        try
                        {
                            ListViewItem lvi = new ListViewItem();
                            lvi.SubItems[0].Text = Convert.ToString(DataListView.Items.Count + 1);
                            lvi.SubItems.Add(urlInfo.url);
                            lvi.SubItems.Add(urlInfo.title);
                            lvi.SubItems.Add("待检测");
                            lvi.SubItems.Add("待检测");
                            DataListView.Items.Add(lvi);
                        }
                        catch { }
                    }
                }
                catch { }
            }
            //翻页
            try
            {
                if (!String.IsNullOrEmpty(nextPageCode))
                {
                    SignWebView.EvalScript(nextPageCode);
                }
            }
            catch { }
        }

        private void DataListView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(DataListView.SelectedItems[0].SubItems[1].Text);
            }
            catch { }
        }

        private void 全部清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataListContextMenuStrip.Enabled = false;
            DataListView.Items.Clear();
            DataListContextMenuStrip.Enabled = true;
        }

        private void 网址去重ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread clearIdenticalThread = new Thread(clear_identical);
            clearIdenticalThread.Start();
        }

        private void clear_identical()
        {
            DataListContextMenuStrip.Enabled = false;
            HashSet<String> domains = new HashSet<string>();
            List<ListViewItem> items = new List<ListViewItem>();
            for (int i = DataListView.Items.Count - 1; i > -1; i--)
            {
                try
                {
                    String url = DataListView.Items[i].SubItems[1].Text;
                    Uri uri = new Uri(url);
                    if (domains.Add(uri.Host))
                    {
                        items.Add(DataListView.Items[i]);
                    }
                }
                catch { }
            }
            DataListView.Items.Clear();
            DataListView.Items.AddRange(items.ToArray());
            resetListViewIndex(DataListView);
            DataListContextMenuStrip.Enabled = true;
        }

        private void 清理死亡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread clearDeathThread = new Thread(clear_death);
            clearDeathThread.Start();
        }

        private void clear_death()
        {
            DataListContextMenuStrip.Enabled = false;
            for (int i = DataListView.Items.Count - 1; i > -1; i--)
            {
                String msg = DataListView.Items[i].SubItems[3].Text;
                if (msg.Equals("200"))
                {
                    continue;
                }
                DataListView.Items.Remove(DataListView.Items[i]);
            }
            resetListViewIndex(DataListView);
            DataListContextMenuStrip.Enabled = true;
        }

        private void 整顿格式ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thread urlFormatThread = new Thread(url_format);
            urlFormatThread.Start();
        }

        private void url_format()
        {
            DataListContextMenuStrip.Enabled = false;
            for (int i = DataListView.Items.Count - 1; i > -1; i--)
            {
                String url = DataListView.Items[i].SubItems[1].Text;
                try
                {
                    Uri uri = new Uri(url);
                    url = uri.Scheme + "://" + uri.Host;
                    if (uri.Port != -1 && uri.Port != 80 && uri.Port != 443)
                    {
                        url += (":") + uri.Port;
                    }
                    DataListView.Items[i].SubItems[1].Text = url;
                }
                catch { }
            }
            DataListContextMenuStrip.Enabled = true;
        }

        private void 导出网址ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataListContextMenuStrip.Enabled = false;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".txt";
            if (sfd.FileName != "" && sfd.ShowDialog() == DialogResult.OK)
            {
                sfd.RestoreDirectory = true;
                sfd.CreatePrompt = true;
                StreamWriter sw = File.CreateText(sfd.FileName);
                for (int i = 0; i < DataListView.Items.Count; i++)
                {
                    try
                    {
                        sw.WriteLine(DataListView.Items[i].SubItems[1].Text);
                    }
                    catch { }
                }
                sw.Close();
                MessageBox.Show("Save Success!");
            }
            DataListContextMenuStrip.Enabled = true;
        }


        /// 创建POST方式的HTTP请求  
        public static int GetCode(string url)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest; ;
                //如果是发送HTTPS请求  
                request.Method = "HEAD";
                request.ContentType = "text/html";
                request.UserAgent = "Mozilla/5.0 (compatible; Baiduspider/2.0; +http://www.baidu.com/search/spider.html)";
                string[] values = request.Headers.GetValues("Content-Type");
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                return Convert.ToInt32(response.StatusCode);


            }
            catch
            {
                return -1;
            }
        }

        private void 验证存活ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread checkThreadPoolThread = new Thread(checkThreadPool);
            checkThreadPoolThread.Start();
        }

        [STAThread]
        private void checkThreadPool()
        {
            DataListContextMenuStrip.Enabled = false;
            data_view_index = 0;
            int thread_num = 30;
            ThreadPool.SetMaxThreads(thread_num, thread_num + 1);
            ThreadPool.SetMinThreads(thread_num, thread_num - 1);
            for (int i = 0; i < thread_num; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(checkThread), new object());
            }
            while (true)
            {
                Thread.Sleep(1000);
                int workerThreads = 0;
                int maxWordThreads = 0;
                //int   
                int compleThreads = 0;
                ThreadPool.GetAvailableThreads(out workerThreads, out compleThreads);
                ThreadPool.GetMaxThreads(out maxWordThreads, out compleThreads);
                //当可用的线数与池程池最大的线程相等时表示线程池中所有的线程已经完成
                if (workerThreads == maxWordThreads)
                {
                    break;
                }
            }
            DataListContextMenuStrip.Enabled = true;
        }
        [STAThread]
        private void checkThread(Object obj)
        {
            int index = 0;

            while (index < DataListView.Items.Count)
            {
                lock (base_lock)
                {
                    index = data_view_index;
                    data_view_index++;
                }
                if (index >= DataListView.Items.Count)
                {
                    return;
                }
                String url = DataListView.Items[index].SubItems[1].Text;
                DataListView.Items[index].SubItems[4].Text = "检测中";
                DataListView.Items[index].ForeColor = Color.Violet;
                DateTime dateStart = DateTime.Now;
                int code = GetCode(url);
                DateTime dateEnd = DateTime.Now;
                DataListView.Items[index].SubItems[3].Text = Convert.ToString(code);
                TimeSpan span = (TimeSpan)(dateEnd - dateStart);
                DataListView.Items[index].SubItems[4].Text = Convert.ToString(span.Milliseconds);
                if (code != 200)
                {
                    DataListView.Items[index].ForeColor = Color.Red;
                    continue;
                }
                DataListView.Items[index].ForeColor = Color.Green;
            }
        }

        private void TabConfig_Resize(object sender, EventArgs e)
        {
            ConfigListView.Width = TabConfig.Width;
            ConfigListView.Height = TabConfig.Height;
            ConfigListView.Left = 0;
            ConfigListView.Top = 0;
            int totalWidth = TabConfig.Width;
            double sumColumnsWidth = 0;
            for (int i = 0; i < ConfigListView.Columns.Count; i++)
            {
                sumColumnsWidth += ConfigListView.Columns[i].Width;
            }
            for (int i = 0; i < ConfigListView.Columns.Count; i++)
            {
                double thisWidth = (ConfigListView.Columns[i].Width / sumColumnsWidth) * totalWidth;
                ConfigListView.Columns[i].Width = Convert.ToInt32(Math.Round(thisWidth, 0));
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ConfigListView.Items.Clear();
            saveConfig();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddConfig addConfig = new AddConfig(this, null, null, null, -1);
            addConfig.ShowDialog();
        }
        public void addOrModifyConfig(String keyWord, String code, String callPageCode, int modifyIndex)
        {
            try
            {

                if (modifyIndex > -1)
                {
                    ConfigListView.Items[modifyIndex].SubItems[1].Text = keyWord;
                    ConfigListView.Items[modifyIndex].SubItems[2].Text = code;
                    ConfigListView.Items[modifyIndex].SubItems[3].Text = callPageCode;
                    return;
                }
                for (int i = 0; i < ConfigListView.Items.Count; i++)
                {
                    if (ConfigListView.Items[i].SubItems[1].Text.Equals(keyWord))
                    {
                        ConfigListView.Items[i].SubItems[2].Text = code;
                        ConfigListView.Items[modifyIndex].SubItems[3].Text = callPageCode;
                        return;
                    }
                }
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems[0].Text = Convert.ToString(ConfigListView.Items.Count + 1);
                lvi.SubItems.Add(keyWord);
                lvi.SubItems.Add(code);
                lvi.SubItems.Add(callPageCode);
                ConfigListView.Items.Add(lvi);

                return;
            }
            catch { }
            finally
            {
                saveConfig();
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                String keyword = ConfigListView.SelectedItems[0].SubItems[1].Text;
                String code = ConfigListView.SelectedItems[0].SubItems[2].Text;
                String callPageCode = ConfigListView.SelectedItems[0].SubItems[3].Text;
                AddConfig addConfig = new AddConfig(this, keyword, code, callPageCode, ConfigListView.SelectedItems[0].Index);
                addConfig.ShowDialog();
            }
            catch { }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigListView.Items.Remove(ConfigListView.SelectedItems[0]);
                resetListViewIndex(ConfigListView);
                saveConfig();
            }
            catch { }
        }

        private void resetListViewIndex(ListView listView)
        {
            for (int i = 0; i < listView.Items.Count; i++)
            {

                if (Convert.ToInt32(listView.Items[i].SubItems[0].Text) == i + 1)
                {
                    continue;
                }
                listView.Items[i].SubItems[0].Text = Convert.ToString(i + 1);
            }
        }

        private void loadConfig()
        {
            try
            {
                StreamReader sr = new StreamReader(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".conf", Encoding.Default);
                String line;
                StringBuilder configContext = new StringBuilder();
                while ((line = sr.ReadLine()) != null)
                {
                    configContext.AppendLine(line);
                }
                sr.Close();
                List<KeywordCodeTrigger> triggers = (List<KeywordCodeTrigger>)JsonHandle.toBean<List<KeywordCodeTrigger>>(configContext.ToString());
                foreach(KeywordCodeTrigger keywordCodeTrigger in triggers)
                {
                    try
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.SubItems[0].Text = Convert.ToString(ConfigListView.Items.Count + 1);
                        lvi.SubItems.Add(keywordCodeTrigger.keyword);
                        lvi.SubItems.Add(keywordCodeTrigger.code);
                        lvi.SubItems.Add(keywordCodeTrigger.nextPageCode);
                        ConfigListView.Items.Add(lvi);
                    }
                    catch { }
                }
            }
            catch { }
            finally
            {
                if (ConfigListView.Items.Count == 0)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems[0].Text = Convert.ToString(ConfigListView.Items.Count + 1);
                    lvi.SubItems.Add("https://www.google.com");
                    lvi.SubItems.Add(Properties.Resources.GoogleCollScript);
                    lvi.SubItems.Add(Properties.Resources.GoogleCollCallPageScript);
                    ConfigListView.Items.Add(lvi);
                }
            }
        }

        private void saveConfig()
        {
            try
            {
                List<KeywordCodeTrigger> keys = new List<KeywordCodeTrigger>();
                for (int i = 0; i < ConfigListView.Items.Count; i++)
                {
                    KeywordCodeTrigger key = new KeywordCodeTrigger();
                    key.keyword = ConfigListView.Items[i].SubItems[1].Text;
                    key.code = ConfigListView.Items[i].SubItems[2].Text;
                    key.nextPageCode = ConfigListView.Items[i].SubItems[3].Text;
                    keys.Add(key);
                }
                String json = JsonHandle.toJson(keys);
                FileStream fs = new FileStream(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".conf", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(json);
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }
            catch { }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            DialogResult r = MessageBox.Show("Really want to exit?", "Remind", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Process.GetCurrentProcess().Kill();
            }
        }

        private void UrlRequestButton_Click(object sender, EventArgs e)
        {
            try
            {
                SignWebView.Url = UrlTextBox.Text.Trim();
            }
            catch { }

        }

        private void UrlTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void UrlTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.Enter)
            {
                try
                {
                    SignWebView.Url = UrlTextBox.Text.Trim();
                }
                catch { }
            }
        }
    }
}
