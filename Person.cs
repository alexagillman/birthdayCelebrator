using System;

namespace birthdayCelebrator
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public Person(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public bool IsBirthdayToday()
        {
            return Birthday.Day == DateTime.Today.Day && Birthday.Month == DateTime.Today.Month;
        }

        public void UpdateBirthday(DateTime newBirthday)
        {
            Birthday = newBirthday;
        }
    }
}
