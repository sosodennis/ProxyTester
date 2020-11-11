namespace ProxyTester
{
    partial class ProcessForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbProxyRemainCount = new System.Windows.Forms.Label();
            this.LbInvalidProxy = new System.Windows.Forms.Label();
            this.LbValidProxy = new System.Windows.Forms.Label();
            this.LbCurrentTesting = new System.Windows.Forms.Label();
            this.BtnSaveWorkingList = new System.Windows.Forms.Button();
            this.label_percentageProgress = new System.Windows.Forms.Label();
            this.progressBarTestProxy = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proxy remaining :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Invalid proxy :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LbProxyRemainCount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LbInvalidProxy, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LbValidProxy, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LbCurrentTesting, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(267, 88);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current Testing :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valid proxy :";
            // 
            // LbProxyRemainCount
            // 
            this.LbProxyRemainCount.Location = new System.Drawing.Point(170, 0);
            this.LbProxyRemainCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbProxyRemainCount.Name = "LbProxyRemainCount";
            this.LbProxyRemainCount.Size = new System.Drawing.Size(92, 15);
            this.LbProxyRemainCount.TabIndex = 4;
            this.LbProxyRemainCount.Text = "0";
            this.LbProxyRemainCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbInvalidProxy
            // 
            this.LbInvalidProxy.Location = new System.Drawing.Point(170, 21);
            this.LbInvalidProxy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbInvalidProxy.Name = "LbInvalidProxy";
            this.LbInvalidProxy.Size = new System.Drawing.Size(92, 15);
            this.LbInvalidProxy.TabIndex = 5;
            this.LbInvalidProxy.Text = "0";
            this.LbInvalidProxy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LbValidProxy
            // 
            this.LbValidProxy.Location = new System.Drawing.Point(170, 42);
            this.LbValidProxy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbValidProxy.Name = "LbValidProxy";
            this.LbValidProxy.Size = new System.Drawing.Size(92, 15);
            this.LbValidProxy.TabIndex = 6;
            this.LbValidProxy.Text = "0";
            this.LbValidProxy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LbCurrentTesting
            // 
            this.LbCurrentTesting.Location = new System.Drawing.Point(170, 63);
            this.LbCurrentTesting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbCurrentTesting.Name = "LbCurrentTesting";
            this.LbCurrentTesting.Size = new System.Drawing.Size(92, 25);
            this.LbCurrentTesting.TabIndex = 8;
            this.LbCurrentTesting.Text = "0";
            this.LbCurrentTesting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnSaveWorkingList
            // 
            this.BtnSaveWorkingList.Enabled = false;
            this.BtnSaveWorkingList.Location = new System.Drawing.Point(13, 140);
            this.BtnSaveWorkingList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSaveWorkingList.Name = "BtnSaveWorkingList";
            this.BtnSaveWorkingList.Size = new System.Drawing.Size(267, 27);
            this.BtnSaveWorkingList.TabIndex = 10;
            this.BtnSaveWorkingList.Text = "Save Working List";
            this.BtnSaveWorkingList.UseVisualStyleBackColor = true;
            // 
            // label_percentageProgress
            // 
            this.label_percentageProgress.Location = new System.Drawing.Point(228, 106);
            this.label_percentageProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_percentageProgress.Name = "label_percentageProgress";
            this.label_percentageProgress.Size = new System.Drawing.Size(52, 27);
            this.label_percentageProgress.TabIndex = 9;
            this.label_percentageProgress.Text = "0%";
            this.label_percentageProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarTestProxy
            // 
            this.progressBarTestProxy.Location = new System.Drawing.Point(13, 106);
            this.progressBarTestProxy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBarTestProxy.Name = "progressBarTestProxy";
            this.progressBarTestProxy.Size = new System.Drawing.Size(207, 27);
            this.progressBarTestProxy.TabIndex = 8;
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 179);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BtnSaveWorkingList);
            this.Controls.Add(this.label_percentageProgress);
            this.Controls.Add(this.progressBarTestProxy);
            this.Name = "ProcessForm";
            this.Text = "ProcessForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbProxyRemainCount;
        private System.Windows.Forms.Label LbInvalidProxy;
        private System.Windows.Forms.Label LbValidProxy;
        private System.Windows.Forms.Label LbCurrentTesting;
        private System.Windows.Forms.Button BtnSaveWorkingList;
        private System.Windows.Forms.Label label_percentageProgress;
        private System.Windows.Forms.ProgressBar progressBarTestProxy;
    }
}