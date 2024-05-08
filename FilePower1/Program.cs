using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = args[0]; //Gets the argument
            
            if (args.Length <= 0) //Verifies if the argument was entered
            {
                Console.WriteLine("Please enter a file name.");
                return;
            }

            if (!File.Exists(filePath)) //Verifies if the file exists
            {
                Console.WriteLine("This file does not exist, " +
                "please enter a valid file name.");
                return;
            }

            //Queue to store future written strings
            Queue<string> strs = new Queue<string>();

            string fileLines; //Variable that stores the written strings
        }
    }
}
