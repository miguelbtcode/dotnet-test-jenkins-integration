using HelloWorld;
using Xunit;

namespace HelloWorld.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetGreeting_ReturnsHelloWorld()
        {
            // Arrange
            string expected = "Hello World!";

            // Act
            string actual = Program.GetGreeting();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
