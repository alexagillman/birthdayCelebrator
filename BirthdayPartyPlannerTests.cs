using System;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class BirthdayPartyPlannerTests
    {
        [Fact]
        public void PlanParty_ShouldPrintPlanningMessage()
        {
            // Arrange
            var planner = new BirthdayPartyPlanner();
            var person = new Person("John", new DateTime(1990, 1, 1));

            // Act
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                planner.PlanParty(person);

                // Assert
                var expectedMessage = $"🎉 Planning a birthday party for {person.Name} on {person.Birthday.ToString("MMMM dd")}! 🎂";
                Assert.Contains(expectedMessage, sw.ToString());
            }
        }
    }
}
