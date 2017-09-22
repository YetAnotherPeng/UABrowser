using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Spire.Barcode;

namespace UABrowser
{
    //public delegate 
    public partial class Form1 : Form
    {
        string UaStr; //全局UA标识
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxUrl.Text = "http://m.baidu.com";
            comboBoxUa.Items.Add("微信内置浏览器-Android");
            comboBoxUa.Items.Add("微信内置浏览器-iPhone");
            comboBoxUa.SelectedIndex = 0;
            textBoxUa.Enabled = false;
        }

        private void textBoxUrl_TextChanged(object sender, EventArgs e)
        {

        }
        [DllImport("urlmon.dll", CharSet = CharSet.Ansi)]
        private static extern int UrlMkSetSessionOption(int dwOption, string pBuffer, int dwBufferLength, int dwReserved);
        const int URLMON_OPTION_USERAGENT = 0x10000001;
        private void ChangeUserAgent(string Agent)
        {
            UrlMkSetSessionOption(URLMON_OPTION_USERAGENT, Agent, Agent.Length, 0);
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = false;
            if (textBoxUrl.Text != "")
            {
                while (webBrowser1.IsBusy) Application.DoEvents();
                //修改UA
                //ChangeUserAgent(UaStr);
                //Navigate方法重载
                webBrowser1.Navigate(textBoxUrl.Text);
                    //, "_self", null, "User-Agent:Mozilla / 5.0(Linux; Android 4.4.4; HM NOTE 1LTEW Build/ KTU84P) AppleWebKit / 537.36(KHTML, like Gecko) Version / 4.0 Chrome / 33.0.0.0 Mobile Safari/ 537.36 MicroMessenger / 6.0.0.54_r849063.501 NetType / WIFI");
            }
        }

        private void comboBoxUa_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxUa.SelectedIndex)
            {
                case 0: ChangeUserAgent("Mozilla/5.0 (Linux; Android 4.4.4; HM NOTE 1LTEW Build/KTU84P) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/33.0.0.0 Mobile Safari/537.36 MicroMessenger/6.0.0.54_r849063.501 NetType/WIFI");break;
                case 1: ChangeUserAgent("Mozilla/5.0 (iPhone; CPU iPhone OS 8_0 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) Mobile/12A365 MicroMessenger/5.4.1 NetType/WIFI");break;
            }
        }

        private void checkBoxUaSet_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUaSet.Checked)
            {
                comboBoxUa.Enabled = false;
                textBoxUa.Enabled = true;
                if (textBoxUa.Text != "")
                {
                    ChangeUserAgent(textBoxUa.Text);
                }
                else
                {
                    MessageBox.Show("粘贴UA到框中");
                }
            }
            else
            {
                comboBoxUa.Enabled = true;
                textBoxUa.Enabled = false;
            }
        }

        private void buttonQrScan_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string[] datas = BarcodeScanner.Scan(ofd.FileName);
                textBoxUrl.Text = datas[0];  //取字符串数组第一个
            }
            
        }
    }
}
