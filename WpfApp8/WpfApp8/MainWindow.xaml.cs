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

namespace WpfApp8
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
    public Person(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person[] p = { new Person("Péter", 34, "zöld"), new Person("Tamás", 35, "kék"), new Person("Izabella", 25, "narancs"), new Person("Ilona", 22, "sárga") };
            lista.ItemsSource = p;
        }
    }
}