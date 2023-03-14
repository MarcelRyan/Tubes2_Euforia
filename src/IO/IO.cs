using System;
using System.IO;
using System.Linq;

class IO
{
 
    static string FixFileExtension(string fileName, string extension = ".txt")
    {
        string result = fileName;

        if (result.Contains("."))
        {
            int index = result.IndexOf('.');
            result = result.Substring(0, index);
        }

        return result + ".txt";

    }
    static string[][] ReadMapFile(string fileName, string path = "../../test/",string extension = ".txt")
    {

        string[] lines = File.ReadAllLines(Path.GetFullPath(path + FixFileExtension(fileName)));

        var map = lines.Select(line => line.Split(' ')).ToArray();

        return map;
    }

    static void Main(string[] args) {
        ReadMapFile("test.3");
    }
}    

