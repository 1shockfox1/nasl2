using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nasl2
{
    internal class Class2 : Stu
    {
        public bool P;
       
        
        public Class2 (string name, int averageScore, int course, bool p) : base(name, averageScore, course)
        {
            P = p ;
        }

        public override double GetQuality()
        {
            if (P == true)
            {
                return 2 * GetQuality();
            }
            else
            {
                return 0.9 * GetQuality();
            }
        }

        public override string? ToString()
        {
            return $"ФИО:{Name}, количество битв:{AverageScore}," +
                $" количество побед:{Course}," +
                $" количество побед с превосходящими силами:{P}.Коэффициент:{GetQuality()}";
        }
    }
}
