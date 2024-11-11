namespace _10_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert your name");
            string name = Console.ReadLine();

            Console.WriteLine("Please insert name of class");
            string className = Console.ReadLine();

            int grade = 0;
            int score = 0;
            string numberGrade = "X";
            

            Console.WriteLine("Please insert whole number between 0-100");
            while (true)
            {
                try
                {
                    string variable = Console.ReadLine();

                    if (int.Parse(variable) <= -1 || int.Parse(variable) >= 101) ;
                    {
                        throw new Exception("Please use number 0-100");
                    }

                    try
                    {

                        score = (score + int.Parse(Console.ReadLine()));
                        grade = grade += 1;
                        Console.WriteLine($"Grade {grade} score is {score}, press the x key to quit or insert new number");
                    }
                   
                }

              
            }
            while (true)
            {
                if (score / grade >= 90)
                {
                    numberGrade = "A";
                    break;
                }
                if (score / grade >= 80)
                {
                    numberGrade = "B";
                    break;
                }
                if (score / grade >= 70)
                {
                    numberGrade = "C";
                    break;
                }
                if (score / grade >= 60)
                {
                    numberGrade = "D";
                    break;
                }
                if (score / grade < 60)
                {
                    numberGrade = "F";
                    break;
                }
            }
            Console.WriteLine($"{name}, your {className} letter score is {numberGrade}.");
        }


    }
}
