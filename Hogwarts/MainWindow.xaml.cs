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

namespace Hogwarts
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            studen TaskWindow = new studen();
            TaskWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Students> studlist = new List<Students>();
            studlist = Students.LoadFile("C:\\Users\\фабер\\Desktop\\Students\\Students.csv");
            int avg = 0;
            foreach (Students item in studlist)
            {
                if (item.Potions_score > 65)
                {
                    avg++;
                }
            }
            MessageBox.Show(avg + " " + "студентов сдали экзамен по зельеварению выше среднего");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Gisto TaskWindow = new Gisto();
            TaskWindow.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            doli TaskWindow = new doli();
            TaskWindow.Show();
        }
    }
}
