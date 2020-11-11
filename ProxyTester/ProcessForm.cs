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

        Random random = new Random();



        public ProcessForm(List<ProxyInfo> proxyInfos, List<string> testUrls, int connectTimeout, int maxThread)
        {
            InitializeComponent();
            this.connectTimeout = connectTimeout;
            this.maxThread = maxThread;
            this.testUrls = new List<string>(testUrls);
            testProxyQueue = new Queue<ProxyInfo>(proxyInfos);
            testProxyQueueCount = testProxyQueue.Count();
            StartTestTask();
        
        }

        private void StartTestTask()
        {
            ServicePointManager.DefaultConnectionLimit = 50;
            Task.Run(() => TestProxy());
        }

        private void TestProxy()
        {
            while (testProxyQueue.Any())
            {
                if (Interlocked.Read(ref currentTestingCount) < maxThread)
                {
                    IncreaseCurrentTestingBy1();
                    ProxyInfo proxy = testProxyQueue.Dequeue();
                    ;
                    Task.Run(() => TestConnection(proxy));
                }
                Thread.Sleep(500);
            }
            Console.WriteLine("Finish All");
        }

        private void TestConnection(ProxyInfo proxyInfo)
        {
            UpdateLableProxyRemainCount();


            int randomNumber = random.Next(0, testUrls.Count);
            string url = testUrls.ElementAt(randomNumber);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = connectTimeout;
            request.ReadWriteTimeout = connectTimeout;
            request.ContinueTimeout = connectTimeout;
            request.KeepAlive = false;
            WebProxy proxy = new WebProxy(proxyInfo.Ip, proxyInfo.Port);
            proxy.BypassProxyOnLocal = false;
            request.Proxy = proxy;
            request.Method = "GET";
            try
            {
                using (var httpResponse = (HttpWebResponse)request.GetResponse())
                {
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode == HttpStatusCode.OK)
                    {
                        Console.WriteLine("Vaild");
                        validProxyInfos.Add(proxyInfo);
                        UpdateValidProxyCount();
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                        invalidProxyInfos.Add(proxyInfo);
                        UpdateInvalidProxyCount();
                    }
                    httpResponse.Close();
                }
            }
            catch (Exception) {
                invalidProxyInfos.Add(proxyInfo);
                UpdateInvalidProxyCount();
            }
            finally
            {
                DecreaseCurrentTestingBy1();
            }
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
    }
}
