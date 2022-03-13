using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ProxyTester
{
    public class Proxy
    {
        #region attributs
        private string ip;
        private string port;
        private string user;
        private string password;
        private string addresse;
        #endregion

        #region constructor

        public Proxy(string ip,string port,string addresse,string user,string password)
        {
            this.ip = ip;
            this.port = port;
            this.addresse = addresse;
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

        public string Addresse
        {
            get { return addresse; }
            set { addresse = value; }
        }
        #endregion

        #region fonction
        public static bool TestProxy(string url,Proxy proxy)
        {
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            var loProxy = new WebProxy(proxy.Addresse, true);
            loProxy.Credentials = new NetworkCredential(proxy.User,proxy.Password);
            request.Proxy = loProxy;

            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36";
            request.Timeout = 2000;

            try
            {
                WebResponse reponse = request.GetResponse();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {

            return this.Ip + ":" +this.Port+":"+ this.User + ":" + this.Password;

        }
        #endregion
    }
}
