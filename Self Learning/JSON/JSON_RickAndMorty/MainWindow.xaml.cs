using Newtonsoft.Json;
using System.IO;
using System.Net.Http;
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

namespace JSON_RickAndMorty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //we do it here beacuse we want the characters to be loaded when the window is loaded
            RickAndMortyAPI api;
            string json;
            using (HttpClient client = new HttpClient())

            {
                json = client.GetStringAsync("https://rickandmortyapi.com/api/character").Result;
                api = JsonConvert.DeserializeObject<RickAndMortyAPI>(json);

            }

            foreach (Character character in api.results)
            {
                cbocharacters.Items.Add(character);

            }

            //learning serialization:
            string json_api_object = JsonConvert.SerializeObject(api); // we don't need to specify data type just what we want to convert
            string json_combobox = JsonConvert.SerializeObject(cbocharacters.Items);

            // File.WriteAllText("what you want to name it", "what do we want to save");
            File.WriteAllText("web_result.json", json);
            File.WriteAllText("api_object.json", json_api_object);
            File.WriteAllText("combobox.json", json_combobox);

        }

        private void btngetinfo_Click(object sender, RoutedEventArgs e)
        {
            UpdateCharacterInformation();
        }

        private void UpdateCharacterInformation()
        {
            Character selectedcharacter = (Character)cbocharacters.SelectedItem;
            imgcharacter.Source = new BitmapImage(new Uri(selectedcharacter.image));
            txtname.Text = selectedcharacter.name;
        }

        private void cbocharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCharacterInformation();
        }
    }
}