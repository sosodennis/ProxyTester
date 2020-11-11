using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyTester
{
    public class ProxyInfo
    {
        public ProxyInfo(string ip, int port) {
            Ip = ip;
            Port = port;
        }
        public string Ip;
        public int Port;
    }
}
