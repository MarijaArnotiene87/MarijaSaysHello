namespace Homework7.Task2
{
    public interface IJump
    {
        public const int MinHeight = 10;

        string JumpOnTree { get; }

        void Jump();
    }
}
