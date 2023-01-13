using System.Collections;

namespace Homework10.TaskQueue
{
    public static class TaskQueue
    {
        public static Queue<int> Queue { get; set; } = new Queue<int>();

        public static int GetMaxValue()
        {
            int maxValue = 0;
            foreach (var item in Queue)
            {
                if (item > maxValue) maxValue = item;
            }

            return maxValue;
        }

        public static void DeleteMaxValue()
        {
            int maxValue = GetMaxValue();
            int item;
            var success = Queue.TryDequeue(out item);
            while (success)
            {
                if (maxValue == item) break;
                success = Queue.TryDequeue(out item);
            }

            Console.WriteLine(GetMaxValue());
        }
    }
}
