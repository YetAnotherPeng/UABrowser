namespace UABrowser
{
    partial class Form1
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
            this.labelUa = new System.Windows.Forms.Label();
            this.comboBoxUa = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxUa = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.labelUrl = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.checkBoxUaSet = new System.Windows.Forms.CheckBox();
            this.buttonQrScan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUa
            // 
            this.labelUa.AutoSize = true;
            this.labelUa.Location = new System.Drawing.Point(41, 52);
            this.labelUa.Name = "labelUa";
            this.labelUa.Size = new System.Drawing.Size(53, 12);
            this.labelUa.TabIndex = 0;
            this.labelUa.Text = "打开方式";
            // 
            // comboBoxUa
            // 
            this.comboBoxUa.FormattingEnabled = true;
            this.comboBoxUa.Location = new System.Drawing.Point(99, 49);
            this.comboBoxUa.Name = "comboBoxUa";
            this.comboBoxUa.Size = new System.Drawing.Size(172, 20);
            this.comboBoxUa.TabIndex = 1;
            this.comboBoxUa.SelectedIndexChanged += new System.EventHandler(this.comboBoxUa_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(294, 49);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "刷新";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxUa
            // 
            this.textBoxUa.Location = new System.Drawing.Point(375, 49);
            this.textBoxUa.Name = "textBoxUa";
            this.textBoxUa.Size = new System.Drawing.Size(473, 21);
            this.textBoxUa.TabIndex = 3;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(43, 92);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(931, 420);
            this.webBrowser1.TabIndex = 4;
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(41, 22);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(29, 12);
            this.labelUrl.TabIndex = 5;
            this.labelUrl.Text = "网址";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(99, 12);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(749, 21);
            this.textBoxUrl.TabIndex = 6;
            this.textBoxUrl.TextChanged += new System.EventHandler(this.textBoxUrl_TextChanged);
            // 
            // checkBoxUaSet
            // 
            this.checkBoxUaSet.AutoSize = true;
            this.checkBoxUaSet.Location = new System.Drawing.Point(878, 54);
            this.checkBoxUaSet.Name = "checkBoxUaSet";
            this.checkBoxUaSet.Size = new System.Drawing.Size(108, 16);
            this.checkBoxUaSet.TabIndex = 7;
            this.checkBoxUaSet.Text = "启用自定义Ustr";
            this.checkBoxUaSet.UseVisualStyleBackColor = true;
            this.checkBoxUaSet.CheckedChanged += new System.EventHandler(this.checkBoxUaSet_CheckedChanged);
            // 
            // buttonQrScan
            // 
            this.buttonQrScan.Location = new System.Drawing.Point(867, 17);
            this.buttonQrScan.Name = "buttonQrScan";
            this.buttonQrScan.Size = new System.Drawing.Size(107, 23);
            this.buttonQrScan.TabIndex = 8;
            this.buttonQrScan.Text = "解析二维码图片";
            this.buttonQrScan.UseVisualStyleBackColor = true;
            this.buttonQrScan.Click += new System.EventHandler(this.buttonQrScan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 545);
            this.Controls.Add(this.buttonQrScan);
            this.Controls.Add(this.checkBoxUaSet);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textBoxUa);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.comboBoxUa);
            this.Controls.Add(this.labelUa);
            this.Name = "Form1";
            this.Text = "U浏览器---我能瞬间变身微信  Author：YB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUa;
        private System.Windows.Forms.ComboBox comboBoxUa;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxUa;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.CheckBox checkBoxUaSet;
        private System.Windows.Forms.Button buttonQrScan;
    }
}

