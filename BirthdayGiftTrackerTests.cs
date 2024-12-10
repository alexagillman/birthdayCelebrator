using System;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class BirthdayGiftTrackerTests
    {
        [Fact]
        public void TrackGift_ShouldTrackGiftForPerson()
        {
            // Arrange
            var tracker = new BirthdayGiftTracker();
            var person = new Person("John", new DateTime(1990, 1, 1));
            var gift = "Watch";

            // Act
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                tracker.TrackGift(person, gift);

                // Assert
                var expectedMessage = $"Tracking gift '{gift}' for {person.Name}";
                Assert.Contains(expectedMessage, sw.ToString());
            }
        }
    }
}
