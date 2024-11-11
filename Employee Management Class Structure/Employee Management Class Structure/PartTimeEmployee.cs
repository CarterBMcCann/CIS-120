using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Class_Structure
{
    public class PartTimeEmployee : Employee
    {
        // Creates the hours worked and hourly rate variable
        public int HoursWorked;
        public decimal HourlyRate;

        // Constructor for part time employees
        public PartTimeEmployee(int id, string name, string department, int hoursWorked, decimal hourlyRate) : base(id, name, department, 0)
        {
            if (hoursWorked < 0)
                throw new ArgumentException("Hours worked cannot be negative.", nameof(hoursWorked));

            if (hourlyRate < 0)
                throw new ArgumentException("Hourly rate cannot be negative.", nameof(hourlyRate));

            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }

        // Method to calculate pay, using the new variables
        public override decimal CalculatePay()
        {
            if (HoursWorked < 0 || HourlyRate <= 0)
            {
                throw new InvalidOperationException("Hours worked and hourly rate must be positive values.");
            }

            return HoursWorked * HourlyRate;
        }

        // Override ToString, includes hourly information
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Department: {Department}, Hourly Rate: {HourlyRate:C}, Hours Worked: {HoursWorked}";
        } 
    }

}
