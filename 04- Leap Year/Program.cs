using System.ComponentModel.Design;
// Program by Carter McCann to determine if a given year is a leap year
namespace _04__Leap_Year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Year"); // Prompt user for input
            int year = int.Parse(Console.ReadLine());

            // Test for divisibilty of given year and if year is a leap year, output
            { if (((year % 4 == 0) && (year % 100 != 0)) || ((year % 4 == 0) && (year % 100 == 0) && (year % 400 == 0))) Console.WriteLine($"{year} is a leap year.");
              else Console.WriteLine($"{year} is not a leap year");

                if (year % 4 == 0) Console.WriteLine($"{year} is divisible by 4"); // Test divisibility by 4
                else Console.WriteLine($"{year} is not divisible by 4");
                {
                    if (year % 100 == 0) Console.WriteLine($"{year} is divisible by 100"); //Test divisibility by 100
                    else Console.WriteLine($"{year} is not divisble by 100");
                    {
                        if (year % 400 == 0) Console.WriteLine($"{year} is divisible by 400"); // Test divisibility by 400
                        else Console.WriteLine($"{year} is not divisible by 400");
                    }
                }



            }
               


        }

    }
}
