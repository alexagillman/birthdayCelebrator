using System;

namespace birthdayCelebrator
{
    public class BirthdayMessageSender
    {
        public void SendMessage(Person person)
        {
            Console.WriteLine($"📧 Sending a birthday message to {person.Name}!");
        }
    }
}
