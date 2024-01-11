using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee : Person
    {
        // Inherit All Attributes And Methods From Person Class
        public decimal BasicSalary { get; private set; }
        public int TaxPercentage { get; private set; }
        public void SetBasicSalary(decimal basicSalary)
        {
            if (basicSalary < 0)
                throw new ArgumentException("Invalid Salary Value");
            BasicSalary = basicSalary;
        }
        public void SetTaxPercentage(int taxPercentage)
        {
            if (taxPercentage < 10)
                throw new ArgumentException("Invalid Tax Percentage Value");
            TaxPercentage = taxPercentage;
        }
    }
}
