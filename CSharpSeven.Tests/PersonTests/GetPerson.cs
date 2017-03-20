namespace CSharpSeven.Tests.PersonTests
{
    using CSharpSeven.Tuples;
    using Xunit;

    public class GetPerson
    {
        [Fact]
        public void IsGeorgeDyrrachitisTwentyEightYearsOld()
        {
            // Arrange
            var person = new Person();

            // Act
            var (firstName, lastName, age) = person.GetPerson();

            // Assert
            Assert.Equal("George", firstName);
            Assert.Equal("Dyrrachitis", lastName);
            Assert.Equal(28, age);
        }

        [Fact]
        public void GetOnlyFirstNameGeorgeFromTuple()
        {
            // Arrange
            var person = new Person();

            // Act
            (var firstName, _, _) = person.GetPerson();

            // Assert
            Assert.Equal("George", firstName);
        }

        [Fact]
        public void GetFirstNameAndAgeFromTuple()
        {
            // Arrange
            var person = new Person();

            // Act
            (var firstName, _, var age) = person.GetPerson();

            // Assert
            Assert.Equal("George", firstName);
            Assert.Equal(28, age);
        }

        [Fact]
        public void DeconstructPersonObjectWithDeconstructor()
        {
            // Arrange
            var person = new Person("George", "Dyrrachitis", 28);

            // Act
            var (firstName, lastName, age) = person;

            // Assert
            Assert.Equal("George", firstName);
            Assert.Equal("Dyrrachitis", lastName);
            Assert.Equal(28, age);
        }
    }
}
