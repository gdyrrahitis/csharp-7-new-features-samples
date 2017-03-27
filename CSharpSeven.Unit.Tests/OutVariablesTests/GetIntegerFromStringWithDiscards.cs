using CSharpSeven.OutVariables;
using Xunit;

namespace CSharpSeven.Tests.OutVariablesTests
{
    public class GetIntegerFromStringWithDiscards
    {
        [Fact]
        public void ReturnsStringIntegerToIntRepresentationWithDiscards()
        {
            // Arrange | Act
            StringConverterToInteger.GetIntegerFromStringWithDiscards(out var x, out _);

            // Assert
            Assert.Equal(5, x);
        }
    }
}
