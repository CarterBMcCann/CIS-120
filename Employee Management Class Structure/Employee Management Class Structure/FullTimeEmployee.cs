using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Class_Structure
{
    
    public class FullTimeEmployee : Employee
    {
        // Creates the annual bonus
        public decimal AnnualBonus { get; private set; }

        // Constructor for full time employees
        public FullTimeEmployee(int id, string name, string department, decimal baseSalary, decimal annualBonus) : base(id, name, department, baseSalary)
        {
            if (BaseSalary < 0 || AnnualBonus < 0)
                throw new InvalidOperationException("Cannot calculate pay: base salary or annual bonus is negative.");
        }



        // Method to calculate payment, accounting for bonus
        public override decimal CalculatePay()
        {
            return BaseSalary + AnnualBonus;
        }

        // ToString override, accounting for bonus
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Department: {Department}, Base Salary: {BaseSalary:C}, Annual Bonus: {AnnualBonus:C}";
        }
    }
}
