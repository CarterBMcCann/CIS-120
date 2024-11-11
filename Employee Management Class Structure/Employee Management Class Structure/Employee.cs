using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Employee_Management_Class_Structure
{
    public abstract class Employee
    {
        // Getters and Setters for properties
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Department { get; private set; }
        public decimal BaseSalary { get;  private set; }

        // Default Employee constructo
        public Employee(int id, string name, string department, decimal baseSalary)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(department))
                throw new ArgumentException("Department cannot be null or empty.", nameof(department));

            if (id <= 0)
                throw new ArgumentException("ID must be a positive integer.", nameof(id));

            if (baseSalary < 0)
                throw new ArgumentException("Base salary must be a non-negative decimal number.", nameof(baseSalary));
           
            ID = id;
            Name = name;
            Department = department;
            BaseSalary = baseSalary;

            
        }


        // Calculate Pay, abstract
        public abstract decimal CalculatePay();

        // Default ToString Override
        public override string ToString() 
        {
            return $"ID: {ID}, Name: {Name}, Department: {Department}, Base Salary: {BaseSalary:C}";
        }

    }     

}
