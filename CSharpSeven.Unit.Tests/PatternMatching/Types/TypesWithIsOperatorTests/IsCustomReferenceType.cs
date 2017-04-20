namespace CSharpSeven.Unit.Tests.PatternMatching.Types.TypesWithIsOperatorTests
{
    using CSharpSeven.PatternMatching.Types;
    using Xunit;

    public class IsCustomReferenceType
    {
        [Fact]
        public void ReturnsTrueForCustomReferenceType()
        {
            // Arrange
            var types = new TypesWithIsOperator();
            var value = new CustomReferenceType();

            // Act
            var result = types.IsCustomReferenceType(value);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ReturnsFalseForNullValue()
        {
            // Arrange
            var types = new TypesWithIsOperator();

            // Act
            var result = types.IsCustomReferenceType(null);

            // Assert
            Assert.False(result);
        }
    }
}
