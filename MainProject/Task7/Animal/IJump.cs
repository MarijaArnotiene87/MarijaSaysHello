namespace MainProject.Task7.Animal
{
    public interface IJump
    {
        public const int minHeight = 10;

        string JumpOnTree { get; }

        void Jump();
    }
}
