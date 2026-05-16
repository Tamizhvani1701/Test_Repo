using Xunit;
using Moq;
using Microsoft.Extensions.Logging;
using Test.Controllers;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<WeatherForecastController>>();

            var controller = new WeatherForecastController(mockLogger.Object);

            // Act
            var result = controller.Test();

            // Assert
            Assert.Equal("Connection SuccessFully", result);
        }
    }
}