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
        private List<Proxy> listeProxy = new List<Proxy>();
        private List<string> TableauTempsDeRep = new List<string>();
        private int TempsDeRepMax;
        public Resultat(List<Proxy> listeProxy, List<string> TableauTempsDeRep, int TempsDeRepMax)
        {
            
            this.listeProxy = listeProxy;
            this.TableauTempsDeRep = TableauTempsDeRep;
            this.TempsDeRepMax = TempsDeRepMax;
            InitializeComponent();
            proxyTableau2.ItemsSource = listeProxy;
            TableauTemps.ItemsSource = TableauTempsDeRep;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = "";
            for (int i=0; i < TableauTempsDeRep.Count; i++)
            {
                if(Convert.ToInt32(TableauTempsDeRep[i]) < TempsDeRepMax)
                {
                    text += listeProxy[i].ToString()+"\n";
                }
            }
            System.Windows.Clipboard.SetText(text);
            MessageBox.Show("Proxy dans le PressePapier !!");
        }

    }
}
