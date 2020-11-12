using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyTester
{
    public class ConnectionResult
    {
        private bool isSuccess;
        private string status;

        public bool IsSuccess { get => isSuccess; set => isSuccess = value; }
        public string Status { get => status; set => status = value; }

        public void SetConnectionResult(bool isSuccess, string status)
        {
            this.isSuccess = isSuccess;
            this.status = status;
        }

    }
}
