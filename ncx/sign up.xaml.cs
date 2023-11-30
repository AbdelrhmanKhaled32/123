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

namespace ncx
{
    /// <summary>
    /// Interaction logic for sign_up.xaml
    /// </summary>
    public partial class sign_up : Page
    {
        clinicEntities dd=new clinicEntities();
        public sign_up()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var d = combo.Text;
            if (d == "Admin")
            {

                ADMIN_ f = new ADMIN_();
                f.USERNAME = username.Text;
                f.PASSWORD_= password.Text;
                dd.ADMIN_.Add(f);
                dd.SaveChanges();
                MessageBox.Show("add in the admin");
                username.Text = password.Text="";
            }
            else if(d =="User")
            {
                USERP ee = new USERP();
                ee.USERNAME = username.Text;
                ee.PASSWORD_ = password.Text;
                dd.USERPs.Add(ee);
                dd.SaveChanges();
                MessageBox.Show("add in the user");
                username.Text = password.Text = "";

            }
        }

        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
