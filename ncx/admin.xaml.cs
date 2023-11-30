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
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class admin : Page
    {
        clinicEntities entities=new clinicEntities();
        public admin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dg.ItemsSource=entities.USEERs.ToList();
            id.Text = date.Text = depname.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int k = int.Parse(id.Text);
            entities.USEERs.Remove(entities.USEERs.First(x => x.ID == k));
            entities.SaveChanges();
            MessageBox.Show("removed");
            id.Text = date.Text = depname.Text = "";

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int f = int.Parse(id.Text);
            
            USEER d=new USEER();
            d= entities.USEERs.FirstOrDefault(x=>x.ID == f);
            d.DATE_ = Convert.ToDateTime (date.Text);
            d.DEPNAEM = depname.Text;
            entities.USEERs.AddOrUpdate(d);
            entities.SaveChanges();
            MessageBox.Show("update");
            id.Text = date.Text = depname.Text = "";

        }
    }
}
