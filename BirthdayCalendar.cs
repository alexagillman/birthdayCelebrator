using System;
using System.Collections.Generic;

namespace birthdayCelebrator
{
    public class BirthdayCalendar
    {
        private List<Person> calendar = new List<Person>();

        public void AddToCalendar(string name, DateTime birthday)
        {
            calendar.Add(new Person(name, birthday));
        }

        public void ListCalendar()
        {
            Console.WriteLine("\n📅 Birthday Calendar:");
            foreach (var person in calendar)
            {
                Console.WriteLine($"{person.Name} - {person.Birthday.ToString("yyyy-MM-dd")}");
            }
        }
    }
}
