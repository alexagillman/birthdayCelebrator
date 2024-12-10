using System;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class BirthdayNotificationManagerTests
    {
        [Fact]
        public void ManageNotifications_ShouldPrintNotificationMessage()
        {
            // Arrange
            var manager = new BirthdayNotificationManager();
            var person = new Person("John", new DateTime(1990, 1, 1));

            // Act
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                manager.ManageNotifications(person);

                // Assert
                var expectedMessage = $"🔔 Managing notifications for {person.Name}'s birthday.";
                Assert.Contains(expectedMessage, sw.ToString());
            }
        }
    }
}
