using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n <= args.Length; n++ ) //Gets all the files
            {
                //Gets the argument correspondent to a position
                string fileName = args[n];
                if (File.Exists(fileName)) //Checks if the file exists
                {
                    //Opens the file for reading
                    using StreamReader strs = new StreamReader(fileName);

                    //Determines the end of the file or an error
                    while (strs.Peek() > -1) 
                    {
                        
                    } 
                } 
            }        
        } //File is close automatically due to the keyword "using" being used
    }
}