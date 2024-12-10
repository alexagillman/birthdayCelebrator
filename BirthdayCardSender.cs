using System;

namespace birthdayCelebrator
{
    public class BirthdayCardSender
    {
        public void SendCard(Person person)
        {
            Console.WriteLine($"📬 Sending a birthday card to {person.Name}!");
        }
    }
}
