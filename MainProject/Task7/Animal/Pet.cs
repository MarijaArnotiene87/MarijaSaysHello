using MainProject.Task7.Animal;

namespace MainProject.Task7
{
    public class Pet : IJump, IRun
    {
        public string jumpOnTree { get { return "Oh, you are scary..."; } }

        public string route { get { return "Run to the moon"; } }

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
