using MainProject.Task7.Animal;

namespace MainProject.Task7
{
    public class WildAnimal : IJump, IRun
    {
        public string jumpOnTree { get { return "Jump higher!!"; } }

        public string route { get { return "Run all over the world!!"; } }

        public void Jump()
        {
            Console.WriteLine("Wild animal jumps very high!");
        }

        public void Run()
        {
            Console.WriteLine("Run my dear friend!");
        }
    }
}
