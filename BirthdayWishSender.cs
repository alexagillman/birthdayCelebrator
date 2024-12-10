using System;

namespace birthdayCelebrator
{
    public class BirthdayWishSender
    {
        public void SendWish(Person person)
        {
            Console.WriteLine($"🎉 Wishing {person.Name} a very Happy Birthday! 🎂");
        }
    }
}
