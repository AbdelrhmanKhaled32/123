using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for forget.xaml
    /// </summary>
    public partial class forget : Page
    {
        clinicEntities entities=new clinicEntities();

        public forget()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string f = user.Text;

            USERP d = new USERP();
            d = entities.USERPs.FirstOrDefault(x => x.USERNAME == f);
            d.PASSWORD_ = pass.Text;
            entities.USERPs.AddOrUpdate(d);
            entities.SaveChanges();
            MessageBox.Show("update");
           pass.Text = user.Text = "";
        }
    }
}
