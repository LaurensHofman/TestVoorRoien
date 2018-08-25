using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace TestVoorRoien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            grd.DataContext = this;           

            TestList = new ObservableCollection<TestObjects>(new List<TestObjects>()
            {
                new TestObjects()
                {
                    Text = "Persoon 1"
                },
                new TestObjects()
                {
                    Text = "Persoon 2"
                }
            });

            TestDropdownValues = new List<TestDropdownValues>()
            {
                new TestDropdownValues()
                {
                    Value = "Laurens Hofman",
                    Display = "De Haan"
                },
                new TestDropdownValues()
                {
                    Value = "Roien Eshaghzey",
                    Display = "Bredene"
                }
            };

            dg.ItemsSource = TestList;
            dg.DataContext = TestList;
        }

        public List<TestDropdownValues> TestDropdownValues { get; set; }

        public ObservableCollection<TestObjects> TestList { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dg_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            // Hier kan je dan een update/save uitvoeren
        }
    }

    public class TestObjects
    {
        public string Text { get; set; }

        public string ListValue { get; set; }

        public bool IsLaurens
        {
            get
            {
                return this.ListValue == "Laurens Hofman";
            }
        }
    }

    public class TestDropdownValues
    {
        public string Value { get; set; }

        public string Display { get; set; }
    }
}
