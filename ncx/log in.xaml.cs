using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Controls;

namespace ncx
{

    public partial class log_in : Page
    {
        clinicEntities dy = new clinicEntities();
        public log_in()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (combo.Text == "Admin")
            {
                ADMIN_ h = dy.ADMIN_.FirstOrDefault(x => x.USERNAME == user1.Text && x.PASSWORD_ == password1.Text);
                if (h==null)
                {
                    MessageBox.Show("invalid");
                }
                else if (h.PASSWORD_ == password1.Text && h.USERNAME == user1.Text)
                {
                    admin dd = new admin();
                    this.NavigationService.Navigate(dd);
                }
            }
            ///
            else if (combo.Text == "User")
            {
              
                    USERP h = dy.USERPs.FirstOrDefault(x => x.USERNAME == user1.Text && x.PASSWORD_ == password1.Text);
                    if (h == null)
                    {
                        MessageBox.Show("invalid");
                    }
                    else if (h.PASSWORD_ == password1.Text && h.USERNAME == user1.Text)
                    {
                        user dd = new user();
                        this.NavigationService.Navigate(dd);
                    }
                
            }
            user1.Text = password1.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sign_up sgin = new sign_up();
            this.NavigationService.Navigate(sgin);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            forget d=new forget();  
            this.NavigationService.Navigate(d);
        }
    }
}
