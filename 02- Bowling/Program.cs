namespace _02__Bowling
// Program to give sum and average of individual and team scores in bowling by Carter McCann
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int P1score1;
            int P1score2;
            int P1score3;
            int P2score1;
            int P2score2;
            int P2score3;
            int sumShannon; // Shannon's overall score
            double avgShannon; // Shannon's average per game
            int sumJasmine; // Jasmine's overall score
            double avgJasmine; // Jasmine's average per game
            double teamAvg; // Average of the team 
            
            //Data gathering module

            Console.WriteLine("Shannon input score 1");
            P1score1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Shannon input score 2");
            P1score2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Shannon input score 3");
            P1score3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Jasmine input score 1");
            P2score1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Jasmine input score 2");
            P2score2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Jasmine input score 3");
            P2score3 = int.Parse(Console.ReadLine());

            // Calculations
            
            sumShannon = P1score1 + P1score2 + P1score3;
            sumJasmine = P2score1 + P2score2 + P2score3;
            avgShannon = sumShannon / 3;
            avgJasmine = sumJasmine / 3;
            teamAvg = (avgShannon + avgJasmine) / 2;

            //Output 

            Console.WriteLine("Shannon your sum is");
            Console.WriteLine(sumShannon);
            Console.WriteLine("and your average is");
            Console.WriteLine(avgShannon);
            Console.WriteLine("Jasmine your sum is");
            Console.WriteLine(sumJasmine);
            Console.WriteLine("and your average is");
            Console.WriteLine(avgJasmine);
            Console.WriteLine("Your team average is");
            Console.WriteLine(teamAvg);

        }
    }
}
