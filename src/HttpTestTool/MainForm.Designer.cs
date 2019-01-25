namespace HttpTestTool
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_RequestTest = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtxt_Url = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxt_RequestHeaders = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxt_RequestBody = new System.Windows.Forms.RichTextBox();
            this.cb_KeepAlive = new System.Windows.Forms.CheckBox();
            this.cb_AutoRedirect = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_RequestTimeOut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_RequestMethod = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtxt_Console = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtxt_Console);
            this.splitContainer1.Size = new System.Drawing.Size(937, 538);
            this.splitContainer1.SplitterDistance = 622;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 538);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_RequestTest);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.cb_KeepAlive);
            this.tabPage1.Controls.Add(this.cb_AutoRedirect);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_RequestTimeOut);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbb_RequestMethod);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(614, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "请求配置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_RequestTest
            // 
            this.btn_RequestTest.Location = new System.Drawing.Point(507, 103);
            this.btn_RequestTest.Name = "btn_RequestTest";
            this.btn_RequestTest.Size = new System.Drawing.Size(75, 23);
            this.btn_RequestTest.TabIndex = 13;
            this.btn_RequestTest.Text = "测试";
            this.btn_RequestTest.UseVisualStyleBackColor = true;
            this.btn_RequestTest.Click += new System.EventHandler(this.btn_RequestTest_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtxt_Url);
            this.groupBox3.Location = new System.Drawing.Point(15, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 85);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "URL";
            // 
            // rtxt_Url
            // 
            this.rtxt_Url.Location = new System.Drawing.Point(6, 20);
            this.rtxt_Url.Name = "rtxt_Url";
            this.rtxt_Url.Size = new System.Drawing.Size(566, 59);
            this.rtxt_Url.TabIndex = 0;
            this.rtxt_Url.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxt_RequestHeaders);
            this.groupBox2.Location = new System.Drawing.Point(15, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 156);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RequestHeaders";
            // 
            // rtxt_RequestHeaders
            // 
            this.rtxt_RequestHeaders.Location = new System.Drawing.Point(6, 20);
            this.rtxt_RequestHeaders.Name = "rtxt_RequestHeaders";
            this.rtxt_RequestHeaders.Size = new System.Drawing.Size(566, 130);
            this.rtxt_RequestHeaders.TabIndex = 0;
            this.rtxt_RequestHeaders.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxt_RequestBody);
            this.groupBox1.Location = new System.Drawing.Point(15, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 209);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RequestBody";
            // 
            // rtxt_RequestBody
            // 
            this.rtxt_RequestBody.Location = new System.Drawing.Point(8, 21);
            this.rtxt_RequestBody.Name = "rtxt_RequestBody";
            this.rtxt_RequestBody.Size = new System.Drawing.Size(564, 182);
            this.rtxt_RequestBody.TabIndex = 0;
            this.rtxt_RequestBody.Text = "";
            // 
            // cb_KeepAlive
            // 
            this.cb_KeepAlive.AutoSize = true;
            this.cb_KeepAlive.Location = new System.Drawing.Point(407, 106);
            this.cb_KeepAlive.Name = "cb_KeepAlive";
            this.cb_KeepAlive.Size = new System.Drawing.Size(84, 16);
            this.cb_KeepAlive.TabIndex = 9;
            this.cb_KeepAlive.Text = "保持长连接";
            this.cb_KeepAlive.UseVisualStyleBackColor = true;
            // 
            // cb_AutoRedirect
            // 
            this.cb_AutoRedirect.AutoSize = true;
            this.cb_AutoRedirect.Location = new System.Drawing.Point(300, 106);
            this.cb_AutoRedirect.Name = "cb_AutoRedirect";
            this.cb_AutoRedirect.Size = new System.Drawing.Size(96, 16);
            this.cb_AutoRedirect.TabIndex = 8;
            this.cb_AutoRedirect.Text = "是否自动跳转";
            this.cb_AutoRedirect.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "(毫秒)";
            // 
            // txt_RequestTimeOut
            // 
            this.txt_RequestTimeOut.Location = new System.Drawing.Point(169, 103);
            this.txt_RequestTimeOut.Name = "txt_RequestTimeOut";
            this.txt_RequestTimeOut.Size = new System.Drawing.Size(76, 21);
            this.txt_RequestTimeOut.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "超时时间:";
            // 
            // cbb_RequestMethod
            // 
            this.cbb_RequestMethod.FormattingEnabled = true;
            this.cbb_RequestMethod.Items.AddRange(new object[] {
            "Get",
            "Post"});
            this.cbb_RequestMethod.Location = new System.Drawing.Point(21, 102);
            this.cbb_RequestMethod.Name = "cbb_RequestMethod";
            this.cbb_RequestMethod.Size = new System.Drawing.Size(67, 20);
            this.cbb_RequestMethod.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(614, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "压测模式";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtxt_Console
            // 
            this.rtxt_Console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_Console.Location = new System.Drawing.Point(0, 0);
            this.rtxt_Console.Name = "rtxt_Console";
            this.rtxt_Console.Size = new System.Drawing.Size(311, 538);
            this.rtxt_Console.TabIndex = 0;
            this.rtxt_Console.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 538);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtxt_Console;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbb_RequestMethod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_KeepAlive;
        private System.Windows.Forms.CheckBox cb_AutoRedirect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_RequestTimeOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtxt_Url;
        private System.Windows.Forms.RichTextBox rtxt_RequestHeaders;
        private System.Windows.Forms.RichTextBox rtxt_RequestBody;
        private System.Windows.Forms.Button btn_RequestTest;
    }
}

