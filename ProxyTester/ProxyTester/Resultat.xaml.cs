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
using System.Windows.Shapes;

namespace ProxyTester
{
    /// <summary>
    /// Logique d'interaction pour Resultat.xaml
    /// </summary>
    public partial class Resultat : Window
    {
        public Resultat(List<Proxy> listeProxy,List<string> TableauTempsDeRep)
        {
            InitializeComponent();
            proxyTableau2.ItemsSource = listeProxy;
            TableauTemps.ItemsSource = TableauTempsDeRep;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
