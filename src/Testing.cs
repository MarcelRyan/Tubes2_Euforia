using System;
using System.Collections;
using System.IO;
using System.Linq;

class Testing
{

    static void Main3(string[] args)
    {
        string[][] map = FileIO.ReadMapFile("test", false);

        BFSState state = new BFSState(map, false, true, false);

        foreach (var line in map)
        {
            foreach (var c in line)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }

        while (!state.stop)
        {
            state.ShortestPathMove();
            Console.WriteLine(state.position);
            Console.WriteLine(state.foundTreasureCount);
            ArrayList steps = state.GetCurrentRoute();

            foreach (var step in steps)
            {
                Console.Write(step);
            }

            string temp =  Console.ReadLine();

        }
    }
}