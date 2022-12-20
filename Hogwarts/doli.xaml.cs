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
    /// Логика взаимодействия для doli.xaml
    /// </summary>
    public partial class doli : Window
    {
        public doli()
        {
            InitializeComponent();

            List<Students> studlist = new List<Students>();
            studlist = Students.LoadFile("C:\\Users\\фабер\\Desktop\\Students\\Students.csv");

            int count_stud = studlist.Count;
            double count_man = 0;
            double count_woman = 0;

            foreach (Students item in studlist)
            {
                if(item.Gender == "male")
                {
                    count_man++;
                }
                else
                {
                    count_woman++;
                }
            }
            man.Text = count_man / count_stud + " ";
            woman.Text = count_woman / count_stud + " ";
            student_count.Text = count_stud.ToString();

        }
    }
}
