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
using System.Windows.Shapes;

namespace Hogwarts
{
    /// <summary>
    /// Логика взаимодействия для studen.xaml
    /// </summary>
    public partial class studen : Window
    {
        List<Students> studlist = new List<Students>();
        public studen()
        {
            InitializeComponent();

            this.studlist = Students.LoadFile("C:\\Users\\фабер\\Desktop\\Students\\Students.csv");
            Excel.ItemsSource = this.studlist;
        }
    }
}
