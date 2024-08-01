using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Nu_3
{
    public class PT_Emp : Emp
    {
        public int Hours { get; set; }
        public double RateHour { get; set; }

        public override double CalculateSalary()
        {
            return Hours * RateHour;
        }
    }
}
