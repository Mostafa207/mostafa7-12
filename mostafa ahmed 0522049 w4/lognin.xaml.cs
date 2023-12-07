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
    /// Interaction logic for lognin.xaml
    /// </summary>
    public partial class lognin : Page
    {
        mEntities2 db = new mEntities2();
        public lognin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            signup signup = new signup();
            this.NavigationService.Navigate(signup);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            forget forget = new forget();
            this.NavigationService.Navigate(forget);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            datum data = new datum();
            try
            {
                data = db.data.First(x => x.username == txtn.Text && x.password == txtp.Text);
                if (data != null)
                {
                    string name  = txtn.Text;
                    string pass = txtp.Text;
                    profile profile = new profile(name,pass);
                    this.NavigationService.Navigate(profile);
                }
                else
                {
                    MessageBox.Show("not find");
                }
                
            }
            catch
            {
                MessageBox.Show("try agine");
            }
           


        }

        private void txtp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            admin admin = new admin();
            this.NavigationService.Navigate(admin);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {



        }
    }
}
