namespace MainProject.Task7.Animal
{
    public interface IJump
    {
        public const int minHeight = 10;

        string jumpOnTree { get; }

        void Jump();
    }
}
