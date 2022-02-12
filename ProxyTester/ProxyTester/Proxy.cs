using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyTester
{
    class Proxy
    {
        #region attributs
        private string ip;
        private string port;
        private string adresse;
        private string password;
        #endregion

        #region constructor

        public Proxy(string donneesProxy)
        {
            string[] DonneeExploitable = donneesProxy.Split(';');
            this.ip = DonneeExploitable[0];
            this.port = DonneeExploitable[1];
            this.adresse = DonneeExploitable[2];
            this.password = DonneeExploitable[3];
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

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion

    }
}
