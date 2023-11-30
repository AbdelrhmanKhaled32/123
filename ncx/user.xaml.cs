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
    /// Interaction logic for user.xaml
    /// </summary>
    public partial class user : Page
    {
        clinicEntities ff=new clinicEntities(); 
        public user()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (id.Text != "")
            {
                MessageBox.Show("id automatic");
            }
            USEER g= new USEER();
            g.NAME_ = name.Text;
            g.DATE_=Convert.ToDateTime(date.Text);
            g.AGE = int.Parse( age.Text);
            g.ADDRESS_= address.Text;
            g.DEPNAEM = depname.Text;
            ff.USEERs.Add(g);   
            ff.SaveChanges();
            MessageBox.Show("saved");
            name.Text = age.Text = address.Text = date.Text = depname.Text = id.Text = "";
        }
    }
}
