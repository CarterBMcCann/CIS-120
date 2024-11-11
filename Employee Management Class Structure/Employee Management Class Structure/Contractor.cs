using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Class_Structure
{
    public class Contractor : Employee
    {
        // Creates variable to determine date a contract expires
        public DateTime ContractExpiryDate { get; private set; }


        // Constructor for contractors
        public Contractor(int id, string name, string department, decimal baseSalary, DateTime contractExpiryDate) : base(id, name, department, baseSalary)
        {
            if (baseSalary < 0)
                throw new ArgumentException("Base salary cannot be negative.", nameof(baseSalary));

            if (contractExpiryDate < DateTime.Today)
                throw new ArgumentException("Contract expiry date cannot be in the past.", nameof(contractExpiryDate));

            ContractExpiryDate = contractExpiryDate;
        }


        // Method to calculate payment
        public override decimal CalculatePay()
        {
            return BaseSalary;
        }

        // ToString override
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Department: {Department}, Base Salary: {BaseSalary:C}, Contract Expiry Date: {ContractExpiryDate}";
        }
    }
}
