using System;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class BirthdayMessageSenderTests
    {
        [Fact]
        public void SendMessage_ShouldPrintMessage()
        {
            // Arrange
            var sender = new BirthdayMessageSender();
            var person = new Person("John", new DateTime(1990, 1, 1));

            // Act
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                sender.SendMessage(person);

                // Assert
                var expectedMessage = $"📧 Sending a birthday message to {person.Name}!";
                Assert.Contains(expectedMessage, sw.ToString());
            }
        }
    }
}
