using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practice_First_WPF_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncontinue_Click(object sender, RoutedEventArgs e)
        {
            string fname = txtFullName.Text;

            if (string.IsNullOrEmpty(fname) == false)
            {
                MessageBox.Show($"Hello {fname}! Welcome to my application.");
                //eplanation: if the input is not empty, the message box will show the input with a greeting message.
                //if the input is empty, it won't show/ do anything.
            }

            /*You need data validation: a conditional statement ot make sure that the user enter the right data type/information.*/

        }
    }
}