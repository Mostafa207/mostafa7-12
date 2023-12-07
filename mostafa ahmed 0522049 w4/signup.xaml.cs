using System;
using System.Collections.Generic;
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
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Page
    {
        string gender;
        mEntities2 db = new mEntities2();
        public signup()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            datum add = new datum();

            try
            {
                int age =int.Parse(txtage.Text);
                Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*()]).+$");
                if (regex.IsMatch(txtpass.Text) && age>=18&& age <= 60 && txtph.Text.Length == 11)
                {
                    add.username = txtname.Text;
                    add.age = age;
                    add.gender =gender;
                    add.password=txtpass.Text;
                    add.city = comb.Text;
                    add.phone=txtph.Text;
                    db.data.Add(add);
                    db.SaveChanges();
                    MessageBox.Show("hello");
                    string name = txtname.Text;
                    string pass = txtpass.Text;
                    profile profile = new profile(name,pass);
                    this.NavigationService.Navigate( profile);

                }
                else
                {
                    MessageBox.Show("check password or phone or age ");
                }
            }
            catch
            {
                MessageBox.Show("try again"); 
            }
             


        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            gender ="m";

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            gender = "f";

        }
    }
}
