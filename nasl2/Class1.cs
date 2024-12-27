using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasl2
{
    internal class Stu
    {


        public string Name { get; set; }
        private int averageScore;
        public int AverageScore
        {
            get => averageScore;
            set
            {
                if (value >= 0) averageScore = value;
            }
        }
        private int course;
        public int Course
        {
            get => course;
            set { if (value >= 0) course = value; }
        }
        public Stu(string name, int averageScore, int course)
        {
            Name = name;
            AverageScore = averageScore;
            Course = course;
        }

        public virtual double GetQuality()
        {
            return 0.2 * AverageScore * Course;
        }

        public override string? ToString()
        {
            return $"Фамилия:{Name}, Средний балл:{AverageScore}," +
                $" Курс:{Course}.Коэффициент:{GetQuality()}";
        }
    }
}

