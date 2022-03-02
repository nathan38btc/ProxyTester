using System;
using System.Collections.Generic;
// bibliotheque pour le temps
using System.Diagnostics;
using System.IO;
using System.Linq;
// ajout des bibliothèque pour les requetes web
using System.Net;
using System.Windows;

namespace ProxyTester
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Proxy> listeProxyIntern = new List<Proxy>();
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(List<Proxy> listeProxy)
        {
            listeProxyIntern = listeProxy;
            InitializeComponent();
            proxyTableau.ItemsSource = listeProxy;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AjoutProxy newWindow = new AjoutProxy();
            Window.GetWindow(newWindow).Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow nouvelleFenetre = new MainWindow();
            nouvelleFenetre.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // recuperation des parametres
            int tempsRepMax = Convert.ToInt32(TempsdeReponse.Text);
            string url = (string)urlBox.Text;
            string[] TableauTempsDeRep = new string[listeProxyIntern.Count];
            foreach (Proxy proxy in listeProxyIntern)
            {

                WebRequest wrGETURL = WebRequest.Create(url); // création de l'objet WebRequest
                string proxyAdresse = "https://" + proxy.User + ":" + proxy.Password + "@" + proxy.Ip + ":" + proxy.Port;
                WebProxy myProxy = new WebProxy(proxyAdresse);
                myProxy.BypassProxyOnLocal = true;

                wrGETURL.Proxy = myProxy;  // on utilise le proxy créé pour la requete

                Stopwatch sw = new Stopwatch();      // chrono de mesure du temps d'éxecution

                sw.Start();

                Stream objStream = wrGETURL.GetResponse().GetResponseStream();

                sw.Stop();
                TimeSpan ts = sw.Elapsed;
                string tempsDeReponse = string.Format("{0:00}", ts.Milliseconds);

                TableauTempsDeRep.Append(tempsDeReponse);
            }

            Resultat FeneResultat = new Resultat(listeProxyIntern, TableauTempsDeRep);
            FeneResultat.Show();

        }
    }
}
