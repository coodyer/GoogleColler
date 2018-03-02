using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoogleColl
{
    public partial class AddConfig : Form
    {

        MainForm parentForm = null;
        int modifyIndex;
        public AddConfig(MainForm parentForm, String keyWord, String code,String collPage, Int32 modifyIndex)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.modifyIndex = modifyIndex;
            if (String.IsNullOrEmpty(keyWord) || String.IsNullOrEmpty(code))
            {
                return;
            }
            this.KeyWordTextBox.Text = keyWord;
            this.CodeTextBox.Text = code;
            this.CallPageTextBox.Text = collPage;
        }

        private void AddConfig_Load(object sender, EventArgs e)
        {
            this.Icon = MainForm.icon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(KeyWordTextBox.Text) || String.IsNullOrEmpty(CodeTextBox.Text))
            {
                MessageBox.Show("输入内容有误");
                return;
            }
            parentForm.addOrModifyConfig(KeyWordTextBox.Text, CodeTextBox.Text,CallPageTextBox.Text, modifyIndex);
            this.Close();
        }

        private void KeyWordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
