using System;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class PersonTests
    {
        [Fact]
        public void UpdateBirthday_ShouldUpdateBirthday()
        {
            // Arrange
            var person = new Person("John", new DateTime(1990, 1, 1));
            var newBirthday = new DateTime(1991, 2, 2);

            // Act
            person.UpdateBirthday(newBirthday);

            // Assert
            Assert.Equal(newBirthday, person.Birthday);
        }
    }
}
