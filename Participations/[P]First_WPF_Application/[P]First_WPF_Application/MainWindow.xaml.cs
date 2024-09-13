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

namespace _P_First_WPF_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtFullName.Focus();
        }

        private void btnProceed_Click(object sender, RoutedEventArgs e)
        {
/*#It gives an error when if try to convert the string to a text*/
            
            //string fname = txtFullName.Text;
            string fulllname = txtFullName1.Text;
            string Adress = txtAddress.Text;
            bool isNameValid = true;
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(fulllname) == true || 
                fulllname.Contains(' ') == false)
            {
              errorMessage += ($"Error. {fulllname} is not a valid name. Please enter your full name.");
                isNameValid = false;
            }

           // MessageBox.Show("Hello, " + fulllname + "! Welcome to my application :3");

            if (string.IsNullOrWhiteSpace(Adress) == true)
            {
                errorMessage += ("Error. Please enter your address.");
                isNameValid = false;
            }

            if(isNameValid == false)
            {
                MessageBox.Show(errorMessage);
                return;
            }

            Student S = new Student();
            S.FirstName = fulllname.Split(' ')[0];
            S.LastName = fulllname.Split(' ')[1];
            S.Address = Adress;

            MessageBox.Show(S.ToString());

            Students.Items.Add(S);
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtFullName1.Text = "";
            txtAddress.Clear();
            txtFullName.Focus();
        }
        private void students_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student selectedStudent = (Student)Students.SelectedItem as Student;
            MessageBox.Show(selectedStudent.ToString());
        }

    }
}