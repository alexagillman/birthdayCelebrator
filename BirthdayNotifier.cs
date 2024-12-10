using System;

namespace birthdayCelebrator
{
    public class BirthdayNotifier
    {
        public void SendNotification(Person person)
        {
            Console.WriteLine($"🎉 Notification: It's {person.Name}'s birthday today! 🎂");
        }
    }
}
