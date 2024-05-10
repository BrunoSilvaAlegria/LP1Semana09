using System;
using System.Collections.Generic;
using System.IO;

namespace CharSets
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n <= args.Length; n++ ) //Gets all the files
            {
                //Gets the argument correspondent to a position
                string fileName = args[n];

                //Characters storage
                HashSet<char> chars = new HashSet<char>();

                if (File.Exists(fileName)) //Checks if the file exists
                {
                    //Opens the file for reading
                    using StreamReader strs = new StreamReader(fileName);

                    //Determines the end of the file or an error
                    while (strs.Peek() > -1)
                    {
                        //Reads the file line by line
                        string line = strs.ReadLine();
                        if (line.Length > 1)
                        {
                            //Error if there is more than 1 character in a line
                            Console.WriteLine("Error!");
                            break;
                        }
                        else
                        {
                            foreach (char c in line)
                            {
                                chars.Add(c); //Character addition to storage
                                chars.IntersectWith(args[n + 1]);
                            }
                        }
                    }

                } //File is closed automatically due to the keyword "using"
                else Console.WriteLine($"File {fileName} does not exist");
            }        
        } 
    }
}