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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.IO;

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
            foreach(Proxy proxy in listeProxyIntern)
            {
                //string url = (string)urlBox.Text; // recuperation de l'url dans la textBox

                //WebRequest wrGETURL = WebRequest.Create(url); // creation de l'objet WebRequest

                //WebProxy myProxy = new WebProxy("myproxy", Convert.ToInt32(proxy.Port));
                //myProxy.BypassProxyOnLocal = true;

                // wrGETURL.Proxy = myProxy;  // on utilise le proxy créé pour la requete

            }
        }
    }
}
