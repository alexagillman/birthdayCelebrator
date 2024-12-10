using System;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class BirthdayGiftSuggesterTests
    {
        [Fact]
        public void SuggestGift_ShouldReturnGiftSuggestion()
        {
            // Arrange
            var suggester = new BirthdayGiftSuggester();
            var person = new Person("John", new DateTime(1990, 1, 1));

            // Act
            var result = suggester.SuggestGift(person);

            // Assert
            Assert.Contains("A nice gift for John", result);
        }
    }
}
