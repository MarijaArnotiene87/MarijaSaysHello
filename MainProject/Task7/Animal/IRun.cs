namespace MainProject.Task7.Animal
{
    public interface IRun
    {
        public const int averageSpeed = 30;

        string jumpOnTree { get; }

        void Run();
    }
}
