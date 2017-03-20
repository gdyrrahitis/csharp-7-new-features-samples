namespace CSharpSeven.Tests.OutVariablesTests
{
    using CSharpSeven.OutVariables;
    using Xunit;

    public class GetIntegerFromString
    {
        [Fact]
        public void ReturnsStringIntegerToIntRepresentation()
        {
            // Arrange
            var number = "3";

            // Act
            var result = StringConverterToInteger.GetIntegerFromString(number);

            // Assert
            Assert.Equal(3, result);
        }
    }
}
