using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyTester
{
    public partial class ProcessForm : Form
    {
        Queue<ProxyInfo> testProxyQueue;
 

        public ProcessForm(List<ProxyInfo> proxyInfos, List<string> testUrls, int timeout, int maxThread) {
            InitializeComponent();
            testProxyQueue = new Queue<ProxyInfo>(proxyInfos);
            Console.WriteLine(testProxyQueue.Count());
        }
    }
}
