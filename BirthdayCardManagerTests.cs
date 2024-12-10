using System;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class BirthdayCardManagerTests
    {
        [Fact]
        public void ManageCards_ShouldPrintManagingMessage()
        {
            // Arrange
            var manager = new BirthdayCardManager();
            var person = new Person("John", new DateTime(1990, 1, 1));

            // Act
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                manager.ManageCards(person);

                // Assert
                var expectedMessage = $"📬 Managing birthday cards for {person.Name}!";
                Assert.Contains(expectedMessage, sw.ToString());
            }
        }
    }
}
