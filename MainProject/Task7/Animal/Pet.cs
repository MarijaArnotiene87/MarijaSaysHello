using MainProject.Task7.Animal;
using System.Net.Cache;

namespace MainProject.Task7
{
    public class Pet : IJump, IRun
    {
        public string JumpOnTree { get { return "Oh, you are scary..."; } }

        public string Route { get { return "Run to the moon"; } }

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
