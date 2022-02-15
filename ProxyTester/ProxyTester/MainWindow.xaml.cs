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

namespace ProxyTester
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(List<Proxy> listeProxy)
        {
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
    }
}
