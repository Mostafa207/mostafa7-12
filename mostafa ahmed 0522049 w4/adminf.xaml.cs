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

namespace me
{
    /// <summary>
    /// Interaction logic for adminf.xaml
    /// </summary>
    public partial class adminf : Page
    {
        public adminf()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            delete delete = new delete();
            this.NavigationService.Navigate(delete);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            search search = new search();
            this.NavigationService.Navigate(search);
        }
    }
}
