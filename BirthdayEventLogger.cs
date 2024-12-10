using System;

namespace birthdayCelebrator
{
    public class BirthdayEventLogger
    {
        public void LogEvent(string message)
        {
            Console.WriteLine($"[Event Log] {message}");
        }
    }
}
