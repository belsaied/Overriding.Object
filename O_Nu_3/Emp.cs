using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Nu_3
{
    public enum Gender { Male, Female }
    public enum Permissions { Read, Update, Delete, All }
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Gender Gender { get; set; }
        public Permissions Permissions { get; set; }
        public virtual double CalculateSalary()
        {
            return Salary;
        }
    }
}
