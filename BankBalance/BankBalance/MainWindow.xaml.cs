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

namespace BankBalance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double balance = 0;
        string value;
        double credit =0;
        double debit = 0;
        List<string> tranny = new List<string>();

        

        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void btnCredit_Click(object sender, RoutedEventArgs e)
        {
            value = txtMessage.Text;

            if (Double.TryParse(value, out credit))
            {
               
                balance = credit + balance;
                lblBalance.Content = balance;
                listTranny.Items.Add("£" + credit + " added. Your balance is now of £" + balance);
                
               
            }
            else
                lblBalance.Content = value;


        }

        private void btnDebit_Click(object sender, RoutedEventArgs e)
        {
            value = txtMessage.Text;

            if (Double.TryParse(value, out debit))
            {
                
                if(balance - debit < 0)
                {
                    MessageBox.Show("Can't have a negative balance"); 
                }
                else
                {
                    balance = balance - debit;
                    listTranny.Items.Add("£" + debit + " taken out. Your balance is now of £" + balance);

                }
                lblBalance.Content = balance;
            }
            else
                lblBalance.Content = value;
        }
    }
}
