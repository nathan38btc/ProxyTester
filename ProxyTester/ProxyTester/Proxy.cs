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
        private string user;
        private string password;
        private string addresse;
        #endregion

        #region constructor

        public Proxy(string addresse,string user,string password)
        {
            this.addresse = addresse;
            this.user = user;
            this.password = password;
        }
        #endregion

        #region Properties

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
            request.Proxy = new WebProxy(proxy.Addresse);
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.95 Safari/537.36";
            request.Timeout = 2000;
            ICredentials credentials = new NetworkCredential(proxy.User, proxy.Password);

            request.Proxy.Credentials = credentials;
            try
            {
                WebResponse response = request.GetResponse();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        #endregion
    }
}
