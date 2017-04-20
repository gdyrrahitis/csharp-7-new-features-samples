namespace CSharpSeven.Unit.Tests.ThrowExpression.ThrowerTests
{
    using CSharpSeven.ThrowExpression;
    using System;
    using Xunit;

    public class GetStringLengthOrThrowIfNull
    {
        [Fact]
        public void PassingNullThrowsNullReferenceException()
        {
            // Arrange
            var thrower = new Thrower();

            // Act
            Action action = () => thrower.GetStringLengthOrThrowIfNull(null);

            // Assert
            Assert.Throws<NullReferenceException>(action);
        }

        [Fact]
        public void ReturnsFourWhichIsTheStringLength()
        {
            // Arrange
            const string value = "four";
            var thrower = new Thrower();

            // Act
            var result = thrower.GetStringLengthOrThrowIfNull(value);

            // Assert
            Assert.Equal(4, result);
        }
    }
}
