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
using System.Windows.Shapes;

namespace StudentsApplication
{
    /// <summary>
    /// Interaction logic for Address.xaml
    /// </summary>
    public partial class Address : Window
    {
       
        MainWindow mainWindow;

        public Address(MainWindow main)
        {

            mainWindow = main;
            InitializeComponent();   
        }

        
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.lblAddress.Content = txtHouseN.Text+ " " 
                +txtStreet.Text + ", " +txtPostCode.Text + ", " + txtCity.Text + ", " + txtCountry.Text;
            this.Close();
        }

       
    }
}
