using CSharpSeven.LocalFunctions;
using Xunit;

namespace CSharpSeven.Tests.LocalFunctions.BubblesortTests
{
    public class Sort
    {
        [Theory]
        [InlineData(new[] { 9, 1, 10 }, new[] { 1, 9, 10 })]
        [InlineData(new[] { 99, 11, 66, 22, 77, 55, 88, 99, -5, 11, 44, 88 }, new[] { -5, 11, 11, 22, 44, 55, 66, 77, 88, 88, 99, 99 })]
        public void ArraySuccessfuly(int[] array, int[] ordered)
        {
            // Arrange
            var bubblesort = new Bubblesort(array);

            // Act
            bubblesort.Sort();

            // Assert
            Assert.Equal(ordered, array);
        }
    }
}
