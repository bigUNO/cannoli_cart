using System;
using System.IO;
using System.Collections;

public class RecursiveFileProcessor 
{
    public static void Main(string[] args)
    {
        ProcessDirectory("data");
          
    }

    // Process all files in the directory passed in, recurse on any directories 
    // that are found, and process the files they contain.
    public static void ProcessDirectory(string targetDirectory) 
    {
        // Process the list of files found in the directory.
        string [] fileEntries = Directory.GetFiles(targetDirectory);
        foreach(string fileName in fileEntries)
            SelectFile(fileName);
    }

    public static void ProcessFile(string file)
    {
        Console.WriteLine("    Processing lines in {0}", file);
    }

    public static void SelectFile(string path) 
    {
        Console.WriteLine("Selecting file {0}", path);
        ProcessFile(path);
    }
}