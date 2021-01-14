using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalc
{
    public class Salary
    {
        public string Surname { get; set; }
        public decimal Summ { get; set; }
        public override string ToString()
        {
            return $"{Surname} -> {Summ} $";
        }
    }
}
