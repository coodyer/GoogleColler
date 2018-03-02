namespace GoogleColl
{
    partial class AddConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.KeyWordLabel = new System.Windows.Forms.Label();
            this.KeyWordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CallPageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // KeyWordLabel
            // 
            this.KeyWordLabel.AutoSize = true;
            this.KeyWordLabel.Location = new System.Drawing.Point(8, 11);
            this.KeyWordLabel.Name = "KeyWordLabel";
            this.KeyWordLabel.Size = new System.Drawing.Size(65, 12);
            this.KeyWordLabel.TabIndex = 0;
            this.KeyWordLabel.Text = "触发词条：";
            this.KeyWordLabel.Click += new System.EventHandler(this.KeyWordLabel_Click);
            // 
            // KeyWordTextBox
            // 
            this.KeyWordTextBox.Location = new System.Drawing.Point(80, 8);
            this.KeyWordTextBox.Name = "KeyWordTextBox";
            this.KeyWordTextBox.Size = new System.Drawing.Size(206, 21);
            this.KeyWordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "采集代码：";
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(80, 41);
            this.CodeTextBox.Multiline = true;
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CodeTextBox.Size = new System.Drawing.Size(206, 52);
            this.CodeTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "翻页代码：";
            // 
            // CallPageTextBox
            // 
            this.CallPageTextBox.Location = new System.Drawing.Point(80, 99);
            this.CallPageTextBox.Multiline = true;
            this.CallPageTextBox.Name = "CallPageTextBox";
            this.CallPageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CallPageTextBox.Size = new System.Drawing.Size(206, 52);
            this.CallPageTextBox.TabIndex = 7;
            // 
            // AddConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 205);
            this.Controls.Add(this.CallPageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyWordTextBox);
            this.Controls.Add(this.KeyWordLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(316, 244);
            this.MinimumSize = new System.Drawing.Size(316, 244);
            this.Name = "AddConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddConfig";
            this.Load += new System.EventHandler(this.AddConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KeyWordLabel;
        private System.Windows.Forms.TextBox KeyWordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CallPageTextBox;
    }
}