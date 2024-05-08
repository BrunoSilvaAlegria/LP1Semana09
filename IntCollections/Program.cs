using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int [5] { 1, 10, -30, 10, -5 }; // Numbers to test
            
            // Different collections effect on the same group of numbers
            List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            HashSet<int> hashSet = new HashSet<int>();

            // Cycle that adds each number from the array to each collections
            foreach (int n in array) 
            {
                list.Add(n);
                stack.Push(n);
                queue.Enqueue(n);
                hashSet.Add(n);
            }

            // For the List collection case
            string str = "List: "; 
            foreach (int n in list)
            {
                str += $"{n}, ";
            }
            //Order the numbers were inserted, with repeated numbers
            Console.WriteLine(str.Remove(str.Length - 2)); 

            // For the Stack collection case
            str = "Stack: "; 
            foreach (int n in stack)
            {
                str += $"{n}, ";
            }
            //LIFO order
            Console.WriteLine(str.Remove(str.Length - 2));

            // For the Queue collection case
            str = "Queue: "; 
            foreach (int n in queue)
            {
                str += $"{n}, ";
            }
            //FIFO order
            Console.WriteLine(str.Remove(str.Length - 2));

            // For the HashSet collection case
            str = "HashSet: "; 
            foreach (int n in hashSet)
            {
                str += $"{n}, ";
            }
            //Order the numbers were inserted, without repeated numbers
            Console.WriteLine(str.Remove(str.Length - 2));
        }
    }
}
