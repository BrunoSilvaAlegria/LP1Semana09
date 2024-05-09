using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower2
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

            if (!File.Exists(fileName)) //Verifies if the file exists
            {
                Console.WriteLine("This file does not exist, " +
                "please enter a valid file name.");
                return;
            }

            //Opens the file for writing 
            using StreamWriter strs = new StreamWriter(fileName);

            strs.WriteLine("LP1 is good! :D"); //Writes this line in the file
        
        } //File is close automatically due to the keyword "using" being used
    }
}