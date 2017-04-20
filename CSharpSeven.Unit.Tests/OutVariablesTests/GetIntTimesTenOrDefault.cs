namespace CSharpSeven.Tests.OutVariablesTests
{
    using CSharpSeven.OutVariables;
    using Xunit;

    public class GetIntTimesTenOrDefault
    {
        [Fact]
        public void ReturnsValueTimesTen()
        {
            // Arrange
            var number = "3";

            // Act
            var result = CustomConverter.GetIntTimesTenOrDefault(number);

            // Assert
            Assert.Equal(30, result);
        }

        [Fact]
        public void ReturnsDefaultInt() {
            // Arrange | Act
            var result = CustomConverter.GetIntTimesTenOrDefault("");

            // Assert
            Assert.Equal(0, result);
        }
    }
}
