using System;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class BirthdayReminderTests
    {
        [Fact]
        public void SendReminder_ShouldPrintReminderMessage()
        {
            // Arrange
            var reminder = new BirthdayReminder();
            var person = new Person("John", new DateTime(1990, 1, 1));

            // Act
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                reminder.SendReminder(person);

                // Assert
                var expectedMessage = $"🔔 Reminder: {person.Name}'s birthday is coming up on {person.Birthday.ToString("MMMM dd")}! 🎉";
                Assert.Contains(expectedMessage, sw.ToString());
            }
        }
    }
}
