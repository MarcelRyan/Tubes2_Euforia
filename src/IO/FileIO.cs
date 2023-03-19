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
    static public string[][] ReadMapFile(string fileName, string path = "../test/",string extension = ".txt")
    {
        string validChars = "KTRX";

        string[] lines = File.ReadAllLines(GetTestPath(fileName, path, extension));

        var map = lines.Select(line => line.ToUpper().Split(' ')).ToArray();

        if (map.Length == 0) throw new Exception("Map kosong!");

        int columns = map[0].Length;
        int startCount = 0;
        foreach(var line in map)
        {
            if (line.Length != columns) throw new Exception("Masukan pada setiap baris harus memiliki jumlah karakter yang sama!");
            foreach(var c in line)
            {
                if (c.Length > 1) new Exception("Setiap karakter harus dipisah spasi!");
                if (c == "K") startCount++;
                
                if (!validChars.Contains(c)) throw new Exception("Masukan map memiliki karakter yang tidak valid! Karakter yang diperbolehkan adalah K, T, R, dan X");
            }
        }

        if (startCount != 1) throw new Exception("Titik awal berupa karakter K harus berjumlah 1 pada map!");
        return map;
    }
}    

