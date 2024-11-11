using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Alarm
{
    public class AlarmClock
    {
        //Properties
        private string Shape;
        private string Color;
        private int Type;
        private int Hours;

        public string shape
        {
            get { return Shape; }
            set { Shape = value; }
        }
        public string color
        {
            get { return Color; }
            set { Color = value; }
        }
        public int type
        {
            get { return Type; }
            set { Type = value == 12 ||value == 24 ? 12 : value; }
        }
        public int hours 
        {
            get { return Hours; }
            set { Hours = value; }
        }

        public AlarmClock(string InputShape, string InputColor, int InputType, int InputHours)
        {
            shape = InputShape;
            color = InputColor;
            type = InputType;
            hours = InputHours;
        }
        public AlarmClock()
        {

        }
        public string GetTime() 
        {
            if(Type == 12) 
            {
                string time = DateTime.Now.ToString("hh:mm");
                return time;
            }
            else 
            {
              string time = DateTime.Now.ToString("HH:MM");
                return time;
            }
        
        }

        public void DisplayAlarmClock()
        {
            Console.WriteLine($"The current time is {GetTime()} and the alarm is set for {Hours} hour(s) from now.");

        }
    }
}
