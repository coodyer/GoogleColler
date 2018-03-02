namespace GoogleColl
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SignWebView = new EO.WebBrowser.WebView();
            this.MenuTabControl = new System.Windows.Forms.TabControl();
            this.TabBrowser = new System.Windows.Forms.TabPage();
            this.UrlRequestButton = new System.Windows.Forms.Button();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.WebControler = new EO.WinForm.WebControl();
            this.TabDataList = new System.Windows.Forms.TabPage();
            this.DataListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.整顿格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.网址去重ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.烟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.整顿格式ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.导出网址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部清除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabConfig = new System.Windows.Forms.TabPage();
            this.ConfigListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConfigContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTabControl.SuspendLayout();
            this.TabBrowser.SuspendLayout();
            this.TabDataList.SuspendLayout();
            this.DataListContextMenuStrip.SuspendLayout();
            this.TabConfig.SuspendLayout();
            this.ConfigContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignWebView
            // 
            this.SignWebView.ObjectForScripting = null;
            this.SignWebView.Url = "http://www.google.cn/";
            this.SignWebView.LoadCompleted += new EO.WebBrowser.LoadCompletedEventHandler(this.SignWebView_LoadCompleted);
            // 
            // MenuTabControl
            // 
            this.MenuTabControl.Controls.Add(this.TabBrowser);
            this.MenuTabControl.Controls.Add(this.TabDataList);
            this.MenuTabControl.Controls.Add(this.TabConfig);
            this.MenuTabControl.Location = new System.Drawing.Point(-2, -2);
            this.MenuTabControl.Name = "MenuTabControl";
            this.MenuTabControl.SelectedIndex = 0;
            this.MenuTabControl.Size = new System.Drawing.Size(764, 375);
            this.MenuTabControl.TabIndex = 0;
            // 
            // TabBrowser
            // 
            this.TabBrowser.Controls.Add(this.UrlRequestButton);
            this.TabBrowser.Controls.Add(this.UrlTextBox);
            this.TabBrowser.Controls.Add(this.WebControler);
            this.TabBrowser.Location = new System.Drawing.Point(4, 22);
            this.TabBrowser.Name = "TabBrowser";
            this.TabBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.TabBrowser.Size = new System.Drawing.Size(756, 349);
            this.TabBrowser.TabIndex = 0;
            this.TabBrowser.Text = "网页浏览";
            this.TabBrowser.UseVisualStyleBackColor = true;
            this.TabBrowser.Resize += new System.EventHandler(this.TabBrowser_Resize);
            // 
            // UrlRequestButton
            // 
            this.UrlRequestButton.Location = new System.Drawing.Point(688, 5);
            this.UrlRequestButton.Name = "UrlRequestButton";
            this.UrlRequestButton.Size = new System.Drawing.Size(68, 22);
            this.UrlRequestButton.TabIndex = 3;
            this.UrlRequestButton.Text = "访问";
            this.UrlRequestButton.UseVisualStyleBackColor = true;
            this.UrlRequestButton.Click += new System.EventHandler(this.UrlRequestButton_Click);
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(3, 6);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(675, 21);
            this.UrlTextBox.TabIndex = 2;
            this.UrlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrlTextBox_KeyDown);
            this.UrlTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UrlTextBox_KeyUp);
            // 
            // WebControler
            // 
            this.WebControler.BackColor = System.Drawing.Color.White;
            this.WebControler.Location = new System.Drawing.Point(3, 29);
            this.WebControler.Name = "WebControler";
            this.WebControler.Size = new System.Drawing.Size(750, 320);
            this.WebControler.TabIndex = 1;
            this.WebControler.Text = "webControl1";
            this.WebControler.WebView = this.SignWebView;
            // 
            // TabDataList
            // 
            this.TabDataList.Controls.Add(this.DataListView);
            this.TabDataList.Location = new System.Drawing.Point(4, 22);
            this.TabDataList.Name = "TabDataList";
            this.TabDataList.Padding = new System.Windows.Forms.Padding(3);
            this.TabDataList.Size = new System.Drawing.Size(756, 349);
            this.TabDataList.TabIndex = 1;
            this.TabDataList.Text = "数据列表";
            this.TabDataList.UseVisualStyleBackColor = true;
            this.TabDataList.Resize += new System.EventHandler(this.TabDataList_Resize);
            // 
            // DataListView
            // 
            this.DataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.DataListView.ContextMenuStrip = this.DataListContextMenuStrip;
            this.DataListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataListView.FullRowSelect = true;
            this.DataListView.Location = new System.Drawing.Point(3, 3);
            this.DataListView.MultiSelect = false;
            this.DataListView.Name = "DataListView";
            this.DataListView.Size = new System.Drawing.Size(750, 343);
            this.DataListView.TabIndex = 10;
            this.DataListView.UseCompatibleStateImageBehavior = false;
            this.DataListView.View = System.Windows.Forms.View.Details;
            this.DataListView.DoubleClick += new System.EventHandler(this.DataListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "网址";
            this.columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "标题";
            this.columnHeader3.Width = 240;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "状态";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "延时";
            this.columnHeader5.Width = 100;
            // 
            // DataListContextMenuStrip
            // 
            this.DataListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.整顿格式ToolStripMenuItem,
            this.网址去重ToolStripMenuItem,
            this.烟ToolStripMenuItem,
            this.整顿格式ToolStripMenuItem1,
            this.导出网址ToolStripMenuItem,
            this.全部清除ToolStripMenuItem});
            this.DataListContextMenuStrip.Name = "DataListContextMenuStrip";
            this.DataListContextMenuStrip.Size = new System.Drawing.Size(125, 136);
            // 
            // 整顿格式ToolStripMenuItem
            // 
            this.整顿格式ToolStripMenuItem.Name = "整顿格式ToolStripMenuItem";
            this.整顿格式ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.整顿格式ToolStripMenuItem.Text = "验证存活";
            this.整顿格式ToolStripMenuItem.Click += new System.EventHandler(this.验证存活ToolStripMenuItem_Click);
            // 
            // 网址去重ToolStripMenuItem
            // 
            this.网址去重ToolStripMenuItem.Name = "网址去重ToolStripMenuItem";
            this.网址去重ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.网址去重ToolStripMenuItem.Text = "清理死亡";
            this.网址去重ToolStripMenuItem.Click += new System.EventHandler(this.清理死亡ToolStripMenuItem_Click);
            // 
            // 烟ToolStripMenuItem
            // 
            this.烟ToolStripMenuItem.Name = "烟ToolStripMenuItem";
            this.烟ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.烟ToolStripMenuItem.Text = "网址去重";
            this.烟ToolStripMenuItem.Click += new System.EventHandler(this.网址去重ToolStripMenuItem_Click);
            // 
            // 整顿格式ToolStripMenuItem1
            // 
            this.整顿格式ToolStripMenuItem1.Name = "整顿格式ToolStripMenuItem1";
            this.整顿格式ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.整顿格式ToolStripMenuItem1.Text = "整顿格式";
            this.整顿格式ToolStripMenuItem1.Click += new System.EventHandler(this.整顿格式ToolStripMenuItem1_Click);
            // 
            // 导出网址ToolStripMenuItem
            // 
            this.导出网址ToolStripMenuItem.Name = "导出网址ToolStripMenuItem";
            this.导出网址ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导出网址ToolStripMenuItem.Text = "导出网址";
            this.导出网址ToolStripMenuItem.Click += new System.EventHandler(this.导出网址ToolStripMenuItem_Click);
            // 
            // 全部清除ToolStripMenuItem
            // 
            this.全部清除ToolStripMenuItem.Name = "全部清除ToolStripMenuItem";
            this.全部清除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.全部清除ToolStripMenuItem.Text = "全部清除";
            this.全部清除ToolStripMenuItem.Click += new System.EventHandler(this.全部清除ToolStripMenuItem_Click);
            // 
            // TabConfig
            // 
            this.TabConfig.Controls.Add(this.ConfigListView);
            this.TabConfig.Location = new System.Drawing.Point(4, 22);
            this.TabConfig.Name = "TabConfig";
            this.TabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.TabConfig.Size = new System.Drawing.Size(756, 349);
            this.TabConfig.TabIndex = 2;
            this.TabConfig.Text = "参数配置";
            this.TabConfig.UseVisualStyleBackColor = true;
            this.TabConfig.Resize += new System.EventHandler(this.TabConfig_Resize);
            // 
            // ConfigListView
            // 
            this.ConfigListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.ConfigListView.ContextMenuStrip = this.ConfigContextMenuStrip;
            this.ConfigListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigListView.FullRowSelect = true;
            this.ConfigListView.Location = new System.Drawing.Point(3, 3);
            this.ConfigListView.MultiSelect = false;
            this.ConfigListView.Name = "ConfigListView";
            this.ConfigListView.Size = new System.Drawing.Size(750, 343);
            this.ConfigListView.TabIndex = 11;
            this.ConfigListView.UseCompatibleStateImageBehavior = false;
            this.ConfigListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "编号";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "关键词";
            this.columnHeader7.Width = 170;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "执行代码";
            this.columnHeader8.Width = 250;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "翻页代码";
            this.columnHeader9.Width = 250;
            // 
            // ConfigContextMenuStrip
            // 
            this.ConfigContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem6});
            this.ConfigContextMenuStrip.Name = "DataListContextMenuStrip";
            this.ConfigContextMenuStrip.Size = new System.Drawing.Size(125, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem1.Text = "添加参数";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem2.Text = "修改参数";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem3.Text = "删除参数";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem6.Text = "全部清除";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 411);
            this.Controls.Add(this.MenuTabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Engines Collector Beta V1.0  BY:Coody";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MenuTabControl.ResumeLayout(false);
            this.TabBrowser.ResumeLayout(false);
            this.TabBrowser.PerformLayout();
            this.TabDataList.ResumeLayout(false);
            this.DataListContextMenuStrip.ResumeLayout(false);
            this.TabConfig.ResumeLayout(false);
            this.ConfigContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EO.WebBrowser.WebView SignWebView;
        private System.Windows.Forms.TabControl MenuTabControl;
        private System.Windows.Forms.TabPage TabBrowser;
        private EO.WinForm.WebControl WebControler;
        private System.Windows.Forms.TabPage TabDataList;
        private System.Windows.Forms.ListView DataListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip DataListContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 整顿格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 网址去重ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 烟ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 整顿格式ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 导出网址ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部清除ToolStripMenuItem;
        private System.Windows.Forms.TabPage TabConfig;
        private System.Windows.Forms.ListView ConfigListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ContextMenuStrip ConfigContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Button UrlRequestButton;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.ColumnHeader columnHeader9;

    }
}

