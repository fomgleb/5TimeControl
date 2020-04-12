using System;

namespace TimeControl
{
    class NumberManipulator
    {
        public static string AddZero(Int32 dateTime)
        {
            string result = Convert.ToString(dateTime);
            if (dateTime < 10)
                result = "0" + Convert.ToString(dateTime);
            return result;
        }

        public static int GetNumberDayOfWeek(DayOfWeek dayOfWeek)
        {
            string Day = Convert.ToString(dayOfWeek);
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
