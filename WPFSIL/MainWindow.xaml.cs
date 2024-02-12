using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
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
using WPFSIL.DBO;

namespace WPFSIL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<TodoDTO> _todos;
        private ObservableCollection<TodoDTO> Todos { get { return _todos; } set { _todos = value; } }
        public MainWindow()
        {
            InitializeComponent();
            Todos = new ObservableCollection<TodoDTO>();
            LoadDataAsync();
        }
        private async Task LoadDataAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:7226/Todoes");
                if (responseMessage.IsSuccessStatusCode) 
                { 
                    string json = await responseMessage.Content.ReadAsStringAsync();
                    var todos = JsonConvert.DeserializeObject<List<TodoDTO>>(json);
                    foreach (var todo in todos)
                    {
                        Todos.Add(todo);
                    }
                }
            }
            
        }
    }
}
