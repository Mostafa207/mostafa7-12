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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace me
{
    /// <summary>
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class admin : Page
    {
        mEntities2 db = new mEntities2();
        public admin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                 Admin admin = new Admin();


                if (txtname.Text != "" && txtpass.Text != "")
                {
                    admin = db.Admins.First(x => x.admin_username==txtname.Text && x.admin_pass==txtpass.Text );
                    if (admin!= null)
                    {
                        MessageBox.Show("hello");
                        adminf F = new adminf();
                        this.NavigationService.Navigate(F);
                    }
                    else
                    {
                        MessageBox.Show("not found");
                    }

                }
                else
                {
                    MessageBox.Show("enter date");
                }

            }
            catch
            {
                MessageBox.Show("not found");
            }


        }
    }
}
