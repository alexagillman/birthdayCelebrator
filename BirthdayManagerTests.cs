using System;
using System.Collections.Generic;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class BirthdayManagerTests
    {
        [Fact]
        public void AddPerson_ShouldAddPersonToList()
        {
            // Arrange
            var manager = new BirthdayManager();
            var name = "John";
            var birthday = new DateTime(1990, 1, 1);

            // Act
            manager.AddPerson(name, birthday);

            // Assert
            var person = manager.GetPerson(name);
            Assert.NotNull(person);
            Assert.Equal(name, person.Name);
            Assert.Equal(birthday, person.Birthday);
        }

        [Fact]
        public void RemovePerson_ShouldRemovePersonFromList()
        {
            // Arrange
            var manager = new BirthdayManager();
            var name = "John";
            var birthday = new DateTime(1990, 1, 1);
            manager.AddPerson(name, birthday);

            // Act
            manager.RemovePerson(name);

            // Assert
            var person = manager.GetPerson(name);
            Assert.Null(person);
        }

        [Fact]
        public void GetPerson_ShouldReturnCorrectPerson()
        {
            // Arrange
            var manager = new BirthdayManager();
            var name = "John";
            var birthday = new DateTime(1990, 1, 1);
            manager.AddPerson(name, birthday);

            // Act
            var person = manager.GetPerson(name);

            // Assert
            Assert.NotNull(person);
            Assert.Equal(name, person.Name);
            Assert.Equal(birthday, person.Birthday);
        }

        [Fact]
        public void CheckBirthdaysToday_ShouldPrintBirthdayMessage()
        {
            // Arrange
            var manager = new BirthdayManager();
            var name = "John";
            var birthday = DateTime.Today;
            manager.AddPerson(name, birthday);

            // Act
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                manager.CheckBirthdaysToday();

                // Assert
                var expectedMessage = $"🎈 Happy Birthday, {name}! 🥳";
                Assert.Contains(expectedMessage, sw.ToString());
            }
        }

        [Fact]
        public void ListUpcomingBirthdays_ShouldPrintUpcomingBirthdays()
        {
            // Arrange
            var manager = new BirthdayManager();
            var name = "John";
            var birthday = DateTime.Today.AddDays(5);
            manager.AddPerson(name, birthday);

            // Act
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                manager.ListUpcomingBirthdays(7);

                // Assert
                var expectedMessage = $"{name} - {birthday.ToString("MMMM dd")}";
                Assert.Contains(expectedMessage, sw.ToString());
            }
        }
    }
}
