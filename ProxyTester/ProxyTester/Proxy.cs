using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyTester
{
    public class Proxy
    {
        #region attributs
        private string ip;
        private string port;
        private string user;
        private string password;
        #endregion

        #region constructor

        public Proxy(string ip,string port,string user,string password)
        {
            this.ip = ip;
            this.port = port;
            this.user = user;
            this.password = password;
        }
        #endregion

        #region Properties
        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }

        public string Port
        {
            get { return port; }
            set { port = value; }
        }

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion

    }
}
