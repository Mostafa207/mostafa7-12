using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for forget.xaml
    /// </summary>
    public partial class forget : Page
    {
        mEntities2   db = new mEntities2();
        public forget()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            datum forg = new datum();
            try
            { forg = db.data.First(x => x.phone == txtphone.Text);
            
                Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*()]).+$"); 
                if(regex.IsMatch(txtpass.Text))
                {
                    forg.password = txtpass.Text;
                    if (txtpass.Text ==txtpass1.Text)
                    {
                        db.data.AddOrUpdate(forg);
                        db.SaveChanges();
                        MessageBox.Show("update scc");
                        lognin lognin = new lognin();
                        this.NavigationService.Navigate(lognin);
                    }
                    else
                    {
                        MessageBox.Show("not = password");
                    }
                }
                else
                {
                    MessageBox.Show("password is weak");
                }

            }
            catch
            {
                MessageBox.Show("not found numder21");

            }
          

            
           
            
            
           
           
            
        }
    }
}
