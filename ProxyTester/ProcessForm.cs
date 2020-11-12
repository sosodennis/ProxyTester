using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyTester
{
    public partial class ProcessForm : Form
    {
        private Queue<ProxyInfo> testProxyQueue;
        private static int testProxyQueueCount;
        private List<string> testUrls;

        int connectTimeout;
        int maxThread;
        private static long currentTestingCount = 0;

        private List<ProxyInfo> validProxyInfos = new List<ProxyInfo>();
        private static long validProxyCount = 0;

        private List<ProxyInfo> invalidProxyInfos = new List<ProxyInfo>();
        private static long invalidProxyCount = 0;

        private static int testedProxyCount = 0;

        Random random = new Random();



        public ProcessForm(List<ProxyInfo> proxyInfos, List<string> testUrls, int connectTimeout, int maxThread)
        {
            InitializeComponent();
            this.connectTimeout = connectTimeout;
            this.maxThread = maxThread;
            this.testUrls = new List<string>(testUrls);
            testProxyQueue = new Queue<ProxyInfo>(proxyInfos);
            testProxyQueueCount = testProxyQueue.Count();
            progressBarTestProxy.Minimum = 0;
            progressBarTestProxy.Maximum = testProxyQueueCount;
            progressBarTestProxy.Step = 1;
            StartTestTask();
        }

        private void StartTestTask()
        {
            Task.Run(() => TestProxy());
        }

        private void TestProxy()
        {
            InitProgressBar();
            while (testProxyQueue.Any())
            {
                if (Interlocked.Read(ref currentTestingCount) < maxThread)
                {
                    IncreaseCurrentTestingBy1();
                    ProxyInfo proxy = testProxyQueue.Dequeue();
                    ThreadPool.QueueUserWorkItem(x =>
                    {
                        TestConnection(proxy);
                    });

                }
            }
            Console.WriteLine("Finish All");
        }

        private void TestConnection(ProxyInfo proxyInfo)
        {
            UpdateLableProxyRemainCount();


            int randomNumber = random.Next(0, testUrls.Count);
            string url = testUrls.ElementAt(randomNumber);
            ProxyConnectionManager connectionManager = new ProxyConnectionManager();
            ConnectionResult connectionResult = connectionManager.testConnection(proxyInfo, url, connectTimeout);
            Console.WriteLine(String.Format("IsSuccess: {0}, Status: {1}", connectionResult.IsSuccess, connectionResult.Status));
            if (connectionResult.IsSuccess)
            {
                UpdateValidProxyCount();
            }
            else
            {
                UpdateInvalidProxyCount();
            }
            DecreaseCurrentTestingBy1();
            IncreaseTestedProxyCountBy1();
        }


        private void IncreaseCurrentTestingBy1()
        {
            Interlocked.Increment(ref currentTestingCount);
            UpdateLabelCurrentTesting();
        }

        private void DecreaseCurrentTestingBy1()
        {
            Interlocked.Decrement(ref currentTestingCount);
            UpdateLabelCurrentTesting();
        }

        private void IncreaseTestedProxyCountBy1() {
            Interlocked.Increment(ref testedProxyCount);
            UpdateProgressBar();
        }

        private void UpdateLabelCurrentTesting()
        {
            try
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    LbCurrentTesting.Text = "" + currentTestingCount;
                });
            }
            catch (Exception) { }
        }

        private void UpdateLableProxyRemainCount()
        {
            Interlocked.Decrement(ref testProxyQueueCount);
            try
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    LbProxyRemainCount.Text = "" + testProxyQueueCount;
                });
            }
            catch (Exception) { }
        }

        private void UpdateValidProxyCount()
        {
            try
            {
                Interlocked.Increment(ref validProxyCount);
                this.Invoke((MethodInvoker)delegate ()
                {
                    LbValidProxy.Text = "" + validProxyCount;
                });
            }
            catch (Exception) { }
        }

        private void UpdateInvalidProxyCount()
        {
            try
            {
                Interlocked.Increment(ref invalidProxyCount);
                this.Invoke((MethodInvoker)delegate ()
                {
                    LbInvalidProxy.Text = "" + invalidProxyCount;
                });
            }
            catch (Exception) { }
        }

        private void InitProgressBar()
        {
            //try
            //{
            //    this.Invoke((MethodInvoker)delegate ()
            //    {
                  
            //    });
            //}
            //catch (Exception e) {
            //    Console.WriteLine(e.Message);
            //}
        }

        private void UpdateProgressBar() {
            try
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    progressBarTestProxy.PerformStep();
                });
            }
            catch (Exception) { }
        }
    }
}
