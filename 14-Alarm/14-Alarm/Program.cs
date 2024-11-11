namespace _14_Alarm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlarmClock myClock = new AlarmClock();

            myClock.color = "Red";
            myClock.shape = "square";
            myClock.type = 12;
            myClock.hours = 6;

            AlarmClock myClock2 = new AlarmClock("Circle","Blue", 24, 5);

            myClock.DisplayAlarmClock();
            myClock2.DisplayAlarmClock();
        }
    }
}
