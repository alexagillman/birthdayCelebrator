using System;
using System.Collections.Generic;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class BirthdayStatisticsTests
    {
        [Fact]
        public void GenerateStatistics_ShouldPrintCorrectStatistics()
        {
            // Arrange
            var people = new List<Person>
            {
                new Person("John", new DateTime(1990, 1, 1)),
                new Person("Jane", new DateTime(1991, 2, 2)),
                new Person("Doe", DateTime.Today)
            };
            var statistics = new BirthdayStatistics(people);

            // Act
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                statistics.GenerateStatistics();

                // Assert
                var output = sw.ToString();
                Assert.Contains("Total People: 3", output);
                Assert.Contains("Upcoming Birthdays: 0", output);
                Assert.Contains("Past Birthdays: 2", output);
                Assert.Contains("Today's Birthdays: 1", output);
            }
        }
    }
}
