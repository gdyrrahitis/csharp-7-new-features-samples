namespace CSharpSeven.Tuples
{
    public class Person
    {
        public Person()
        {

        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        public (string name, string surname, int age) GetPerson()
        {
            return ("George", "Dyrrachitis", 28);
        }

        public void Deconstruct(out string firstName, out string lastName, out int age)
        {
            firstName = FirstName;
            lastName = LastName;
            age = Age;
        }
    }
}
