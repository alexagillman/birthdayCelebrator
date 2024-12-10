using System;

namespace birthdayCelebrator
{
    public class BirthdayNotificationManager
    {
        public void ManageNotifications(Person person)
        {
            Console.WriteLine($"🔔 Managing notifications for {person.Name}'s birthday.");
        }
    }
}
