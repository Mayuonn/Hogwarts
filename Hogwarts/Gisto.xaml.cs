using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
    /// Логика взаимодействия для Gisto.xaml
    /// </summary>
    public partial class Gisto : Window
    {
        public Gisto()
        {
            InitializeComponent();

            List<Students> studlist = new List<Students>();
            studlist = Students.LoadFile("C:\\Users\\фабер\\Desktop\\Students\\Students.csv");

            double[] charms = new double[101];
            double[] potions = new double[101];
            double[] darks = new double[101];

            for (int i = 0; i < 101; i++)
            {
                charms[i] = 0;
                potions[i] = 0;
                darks[i] = 0;
            }

            foreach (Students item in studlist)
            {
                charms[item.Charms_score] += 1;
                potions[item.Potions_score] += 1;
                darks[item.Dark_arts_score] += 1;
            }


            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Charms_score",
                    Values = new ChartValues<double> (charms)
                }
            };

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Potions_score",
                Values = new ChartValues<double>(potions)
            });
            
            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Dark_arts_score",
                Values = new ChartValues<double>(darks)
            });
            
            
            Formatter = value => value.ToString("N");

            DataContext = this;    
        }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] BarLabels { get; set; }
        public Func<double, string> Formatter { get; set; } 
    }
}




