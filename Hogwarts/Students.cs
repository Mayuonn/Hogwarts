using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class Students
    {
        public String Gender { get; set; }

        public String Faculty { get; set; }

        public String Parental_level_of_education { get; set; }

        public String Lunch { get; set; }

        public String Test_preparation_course { get; set; }

        public int Charms_score { get; set; }

        public int Potions_score { get; set; }

        public int Dark_arts_score { get; set; }

        public static List<Students> LoadFile(String filename)
        {
            List<Students> stud = new List<Students>();
            using (var reader = new StreamReader(filename))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                stud = csv.GetRecords<Students>().ToList();
            return stud;
        }


    }
}
