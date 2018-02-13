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
    /// Interaction logic for Course.xaml
    /// </summary>
    public partial class Course : Window
    {

        MainWindow mainWindow;

        public Course(MainWindow main)
        {
            InitializeComponent();
            mainWindow = main;
            comboCourse.Items.Add("Banana");
            comboCourse.Items.Add("Apple");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.lblCourse.Content = comboCourse.SelectedItem;
            this.Close();
        }
    }
}
