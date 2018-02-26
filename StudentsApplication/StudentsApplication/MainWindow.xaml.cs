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

namespace StudentsApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string city;
        
        public MainWindow()
        {
            InitializeComponent();
            

        }

        

        private void btnCourse_Click(object sender, RoutedEventArgs e)
        {
            Course c = new Course(this);
            c.ShowDialog();
        }

        private void btnAddress_Click(object sender, RoutedEventArgs e)
        {
            Address a = new Address(this);
            a.ShowDialog();
           
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if ((txtName.Text == "")||(txtMatric.Text == ""))
            {
                MessageBox.Show("Think you are funny?");
            }
        }
    }
}
