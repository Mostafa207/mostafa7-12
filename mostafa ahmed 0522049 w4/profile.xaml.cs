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
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : Page
    {
        mEntities2 db = new mEntities2();
        public profile(string name,string pass)
        {
            InitializeComponent();
            lable.Content = "welcome"+name;
            grid.ItemsSource=db.data.Where(x=>x.username==name&& x.password==pass).ToList();                         
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lognin lognin = new lognin();
            this.NavigationService.Navigate(lognin);
        }
    }
}
