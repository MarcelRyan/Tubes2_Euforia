using System;
using System.Collections;
using System.IO;
using System.Linq;

class Testing
{

    static void Main2(string[] args)
    {
        string[][] map = FileIO.ReadMapFile("test", false);
        // DFSState dfsState = new DFSState(map, true);
        DFSState dfsState = new DFSState(map, true, true, false);

        foreach (var line in map)
        {
            foreach (var c in line)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }

        while (!dfsState.stop)
        {
            dfsState.Move();
            Console.WriteLine(dfsState.position);
            Console.WriteLine(dfsState.foundTreasureCount);
            
            //string temp =  Console.ReadLine();
            
        }



        ArrayList steps = dfsState.GetCurrentRoute(0);

        foreach (var step in steps)
        {
            Console.Write(step);
        }
    }
}