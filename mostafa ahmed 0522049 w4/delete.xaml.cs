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
    /// Interaction logic for delete.xaml
    /// </summary>
    public partial class delete : Page
    {
        mEntities2 db =new mEntities2();
        public delete()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            datum datum = new datum();
            datum = db.data.First(x => x.phone == txtp.Text);
            if (datum != null )
            {
                db.data.Remove(datum);
                MessageBox.Show("delet user");
                db.SaveChanges();
               grid.ItemsSource=db.data.ToList();
            }

        }
    }
}
