namespace CSharpSeven.Unit.Tests.PatternMatching.Types.TypesWithIsOperatorTests
{
    using CSharpSeven.PatternMatching.Types;
    using Xunit;

    public class IsNullableIntGreaterThanTen
    {
        [Fact]
        public void ReturnsTrueForGreaterThanTenValue()
        {
            // Arrange
            var types = new TypesWithIsOperator();

            // Act
            var result = types.IsNullableIntGreaterThanTen(20);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ReturnsFalseForLessThanTenValue()
        {
            // Arrange
            var types = new TypesWithIsOperator();

            // Act
            var result = types.IsNullableIntGreaterThanTen(5);

            // Assert
            Assert.False(result);
        }


        [Fact]
        public void ReturnsFalseForNullValue()
        {
            // Arrange
            var types = new TypesWithIsOperator();

            // Act
            var result = types.IsNullableIntGreaterThanTen(null);

            // Assert
            Assert.False(result);
        }
    }
}
