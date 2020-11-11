using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyTester
{
    public partial class MainForm : Form
    {
        private List<ProxyInfo> proxyInfos = new List<ProxyInfo>();
        private List<string> testUrls = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            ComboBoxTimeout.SelectedIndex = 1;
        }

        private void BtnLoadProxyList_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog;
            string filePath = "";
            using (fileDialog = new OpenFileDialog())
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                   
                    string fileExt = Path.GetExtension(fileDialog.FileName).Replace(".", "");
                 
                    if ("txt".Equals(fileExt))
                    {
                        filePath = fileDialog.FileName;
                    }
                    else
                    {
                        MessageBox.Show("The proxy list must be a.txt file in UTF8");
                    }
                }
            }
            if (!String.IsNullOrEmpty(filePath)) {
                ThreadPool.QueueUserWorkItem(x =>
                {
                    LoadProxyList(filePath);
                });
            }
        }

        private void LoadProxyList(string filePath)
        {
            try
            {
                ListBoxProxy.Invoke(new Action(() => ListBoxProxy.Items.Clear()));
                proxyInfos.Clear();
                using (var fileStream = File.OpenRead(filePath))
                {
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, (Int32)128))
                    {
                        string line;
                        int lineCount = 0;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            lineCount++;
                            string[] s = line.Split(':');

                            if (s[0] == null || s[1] == null)
                            {
                                continue;
                            }
                            else
                            {
                                string ip = s[0];
                                string port = s[1];

                                string[] ipFormat = ip.Split('.');
                                bool isNumeric = !string.IsNullOrEmpty(port) && port.All(Char.IsDigit);

                                if (ipFormat.Count() != 4 || isNumeric == false)
                                {
                                    Console.WriteLine("Format error : " + lineCount);
                                }
                                else
                                {
                                    ProxyInfo proxyInfo = new ProxyInfo(ip, Convert.ToInt32(port));
                                    proxyInfos.Add(proxyInfo);
                                    ListBoxProxy.Invoke(new Action(() => ListBoxProxy.Items.Add(String.Format("{0}:{1}", ip, port))));
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            finally {
                LbProxyCount.Invoke(new Action(() => LbProxyCount.Text = String.Format("Proxy: {0}", proxyInfos.Count)));
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            foreach (var listBoxItem in ListBoxUrl.Items)
            {
                testUrls.Add(listBoxItem.ToString());
            }
            ProcessForm processForm = new ProcessForm(proxyInfos, testUrls, Convert.ToInt32(ComboBoxTimeout.Text), Convert.ToInt32(UpDownThreadCount.Value));
            processForm.Parent = Parent;
            processForm.StartPosition = FormStartPosition.CenterParent;
            processForm.ShowDialog();
        }
    }
}
