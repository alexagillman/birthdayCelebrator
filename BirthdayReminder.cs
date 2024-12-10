using System;

namespace birthdayCelebrator
{
    public class BirthdayReminder
    {
        public void SendReminder(Person person)
        {
            Console.WriteLine($"🔔 Reminder: {person.Name}'s birthday is coming up on {person.Birthday.ToString("MMMM dd")}! 🎉");
        }
    }
}
