namespace Homework7.Task2
{
    public class Pet : IJump, IRun
    {
        public string JumpOnTree { get => "Oh, you are scary..."; }

        public string Route { get => "Run to the moon"; }

        public void Jump()
        {
            Console.WriteLine("Pets jumps not so very high.");
        }

        public void Run()
        {
            Console.WriteLine("Run! Run! Run!");
        }
    }
}
