using System;
using System.Collections.Generic;
// bibliotheque pour le temps
using System.Diagnostics;
using System.IO;
using System.Linq;
// ajout des bibliothèque pour les requetes web
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;

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
            int tempsRepMax = Convert.ToInt32(TempsdeReponse.Text);  // récuperation des parametres
            string url = (string)urlBox.Text;
            List<string> TableauTempsDeRep = new List<string>();
            
            foreach (Proxy proxy in listeProxyIntern)  // à modifier pour parralléliser les éxecutions 
            {
                
                string tempsDeReponse = "Echec";
                Stopwatch sw = new Stopwatch();      // chrono de mesure du temps d'éxecution

                sw.Start();

                bool rep = Proxy.TestProxy(url, proxy);

                sw.Stop();

                TimeSpan ts = sw.Elapsed;

                if (rep == true)
                {
                    tempsDeReponse = ts.Milliseconds.ToString();
                }

                TableauTempsDeRep.Add(tempsDeReponse);
            }

            Resultat FeneResultat = new Resultat(listeProxyIntern, TableauTempsDeRep, tempsRepMax);
            FeneResultat.Show();

        }

    }
}
