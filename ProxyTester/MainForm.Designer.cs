namespace ProxyTester
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.UpDownThreadCount = new System.Windows.Forms.NumericUpDown();
            this.LbThreadCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.ListBoxUrl = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnRemoveUrl = new System.Windows.Forms.Button();
            this.BtnAddUrl = new System.Windows.Forms.Button();
            this.LbUrl = new System.Windows.Forms.Label();
            this.ComboBoxTimeout = new System.Windows.Forms.ComboBox();
            this.LbTimeout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbProxyCount = new System.Windows.Forms.Label();
            this.BtnLoadProxyList = new System.Windows.Forms.Button();
            this.ListBoxProxy = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownThreadCount)).BeginInit();
            this.SuspendLayout();
            // 
            // UpDownThreadCount
            // 
            this.UpDownThreadCount.Location = new System.Drawing.Point(239, 380);
            this.UpDownThreadCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpDownThreadCount.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.UpDownThreadCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownThreadCount.Name = "UpDownThreadCount";
            this.UpDownThreadCount.Size = new System.Drawing.Size(185, 25);
            this.UpDownThreadCount.TabIndex = 35;
            this.UpDownThreadCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // LbThreadCount
            // 
            this.LbThreadCount.AutoSize = true;
            this.LbThreadCount.Location = new System.Drawing.Point(9, 383);
            this.LbThreadCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbThreadCount.Name = "LbThreadCount";
            this.LbThreadCount.Size = new System.Drawing.Size(201, 15);
            this.LbThreadCount.TabIndex = 34;
            this.LbThreadCount.Text = "Number of tests at the same time :";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(9, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(416, 2);
            this.label5.TabIndex = 33;
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(11, 417);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(416, 36);
            this.BtnStart.TabIndex = 32;
            this.BtnStart.Text = "START";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // ListBoxUrl
            // 
            this.ListBoxUrl.FormattingEnabled = true;
            this.ListBoxUrl.ItemHeight = 15;
            this.ListBoxUrl.Items.AddRange(new object[] {
            "https://www.apple.com/hk-zh/shop/beacon/atb"});
            this.ListBoxUrl.Location = new System.Drawing.Point(9, 250);
            this.ListBoxUrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListBoxUrl.Name = "ListBoxUrl";
            this.ListBoxUrl.Size = new System.Drawing.Size(415, 79);
            this.ListBoxUrl.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(9, 367);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(416, 2);
            this.label6.TabIndex = 30;
            // 
            // BtnRemoveUrl
            // 
            this.BtnRemoveUrl.Location = new System.Drawing.Point(9, 337);
            this.BtnRemoveUrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnRemoveUrl.Name = "BtnRemoveUrl";
            this.BtnRemoveUrl.Size = new System.Drawing.Size(100, 27);
            this.BtnRemoveUrl.TabIndex = 29;
            this.BtnRemoveUrl.Text = "Remove";
            this.BtnRemoveUrl.UseVisualStyleBackColor = true;
            // 
            // BtnAddUrl
            // 
            this.BtnAddUrl.Location = new System.Drawing.Point(315, 337);
            this.BtnAddUrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAddUrl.Name = "BtnAddUrl";
            this.BtnAddUrl.Size = new System.Drawing.Size(111, 27);
            this.BtnAddUrl.TabIndex = 28;
            this.BtnAddUrl.Text = "Add";
            this.BtnAddUrl.UseVisualStyleBackColor = true;
            // 
            // LbUrl
            // 
            this.LbUrl.AutoSize = true;
            this.LbUrl.Location = new System.Drawing.Point(9, 232);
            this.LbUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbUrl.Name = "LbUrl";
            this.LbUrl.Size = new System.Drawing.Size(89, 15);
            this.LbUrl.TabIndex = 27;
            this.LbUrl.Text = "Testing URL :";
            // 
            // ComboBoxTimeout
            // 
            this.ComboBoxTimeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTimeout.FormattingEnabled = true;
            this.ComboBoxTimeout.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000",
            "11000",
            "12000",
            "13000",
            "14000",
            "15000",
            "16000",
            "17000",
            "18000",
            "19000",
            "20000"});
            this.ComboBoxTimeout.Location = new System.Drawing.Point(9, 185);
            this.ComboBoxTimeout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBoxTimeout.Name = "ComboBoxTimeout";
            this.ComboBoxTimeout.Size = new System.Drawing.Size(416, 23);
            this.ComboBoxTimeout.TabIndex = 26;
            // 
            // LbTimeout
            // 
            this.LbTimeout.AutoSize = true;
            this.LbTimeout.Location = new System.Drawing.Point(5, 167);
            this.LbTimeout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTimeout.Name = "LbTimeout";
            this.LbTimeout.Size = new System.Drawing.Size(83, 15);
            this.LbTimeout.TabIndex = 25;
            this.LbTimeout.Text = "Timeout ms :";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(9, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 2);
            this.label1.TabIndex = 24;
            // 
            // LbProxyCount
            // 
            this.LbProxyCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbProxyCount.Location = new System.Drawing.Point(179, 13);
            this.LbProxyCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbProxyCount.Name = "LbProxyCount";
            this.LbProxyCount.Size = new System.Drawing.Size(248, 18);
            this.LbProxyCount.TabIndex = 23;
            this.LbProxyCount.Text = "Proxy : 0";
            this.LbProxyCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnLoadProxyList
            // 
            this.BtnLoadProxyList.Location = new System.Drawing.Point(9, 3);
            this.BtnLoadProxyList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLoadProxyList.Name = "BtnLoadProxyList";
            this.BtnLoadProxyList.Size = new System.Drawing.Size(149, 27);
            this.BtnLoadProxyList.TabIndex = 21;
            this.BtnLoadProxyList.Text = "Load Proxy List";
            this.BtnLoadProxyList.UseVisualStyleBackColor = true;
            this.BtnLoadProxyList.Click += new System.EventHandler(this.BtnLoadProxyList_Click);
            // 
            // ListBoxProxy
            // 
            this.ListBoxProxy.FormattingEnabled = true;
            this.ListBoxProxy.ItemHeight = 15;
            this.ListBoxProxy.Location = new System.Drawing.Point(9, 38);
            this.ListBoxProxy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListBoxProxy.Name = "ListBoxProxy";
            this.ListBoxProxy.Size = new System.Drawing.Size(415, 109);
            this.ListBoxProxy.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 462);
            this.Controls.Add(this.UpDownThreadCount);
            this.Controls.Add(this.LbThreadCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.ListBoxUrl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnRemoveUrl);
            this.Controls.Add(this.BtnAddUrl);
            this.Controls.Add(this.LbUrl);
            this.Controls.Add(this.ComboBoxTimeout);
            this.Controls.Add(this.LbTimeout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbProxyCount);
            this.Controls.Add(this.BtnLoadProxyList);
            this.Controls.Add(this.ListBoxProxy);
            this.Name = "MainForm";
            this.Text = "Proxy Tester";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownThreadCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown UpDownThreadCount;
        private System.Windows.Forms.Label LbThreadCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.ListBox ListBoxUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnRemoveUrl;
        private System.Windows.Forms.Button BtnAddUrl;
        private System.Windows.Forms.Label LbUrl;
        private System.Windows.Forms.ComboBox ComboBoxTimeout;
        private System.Windows.Forms.Label LbTimeout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbProxyCount;
        private System.Windows.Forms.Button BtnLoadProxyList;
        private System.Windows.Forms.ListBox ListBoxProxy;
    }
}

