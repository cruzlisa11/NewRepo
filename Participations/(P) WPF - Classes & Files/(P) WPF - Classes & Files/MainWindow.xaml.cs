using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _P__WPF___Classes___Files
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] lineOfFile = System.IO.File.ReadAllLines("C:\\Users\\josep\\source\\repos\\(P) WPF - Classes & Files\\(P) WPF - Classes & Files\\bin\\Debug\\netcoreapp3.1\\Toy.txt");
            //why is this not working?

            foreach (string line in lineOfFile)
            {

                string[] pieces = line.Split(',');
                Toy toy = new Toy();
                Toy.Name = pieces[0];

                
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}