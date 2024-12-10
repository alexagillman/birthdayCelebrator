using System;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class BirthdayGiftManagerTests
    {
        [Fact]
        public void ManageGifts_ShouldPrintCorrectMessage()
        {
            // Arrange
            var manager = new BirthdayGiftManager();
            var person = new Person("John", new DateTime(1990, 1, 1));
            var gift = "Watch";

            // Act
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                manager.ManageGifts(person, gift);

                // Assert
                var expectedMessage = $"Managing gift '{gift}' for {person.Name}";
                Assert.Contains(expectedMessage, sw.ToString());
            }
        }
    }
}
