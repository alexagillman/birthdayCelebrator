using System;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class BirthdayWishSenderTests
    {
        [Fact]
        public void SendWish_ShouldPrintWishMessage()
        {
            // Arrange
            var wishSender = new BirthdayWishSender();
            var person = new Person("John", new DateTime(1990, 1, 1));

            // Act
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                wishSender.SendWish(person);

                // Assert
                var expectedMessage = $"🎉 Wishing {person.Name} a very Happy Birthday! 🎂";
                Assert.Contains(expectedMessage, sw.ToString());
            }
        }
    }
}
