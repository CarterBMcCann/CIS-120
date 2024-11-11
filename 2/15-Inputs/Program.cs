namespace _15_Inputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputValues = new string[10];
            Console.WriteLine("Welcome to the valid inputs program");

           for (int i = 0; i < inputValues.Length; i++) 
           {
                inputValues[i] = getValue();
           }
           displayResults(inputValues);
        }

        public static string getValue() 
        {
            Console.WriteLine("Please enter a number betwee 1 and 10");
            return Console.ReadLine();
        }

        public static void displayResults(string[] inputValues) 
        {
            int valid = 0;
            int invalid = 0;

            foreach (var value in inputValues) 
            {
                try 
                {
                 int cleanValue = int.Parse(value);
                    if (cleanValue < 10 && cleanValue > 0) 
                    {
                        valid++;
                    }
                    else 
                    {
                        invalid++;
                    }
                }
                catch (Exception)
                {
                    invalid++;
                }
            }
            Console.WriteLine($"Valid entries: {valid}\nInvalid entries: {invalid}");
        }  
    }
}
