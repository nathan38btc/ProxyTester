using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProxyTester
{
    class Requete : System.Net.IWebProxy
    {
        public ICredentials Credentials { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Uri GetProxy(Uri destination)
        {
            throw new NotImplementedException();
        }

        public bool IsBypassed(Uri host)
        {
            throw new NotImplementedException();
        }

        public Requete()
        {

        }

        #region fonction
        public int Creation(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.CreateHttp(url);
            IWebProxy proxyy = new MyProxy(new Uri("http://xx.xx.xx.xxx:xxxx"))
            {
                Credentials = new NetworkCredential("xxxx", "xxxx")
            };
            webrequest.Proxy = proxyy;

        }
        #endregion
    }
}
