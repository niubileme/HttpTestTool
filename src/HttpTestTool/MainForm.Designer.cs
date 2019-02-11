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
            this.btnOAuth2 = new System.Windows.Forms.Button();
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.rb_RPS = new System.Windows.Forms.RadioButton();
            this.rb_VU = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_RPS_TotalTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_RPS_Count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_VU_Interval = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_VU_TotalTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_VU_UserCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(1094, 538);
            this.splitContainer1.SplitterDistance = 624;
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
            this.tabControl1.Size = new System.Drawing.Size(624, 538);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnOAuth2);
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
            this.tabPage1.Size = new System.Drawing.Size(616, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "请求配置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOAuth2
            // 
            this.btnOAuth2.Location = new System.Drawing.Point(428, 103);
            this.btnOAuth2.Name = "btnOAuth2";
            this.btnOAuth2.Size = new System.Drawing.Size(75, 23);
            this.btnOAuth2.TabIndex = 14;
            this.btnOAuth2.Text = "OAuth2.0";
            this.btnOAuth2.UseVisualStyleBackColor = true;
            this.btnOAuth2.Click += new System.EventHandler(this.btnOAuth2_Click);
            // 
            // btn_RequestTest
            // 
            this.btn_RequestTest.Location = new System.Drawing.Point(515, 103);
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
            this.groupBox2.Size = new System.Drawing.Size(578, 191);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RequestHeaders";
            // 
            // rtxt_RequestHeaders
            // 
            this.rtxt_RequestHeaders.Location = new System.Drawing.Point(6, 20);
            this.rtxt_RequestHeaders.Name = "rtxt_RequestHeaders";
            this.rtxt_RequestHeaders.Size = new System.Drawing.Size(566, 165);
            this.rtxt_RequestHeaders.TabIndex = 0;
            this.rtxt_RequestHeaders.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxt_RequestBody);
            this.groupBox1.Location = new System.Drawing.Point(15, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 174);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RequestBody";
            // 
            // rtxt_RequestBody
            // 
            this.rtxt_RequestBody.Location = new System.Drawing.Point(8, 20);
            this.rtxt_RequestBody.Name = "rtxt_RequestBody";
            this.rtxt_RequestBody.Size = new System.Drawing.Size(564, 146);
            this.rtxt_RequestBody.TabIndex = 0;
            this.rtxt_RequestBody.Text = "";
            // 
            // cb_KeepAlive
            // 
            this.cb_KeepAlive.AutoSize = true;
            this.cb_KeepAlive.Location = new System.Drawing.Point(336, 106);
            this.cb_KeepAlive.Name = "cb_KeepAlive";
            this.cb_KeepAlive.Size = new System.Drawing.Size(84, 16);
            this.cb_KeepAlive.TabIndex = 9;
            this.cb_KeepAlive.Text = "保持长连接";
            this.cb_KeepAlive.UseVisualStyleBackColor = true;
            // 
            // cb_AutoRedirect
            // 
            this.cb_AutoRedirect.AutoSize = true;
            this.cb_AutoRedirect.Location = new System.Drawing.Point(235, 106);
            this.cb_AutoRedirect.Name = "cb_AutoRedirect";
            this.cb_AutoRedirect.Size = new System.Drawing.Size(96, 16);
            this.cb_AutoRedirect.TabIndex = 8;
            this.cb_AutoRedirect.Text = "是否自动跳转";
            this.cb_AutoRedirect.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "(毫秒)";
            // 
            // txt_RequestTimeOut
            // 
            this.txt_RequestTimeOut.Location = new System.Drawing.Point(137, 103);
            this.txt_RequestTimeOut.Name = "txt_RequestTimeOut";
            this.txt_RequestTimeOut.Size = new System.Drawing.Size(53, 21);
            this.txt_RequestTimeOut.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 107);
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
            this.cbb_RequestMethod.Size = new System.Drawing.Size(45, 20);
            this.cbb_RequestMethod.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "压测配置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_Stop);
            this.groupBox5.Controls.Add(this.btn_Start);
            this.groupBox5.Controls.Add(this.rb_RPS);
            this.groupBox5.Controls.Add(this.rb_VU);
            this.groupBox5.Location = new System.Drawing.Point(17, 195);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(575, 82);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "选择模式";
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(469, 33);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "结束";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(367, 33);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "开始";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // rb_RPS
            // 
            this.rb_RPS.AutoSize = true;
            this.rb_RPS.Location = new System.Drawing.Point(28, 36);
            this.rb_RPS.Name = "rb_RPS";
            this.rb_RPS.Size = new System.Drawing.Size(83, 16);
            this.rb_RPS.TabIndex = 2;
            this.rb_RPS.TabStop = true;
            this.rb_RPS.Text = "吞吐量模式";
            this.rb_RPS.UseVisualStyleBackColor = true;
            // 
            // rb_VU
            // 
            this.rb_VU.AutoSize = true;
            this.rb_VU.Location = new System.Drawing.Point(139, 36);
            this.rb_VU.Name = "rb_VU";
            this.rb_VU.Size = new System.Drawing.Size(71, 16);
            this.rb_VU.TabIndex = 3;
            this.rb_VU.TabStop = true;
            this.rb_VU.Text = "并发模式";
            this.rb_VU.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tabControl2);
            this.groupBox4.Location = new System.Drawing.Point(17, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(578, 151);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "压测模式";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 17);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(572, 131);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txt_RPS_TotalTime);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txt_RPS_Count);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(564, 105);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "吞吐量模式";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "分钟";
            // 
            // txt_RPS_TotalTime
            // 
            this.txt_RPS_TotalTime.Location = new System.Drawing.Point(78, 72);
            this.txt_RPS_TotalTime.Name = "txt_RPS_TotalTime";
            this.txt_RPS_TotalTime.Size = new System.Drawing.Size(92, 21);
            this.txt_RPS_TotalTime.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "持续时长:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "每秒发送:";
            // 
            // txt_RPS_Count
            // 
            this.txt_RPS_Count.Location = new System.Drawing.Point(78, 41);
            this.txt_RPS_Count.Name = "txt_RPS_Count";
            this.txt_RPS_Count.Size = new System.Drawing.Size(92, 21);
            this.txt_RPS_Count.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "每秒发出固定的请求数，主要用TPS来衡量系统的吞吐能力";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.txt_VU_Interval);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.txt_VU_TotalTime);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txt_VU_UserCount);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(564, 105);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "并发模式";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(378, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "毫秒";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(214, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "请求间隔:";
            // 
            // txt_VU_Interval
            // 
            this.txt_VU_Interval.Location = new System.Drawing.Point(280, 42);
            this.txt_VU_Interval.Name = "txt_VU_Interval";
            this.txt_VU_Interval.Size = new System.Drawing.Size(92, 21);
            this.txt_VU_Interval.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "分钟";
            // 
            // txt_VU_TotalTime
            // 
            this.txt_VU_TotalTime.Location = new System.Drawing.Point(77, 71);
            this.txt_VU_TotalTime.Name = "txt_VU_TotalTime";
            this.txt_VU_TotalTime.Size = new System.Drawing.Size(92, 21);
            this.txt_VU_TotalTime.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "持续时长:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "模拟用户:";
            // 
            // txt_VU_UserCount
            // 
            this.txt_VU_UserCount.Location = new System.Drawing.Point(77, 40);
            this.txt_VU_UserCount.Name = "txt_VU_UserCount";
            this.txt_VU_UserCount.Size = new System.Drawing.Size(92, 21);
            this.txt_VU_UserCount.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "模拟虚拟用户并发访问，测试系统能承载的最大在线用户数";
            // 
            // rtxt_Console
            // 
            this.rtxt_Console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_Console.Location = new System.Drawing.Point(0, 0);
            this.rtxt_Console.Name = "rtxt_Console";
            this.rtxt_Console.Size = new System.Drawing.Size(466, 538);
            this.rtxt_Console.TabIndex = 0;
            this.rtxt_Console.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 538);
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
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_RPS_Count;
        private System.Windows.Forms.TextBox txt_RPS_TotalTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_VU_TotalTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_VU_UserCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_VU_Interval;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb_RPS;
        private System.Windows.Forms.RadioButton rb_VU;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnOAuth2;
    }
}

