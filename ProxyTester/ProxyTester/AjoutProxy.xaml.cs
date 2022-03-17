using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Net;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProxyTester
{
    /// <summary>
    /// Logique d'interaction pour AjoutProxy.xaml
    /// </summary>
    public partial class AjoutProxy : Window
    {
        public AjoutProxy()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string proxyEnTexte = (string)proxyTexte.Text;  //recupération des proxys en texte et transformation en objet Proxy
            List<string> proxyEnLigne = proxyEnTexte.Split('\n').ToList();
            List<Proxy> proxyEnListe = new List<Proxy>();

            foreach (string ligne in proxyEnLigne)
            {
                if (ligne == "")
                {
                    break;
                }
                else
                {
                    string[] DonneeExploitable = ligne.Split(':');
                    string addresse = "http://"+ DonneeExploitable[2]+":" + DonneeExploitable[3]+"@"+DonneeExploitable[0] + ":" + DonneeExploitable[1];
                    Proxy nouveauProxy = new Proxy(DonneeExploitable[0], DonneeExploitable[1],addresse, DonneeExploitable[2], DonneeExploitable[3]);
                    proxyEnListe.Add(nouveauProxy);
                }

            }
            
            MainWindow retourAuMain = new MainWindow(proxyEnListe);
            retourAuMain.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow retourAuMain = new MainWindow();
            retourAuMain.Show();
            this.Close();
        }
    }
}
