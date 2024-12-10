using System;

namespace birthdayCelebrator
{
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayManager birthdayManager = new BirthdayManager();

            // Adding some sample people with birthdays
            birthdayManager.AddPerson("Steve", new DateTime(1954, 9, 28));
            birthdayManager.AddPerson("Alexa", new DateTime(1990, 10, 15));
            birthdayManager.AddPerson("Maria", new DateTime(1992, 12, 20));
            birthdayManager.AddPerson("Ethan", new DateTime(1988, 12, 2));

            // Check if there are birthdays today
            birthdayManager.CheckBirthdaysToday();

            // List upcoming birthdays within the next 14 days
            birthdayManager.ListUpcomingBirthdays(14);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
