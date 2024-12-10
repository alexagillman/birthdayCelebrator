using System;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class BirthdayReminderSchedulerTests
    {
        [Fact]
        public void ScheduleReminder_ShouldPrintScheduledReminderMessage()
        {
            // Arrange
            var scheduler = new BirthdayReminderScheduler();
            var person = new Person("John", new DateTime(1990, 1, 1));
            var reminderDate = new DateTime(2023, 12, 25);

            // Act
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                scheduler.ScheduleReminder(person, reminderDate);

                // Assert
                var expectedMessage = $"📅 Reminder scheduled for {person.Name} on {reminderDate.ToString("MMMM dd")}";
                Assert.Contains(expectedMessage, sw.ToString());
            }
        }
    }
}
