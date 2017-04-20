namespace CSharpSeven.Tests.OutVariablesTests
{
    using CSharpSeven.OutVariables;
    using Xunit;

    public class GetIntegerFromStringWithDiscards
    {
        [Fact]
        public void ReturnsStringIntegerToIntRepresentationWithDiscards()
        {
            // Arrange | Act
            CustomConverter.GetIntegerFromStringWithDiscards(out var x, out _);

            // Assert
            Assert.Equal(5, x);
        }
    }
}
