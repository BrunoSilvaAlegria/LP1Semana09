﻿using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Different collections effect on the same group of numbers
            List<int> list = new List<int> { 1, 10, -30, 10, -5 };
            Stack<int> stack = new Stack<int> { 1, 10, -30, 10, -5 };
            Queue<int> queue = new Queue<int> { 1, 10, -30, 10, -5 };
            HashSet<int> hashSet = new HashSet<int> { 1, 10, -30, 10, -5 };
        }
    }
}
