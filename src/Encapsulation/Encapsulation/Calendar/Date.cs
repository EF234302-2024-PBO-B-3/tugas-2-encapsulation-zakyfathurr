using System;


namespace Encapsulation.Calendar
{
    public class Date
    {
        public int Month{ get;private set; }
        public int Day{ get;private set; }
        public int Year{ get;private set; }

        private bool IsValidDate(int month,int day)
        {
            if (month < 0 || month>12 || day < 0 || day>31)return false;
            return true;
        }
        
        public Date(int month, int day, int year)
        {
            Year = year;
            Month = month;
            Day = day;
            if (!IsValidDate(month, day))
            {
                Year=1970;
                Month=1;
                Day=1;
            }
        }
        public void DisplayDate()
        {
            Console.WriteLine($"{Month}/{Day}/{Year}");
        }
    }
}