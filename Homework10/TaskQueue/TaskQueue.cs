using System.Collections;
using System.Collections.Generic;

namespace Homework10.TaskQueue
{
    public static class TaskQueue
    {
        public static int GetMaxValue(Queue<int> queue)
        {
            var maxValue = 0;
            foreach (var item in queue)
            {
                if (item > maxValue) maxValue = item;
            }

            return maxValue;
        }

        public static void DeleteMaxValue(Queue<int> queue)
        {
            var maxValue = GetMaxValue(queue);
            int item;
            var success = queue.TryDequeue(out item);
            while (success)
            {
                if (maxValue == item) break;
                success = queue.TryDequeue(out item);
            }

            Console.WriteLine(GetMaxValue(queue));
        }
    }
}
