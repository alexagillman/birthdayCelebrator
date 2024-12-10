using System;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class BirthdayCardSenderTests
    {
        [Fact]
        public void SendCard_ShouldPrintSendingMessage()
        {
            // Arrange
            var cardSender = new BirthdayCardSender();
            var person = new Person("John", new DateTime(1990, 1, 1));

            // Act
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                cardSender.SendCard(person);

                // Assert
                var expectedMessage = $"📬 Sending a birthday card to {person.Name}!";
                Assert.Contains(expectedMessage, sw.ToString());
            }
        }
    }
}
