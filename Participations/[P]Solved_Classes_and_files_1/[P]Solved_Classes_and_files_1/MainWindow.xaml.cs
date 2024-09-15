
using System.IO;
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

namespace _P_Solved_Classes_and_files_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*You want the data to be populated when the window is loaded, so you need to read the file*/
            string[] contentsOfFile = File.ReadAllLines("Toys.csv");
            //string contentsOfFile[0]= Manufacturer,Name,Price,Image';

            //do a loop to read the file - you could do a for loop or a foreach loop

            //Ask TA about this
          
            foreach (string line in contentsOfFile.Skip(1)) 
        {
                string[] pieces = line.Split(",");
                Toy toy = new Toy();
                {
                    Manufacturer = pieces[0];
                    Name = pieces[1];
                    Price = Convert.ToDouble(pieces[2]);
                    Image = pieces[3];
                };





            }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnsave_toy_Click(object sender, RoutedEventArgs e)
        {

        }
    }

        public string Manufacturer { get; }
        public double Price { get; }
        public string Image { get; }
    }