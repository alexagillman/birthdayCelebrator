using System;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class BirthdayCalendarTests
    {
        [Fact]
        public void AddToCalendar_ShouldAddPersonToCalendar()
        {
            // Arrange
            var calendar = new BirthdayCalendar();
            var name = "John";
            var birthday = new DateTime(1990, 1, 1);

            // Act
            calendar.AddToCalendar(name, birthday);

            // Assert
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                calendar.ListCalendar();

                var expectedMessage = $"{name} - {birthday.ToString("yyyy-MM-dd")}";
                Assert.Contains(expectedMessage, sw.ToString());
            }
        }
    }
}
