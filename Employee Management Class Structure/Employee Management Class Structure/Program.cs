using System.Diagnostics.Contracts;

namespace Employee_Management_Class_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Full time employee example
            try
            {
                FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(1, "Sim Cizlak", "Product Testing", 60000, 5000);
                Console.WriteLine(fullTimeEmployee.ToString()); // Display employee details
                Console.WriteLine($"Total Pay: {fullTimeEmployee.CalculatePay():C}"); // Display payment information
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error creating full-time employee: {ex.Message}");
            }

            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error calculating pay: {ex.Message}");
            }
            
           

            // Part Time Employee Example
            try
            {
                PartTimeEmployee partTimeEmployee = new PartTimeEmployee(2, "Jan Irenicus", "Chaos Crafter", 20, 15.5m);
                Console.WriteLine(partTimeEmployee.ToString()); // Details
                Console.WriteLine($"Total Pay: {partTimeEmployee.CalculatePay():C}"); // Payment
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error creating part-time employee: {ex.Message}");
            }

            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error calculating pay: {ex.Message}");
            }

           

            // Contractor Example
            try
            {
                Contractor contractor = new Contractor(007, "Jack Reacher", "Tourist", 100000, new DateTime(2026, 12, 31));
                Console.WriteLine(contractor.ToString()); // Details
                Console.WriteLine($"Total Pay: {contractor.CalculatePay():C}"); // Payment
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error creating Contractor: {ex.Message}");
            }

            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error calculating pay: {ex.Message}");
            }


            // Intentional failure to demonstrate error handling

            try
            {


                FullTimeEmployee fullTimeEmployee2 = new FullTimeEmployee(1234567890, "John Doe", "IT", -60000, -111000);
                Console.WriteLine(fullTimeEmployee2.ToString());
                Console.WriteLine($"Total Pay: {fullTimeEmployee2.CalculatePay():C}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error creating Full-time employee: {ex.Message}");
            }

            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error calculating pay: {ex.Message}");
            }

            try
            {
                
                PartTimeEmployee partTimeEmployee2 = new PartTimeEmployee(1111111121, "Jane Smith", "HR", -10, 20.5m);
                Console.WriteLine(partTimeEmployee2.ToString());
                Console.WriteLine($"Total Pay: {partTimeEmployee2.CalculatePay():C}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error creating Part-time employee: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error calculating pay: {ex.Message}");
            }

            try 
            {
                Contractor contractor2 = new Contractor(007, "James B.", "Tourist", -100000, new DateTime(2020, 12, 31));
                Console.WriteLine(contractor2.ToString());
                Console.WriteLine($"Total Pay: {contractor2.CalculatePay():C}");
            }
            catch (ArgumentException ex) 
            {
              Console.WriteLine($"Error making Contractor: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error calculating pay: {ex.Message}");
            }

        }
    }
}
