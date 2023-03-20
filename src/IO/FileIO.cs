using System;
using System.IO;
using System.Linq;

class FileIO
{
 
    static public string FixFileExtension(string fileName, string extension = ".txt")
    {
        string result = fileName;

        if (result.Contains("."))
        {
            int index = result.IndexOf('.');
            result = result.Substring(0, index);
        }

        return result + ".txt";

    }

    static public string GetTestPath(string fileName, string path = "../test/", string extension = ".txt")
    {
        string prefix = "";

#if DEBUG
        prefix = "../../";
#else
        prefix = "";
#endif

        return Path.GetFullPath(prefix + path + FixFileExtension(fileName));

    }
    static public string[][] ReadMapFile(string fileName, bool isAbsolute)
    {
        if (!isAbsolute)
        {
            string path = "../test/";
            string extension = ".txt";

            return ReadMapFile(GetTestPath(fileName, path, extension));
        }

        return ReadMapFile(fileName);
    }

    static public string[][] ReadMapFile(string location)
    {
        string validChars = "KTRX";

        string[] lines = File.ReadAllLines(location);

        var map = lines.Select(line => line.ToUpper().Split(' ')).ToArray();

        if (map.Length == 0) throw new Exception("Map kosong!");

        int columns = map[0].Length;
        int startCount = 0;
        foreach (var line in map)
        {
            if (line.Length != columns) throw new Exception("Each line in configuration file should have the same characters count!");
            foreach (var c in line)
            {
                if (c.Length > 1) new Exception("Each character should be separated with space!");
                if (c == "K") startCount++;

                if (!validChars.Contains(c)) throw new Exception("File contains invalid character(s)! Allowed characters are K, T, R, and X.");
            }
        }

        if (startCount != 1) throw new Exception("Character K as initial point should only be one in map!");
        return map;
    }

}    

