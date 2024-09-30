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

namespace JSON
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string json = File.ReadAllText("mock-data_tvhsows.json");
            List<Show> shows = JsonConvert.DeserializeObject<List<Show>>(json);

            //now lets add the shows to the listbox in the window hint: use the correct item name
            foreach(Show show in shows)
            {
                lstshows.Items.Add(show);
            }





        }
    }
}