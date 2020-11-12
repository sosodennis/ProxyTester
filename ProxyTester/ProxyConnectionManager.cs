using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProxyTester
{
    public class ProxyConnectionManager
    {
 
        private ManualResetEvent resetEvent = new ManualResetEvent(false);
        private ConnectionResult connectionResult = new ConnectionResult();
 
        public ConnectionResult testConnection(ProxyInfo proxyInfo, string url, int timeout) {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.KeepAlive = false;
            request.AllowAutoRedirect = true;
            request.Method = "GET";
            WebProxy proxy = new WebProxy(proxyInfo.Ip, proxyInfo.Port);
            proxy.BypassProxyOnLocal = false;
            request.Proxy = proxy;
           
            IAsyncResult response = request.BeginGetResponse(new AsyncCallback(ReadCallback), request);
            ThreadPool.RegisterWaitForSingleObject(response.AsyncWaitHandle, new WaitOrTimerCallback(TimeoutCallback), request, timeout, true);
            resetEvent.WaitOne();
            return connectionResult;
        }

        private void TimeoutCallback(object state, bool timedOut)
        {
            if (timedOut)
            {
                HttpWebRequest request = (HttpWebRequest)state;
                if (request != null)
                {
                    request.Abort();
                }
            }
        }

        private void ReadCallback(IAsyncResult asyncResult)
        {
            HttpWebRequest request = (HttpWebRequest)asyncResult.AsyncState;
            try
            {
                using (HttpWebResponse httpResponse = (HttpWebResponse)request.EndGetResponse(asyncResult))
                {
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode == HttpStatusCode.OK)
                    {
                        Console.WriteLine("Vaild");
                        connectionResult.SetConnectionResult(true, statusCode.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                        connectionResult.SetConnectionResult(false, statusCode.ToString());
                    }
                }
            }
            catch (WebException e)
            {
                connectionResult.SetConnectionResult(false, e.Message);
            }

            resetEvent.Set();
        }




    }
}
