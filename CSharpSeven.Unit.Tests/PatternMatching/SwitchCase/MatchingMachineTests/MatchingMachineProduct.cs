namespace CSharpSeven.Tests.PatternMatching.SwitchCase.MatchingMachineTests
{
    using CSharpSeven.PatternMatching.SwitchCase;
    using System;
    using Xunit;

    public class MatchingMachineProduct
    {
        [Fact]
        public void MatchesPizzaPatternInSwitch()
        {
            // Arrange
            var patternMatching = new PatternMatching();
            IMachine pizza = new PizzaMachine();

            // Act
            var result = patternMatching.MatchingMachineProduct(pizza);

            // Assert
            Assert.Equal("Pizza", result);
        }

        [Fact]
        public void MatchesFishAndChipsPatternInSwitch()
        {
            // Arrange
            var patternMatching = new PatternMatching();
            IMachine fishAndChips = new FishAndChipsMachine();

            // Act
            var result = patternMatching.MatchingMachineProduct(fishAndChips);

            // Assert
            Assert.Equal("Fish and chips", result);
        }

        [Fact]
        public void MatchesNotInCasePatternInSwitch()
        {
            // Arrange
            var patternMatching = new PatternMatching();
            IMachine notInCase = new NotInCaseMachine();

            // Act
            var result = patternMatching.MatchingMachineProduct(notInCase);

            // Assert
            Assert.Equal(null, result);
        }

        [Fact]
        public void HandlesExceptionForDefaultCase()
        {
            // Arrange
            var patternMatching = new PatternMatching();

            // Act | Assert
            Assert.Throws<ArgumentNullException>("machine", () => patternMatching.MatchingMachineProduct(null));
        }
    }
}
