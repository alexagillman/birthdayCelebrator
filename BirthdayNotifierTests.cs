using System;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class BirthdayNotifierTests
    {
        [Fact]
        public void SendNotification_ShouldPrintNotificationMessage()
        {
            // Arrange
            var notifier = new BirthdayNotifier();
            var person = new Person("John", new DateTime(1990, 1, 1));

            // Act
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                notifier.SendNotification(person);

                // Assert
                var expectedMessage = $"🎉 Notification: It's {person.Name}'s birthday today! 🎂";
                Assert.Contains(expectedMessage, sw.ToString());
            }
        }
    }
}
