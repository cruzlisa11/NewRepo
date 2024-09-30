using Newtonsoft.Json;
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

namespace _P_JSON_FromAFile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            string json = File.ReadAllText("Mock_Data_Car_Owners.json");
            string[] owners = JsonConvert.DeserializeObject<string[]>(json);
            foreach (var owner in owners)
            {
                lstowners.Items.Add(owner);
            }

            var colors = owners.Select(o => o.Color).Distinct().ToList();


        }

      /*  public void cboCOLOR_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
                lstowners.Items.Clear();

                string selectedColor = cboCOLOR.SelectedItem as string;

            // Filter the owners based on the selected color
            var filteredOwners = owners.Where(o => o.CarColor == selectedColor).ToList();

                // Display the filtered owners in the ListBox
                foreach (Owner owner in filteredOwners)
                {
                    lstowners.Items.Add(owner);
                }

            }*/

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Owner selectedcolor = (Owner)cboCOLOR.SelectedItem;

        }
    }

    }