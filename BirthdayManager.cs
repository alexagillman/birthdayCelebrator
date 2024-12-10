using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrator
{
    public class BirthdayManager
    {
        private List<Person> people = new List<Person>();

        public void AddPerson(string name, DateTime birthday)
        {
            people.Add(new Person(name, birthday));
        }

        public void CheckBirthdaysToday()
        {
            Console.WriteLine("\n🎉 Checking for birthdays today...");

            var birthdaysToday = people.Where(p => p.IsBirthdayToday()).ToList();

            if (birthdaysToday.Count > 0)
            {
                foreach (var person in birthdaysToday)
                {
                    Console.WriteLine($"🎈 Happy Birthday, {person.Name}! 🥳");
                }
            }
            else
            {
                Console.WriteLine("No birthdays today.");
            }
        }

        public void ListUpcomingBirthdays(int daysAhead)
        {
            Console.WriteLine($"\n📅 Upcoming birthdays in the next {daysAhead} days:");

            DateTime today = DateTime.Today;
            DateTime futureDate = today.AddDays(daysAhead);

            var upcoming = people.Where(p =>
                (p.Birthday.Month == today.Month && p.Birthday.Day >= today.Day) ||
                (p.Birthday.Month == futureDate.Month && p.Birthday.Day <= futureDate.Day)
            ).ToList();

            if (upcoming.Count > 0)
            {
                foreach (var person in upcoming)
                {
                    Console.WriteLine($"{person.Name} - {person.Birthday.ToString("MMMM dd")}");
                }
            }
            else
            {
                Console.WriteLine("No upcoming birthdays.");
            }
        }
    }
}
