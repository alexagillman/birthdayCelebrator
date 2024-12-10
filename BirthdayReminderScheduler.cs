using System;

namespace birthdayCelebrator
{
    public class BirthdayReminderScheduler
    {
        public void ScheduleReminder(Person person, DateTime reminderDate)
        {
            Console.WriteLine($"📅 Reminder scheduled for {person.Name} on {reminderDate.ToString("MMMM dd")}");
        }
    }
}
