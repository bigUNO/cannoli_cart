using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class RecursiveFileProcessor 
{
    public static void Main(string[] args) => ProcessDirectory("data");

    public static void ProcessDirectory(string targetDirectory) 
    {
        // Process the list of files found in the directory.
        string [] fileEntries = Directory.GetFiles(targetDirectory);
        foreach(string fileName in fileEntries)
            SelectFile(fileName);
    }

    public static void ProcessFile(string file)
    {
        List<string> parsedData = new List<string>();
        //Console.WriteLine("    Processing lines in {0}", file);

        using (StreamReader readFile = new StreamReader(file))
        {
            string line;
            string[] row;

            while ((line = readFile.ReadLine()) != null)
            {
                row = line.Split(',');
                Console.WriteLine("Value: {0}",row.GetValue(0));
            } 
        }
    }

    public static void SelectFile(string path) 
    {
        Console.WriteLine("Selecting file {0}", path);
        ProcessFile(path);
    }
}