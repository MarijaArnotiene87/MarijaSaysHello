namespace Homework10.LinkedList
{
    public static class TaskLinkedList
    {
        public static void InsertItems(LinkedList<int> items, int firstItem, int secondItem)
        {
            var currentNode = items.First;
            while (currentNode != null)
            {
                if (firstItem == currentNode.Value) items.AddAfter(currentNode, secondItem);
                currentNode = currentNode.Next;
            }
        }

        public static void MergeLinkedLists(LinkedList<int> list1, LinkedList<int> list2)
        {
            var mergedList = new LinkedList<int>();

            var currentList1Node = list1.First;
            while (currentList1Node != null)
            {
                var currentList2Node = list2.First;
                while (currentList2Node != null)
                {
                    if (currentList1Node.Value == currentList2Node.Value)
                    {
                        mergedList.AddLast(currentList1Node.Value);
                        break;
                    }

                    currentList2Node = currentList2Node.Next;
                }

                currentList1Node = currentList1Node.Next;
            }
        }
    }
}
