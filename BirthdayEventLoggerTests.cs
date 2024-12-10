using System;
using Xunit;

namespace birthdayCelebrator.Tests
{
    public class BirthdayEventLoggerTests
    {
        [Fact]
        public void LogEvent_ShouldLogEventMessage()
        {
            // Arrange
            var logger = new BirthdayEventLogger();
            var message = "Test event message";

            // Act
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                logger.LogEvent(message);

                // Assert
                var expectedMessage = $"[Event Log] {message}";
                Assert.Contains(expectedMessage, sw.ToString());
            }
        }
    }
}
