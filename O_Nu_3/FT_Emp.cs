using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Nu_3
{
    public class FT_Emp : Emp
    {
        public double Bonus { get; set; }
        public double Deduction { get; set; }

        public override double CalculateSalary()
        {
            return base.CalculateSalary() + Bonus - Deduction;
        }
    }
}
