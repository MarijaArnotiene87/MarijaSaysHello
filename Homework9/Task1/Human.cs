namespace Homework9.Task1
{
    public abstract class Human
    {
        public string? name;
        public string? lastName;

        public Human(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }
    }
}
