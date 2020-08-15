using System;

namespace TimeControl
{
    static class NumberManipulator
    {
        public static string AddZero(Int32 dateTime)
        {
            string result = dateTime.ToString();
            if (dateTime < 10)
                result = $"0{dateTime}";
            return result;
        }

        public static int GetNumberDayOfWeek(DayOfWeek dayOfWeek)
        {
            string Day = dayOfWeek.ToString();
            int result;
            switch (Day)
            {
                case "Monday": result = 1; break;
                case "Tuesday": result = 2; break;
                case "Wednesday": result = 3; break;
                case "Thursday": result = 4; break;
                case "Friday": result = 5; break;
                case "Saturday": result = 6; break;
                case "Sunday": result = 7; break;
                default: result = 0; break;
            }
            return result;
        }
    }
}
