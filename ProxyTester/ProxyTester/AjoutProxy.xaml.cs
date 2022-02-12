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
    /// Logique d'interaction pour AjoutProxy.xaml
    /// </summary>
    public partial class AjoutProxy : Window
    {
        private List<string> listeProxy = new List<string>();
        public AjoutProxy(List<string> listeProxy)
        {
            this.listeProxy = listeProxy;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
    }
}
