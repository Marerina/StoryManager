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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace StoryManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Link startLink;
        List<StoryLine> storyLines;
        Link _storyline_folder;

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            startLink = new Link("Первый конфиг", "start.cfg");
            if (!startLink.Check()) { MessageBox.Show("Файл start.cfg не найден!", "Ошибка!"); }
            else
            {
                
                using (StreamReader sr = new StreamReader(startLink.Path))
                {
                    _storyline_folder = new Link("Папка с историями", sr.ReadLine());
                    FillComboBox(_storyline_folder.Path);
                }
            }
        }
        void FillComboBox(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            DirectoryInfo[] di1 = di.GetDirectories();
            foreach (var v in di1)
            {
                storyLines = new List<StoryLine>();
                storyLines.Add(new StoryLine(new Link(v.Name, v.FullName)));
                comboBox_StoryList.Items.Add(v.Name);
            }
            
        }
        private void list_characters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button_properties_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
