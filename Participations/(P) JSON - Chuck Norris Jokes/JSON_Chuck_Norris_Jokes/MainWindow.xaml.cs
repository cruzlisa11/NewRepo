﻿using Newtonsoft.Json;
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
using static System.Net.WebRequestMethods;

namespace JSON_Chuck_Norris_Jokes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string url = "https://api.chucknorris.io/jokes/categories";
            string json;
            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(url).Result;
            }
            string[] categories_jokes = JsonConvert.DeserializeObject<string[]>(json);
            cboCategories.Items.Add("All");
            foreach (var category in categories_jokes)
            {
                cboCategories.Items.Add(category);
            }
        }

        private void cboCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string category = cboCategories.SelectedItem.ToString();
            string url = $"https://api.chucknorris.io/jokes/random?category={category}";
            string json;
            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(url).Result;
            }
            var categories_jokes = JsonConvert.DeserializeObject<ChuckNorrisAPI>(json);
            txtjoke.Text = categories_jokes.value;
        }

    }
}
