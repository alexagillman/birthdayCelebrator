using System;
using System.Collections.Generic;
using System.Linq;

namespace birthdayCelebrator
{
    public class BirthdayStatistics
    {
        private List<Person> people;

        public BirthdayStatistics(List<Person> people)
        {
            this.people = people;
        }

        public void GenerateStatistics()
        {
            var totalPeople = people.Count;
            var upcomingBirthdays = people.Count(p => p.Birthday > DateTime.Today);
            var pastBirthdays = people.Count(p => p.Birthday < DateTime.Today);
            var todayBirthdays = people.Count(p => p.IsBirthdayToday());

            Console.WriteLine("Birthday Statistics:");
            Console.WriteLine($"Total People: {totalPeople}");
            Console.WriteLine($"Upcoming Birthdays: {upcomingBirthdays}");
            Console.WriteLine($"Past Birthdays: {pastBirthdays}");
            Console.WriteLine($"Today's Birthdays: {todayBirthdays}");
        }
    }
}
