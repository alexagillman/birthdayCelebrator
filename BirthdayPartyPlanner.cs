using System;

namespace birthdayCelebrator
{
    public class BirthdayPartyPlanner
    {
        public void PlanParty(Person person)
        {
            Console.WriteLine($"🎉 Planning a birthday party for {person.Name} on {person.Birthday.ToString("MMMM dd")}! 🎂");
        }
    }
}
