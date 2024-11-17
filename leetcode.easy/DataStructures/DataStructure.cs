namespace leetcode.easy.DataStructures
{
    public class DataStructure
    {
        public static int[] PlayWithArray()
        {
            int[] array = new int[5];
            array[0] = 8;
            array[1] = 3;
            array[2] = 5;
            array[3] = 4;

            //Sorts the elements
            Array.Sort<int>(array);

            //Reverse the elements in the array
            Array.Reverse(array);

            //Find the element index from the array, returns -1 if element does not exist.
            int index = Array.IndexOf(array, 5);
            return array;
        }

        public static Dictionary<int, string> PlayWithDictionary()
        {
            //Dictionary(Dictionary<TKey, TValue>): Key - value pairs with average O(1) access time.
            //Useful for problems involving lookups, frequency counting, or quick access to values based on unique keys.

            //Declaration of the dictionary
            Dictionary<int, string> keyValDictionary = new Dictionary<int, string>();

            //Adding the elements as key,value
            keyValDictionary.Add(1, "Sagar");
            keyValDictionary.Add(2, "Adam");

            //Check if specific key present or not. returns true/false
            keyValDictionary.ContainsKey(1);

            //Check if specific value present or not. returns true/false
            keyValDictionary.ContainsValue("Mark");


            return keyValDictionary;

        }

        public static List<int> PlayWithList()
        {
            List<int> numList = new List<int> { 5, 2, 7, 9, 1, 3, 5, 6, 7, 2, 1, 5, 0, 4 };

            //Sorts the array
            numList.Sort();

            //Adds new element
            numList.Add(3);

            //Returns true/false if list contains any elements
            bool isAny = numList.Any();
            return numList;
        }

        public static HashSet<int> PlayWithHashset()
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(3);
            set.Add(4);
            set.Add(1);//removes dupes automatically
            set.Add(8);
            set.Add(3);//removes dupes automatically

            //return the average of all the elements
            var avg = set.Average();

            //return the maximum of all the elements
            var max = set.Max();

            //return the minimum of all the elements
            var min = set.Min();

            return set;


        }

        public static Stack<int> PlayWithStack()
        {
            //Stack (Stack<T>): LIFO (Last In, First Out) data structure.
            //Ideal for problems involving nested structures, such as balancing parentheses, processing backtracking, or maintaining order in recursive patterns.
            Stack<int> stack = new Stack<int>();

            //adding elements
            stack.Push(3);
            stack.Push(5);
            stack.Push(1);
            stack.Push(8);
            stack.Push(1);

            //returns the last inserted values
            stack.Pop();

            return stack;
        }

        public static Queue<int> PlayWithQueue()
        {
            //Queue (Queue<T>): FIFO (First In, First Out) data structure.
            //Useful for problems that require processing items in the order they arrived, such as BFS (Breadth-First Search) in trees or graphs.
            Queue<int> queue = new Queue<int>();

            //adding elements
            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Enqueue(1);
            queue.Enqueue(8);
            queue.Enqueue(1);

            //returns the last inserted values
            queue.Dequeue();

            return queue;
        }

        public static LinkedList<int> PlayWithLinkedList()
        {
            //LinkedList (LinkedList<T>): Doubly linked list allowing for efficient insertion and deletion.
            //Useful for implementing certain data structures, like LRU cache, or for problems involving frequent insertions and deletions from both ends of the list.
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(3);
            linkedList.AddLast(3);

            return linkedList;
        }
    }
}

