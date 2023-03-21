using System;
using System.Collections;
using System.IO;
using System.Linq;

class Testing
{

    static void Main2(string[] args)
    {
        string[][] map = FileIO.ReadMapFile("test", false);

        BFSState state = new BFSState(map, false, true, true);

        foreach (var line in map)
        {
            foreach (var c in line)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }

        ArrayList steps;

        while (!state.stop)
        {
            state.ShortestPathMove();
            Console.WriteLine(state.position);
            Console.WriteLine(state.foundTreasureCount);
           steps = state.GetCurrentRoute();

            foreach (var step in steps)
            {
                Console.Write(step);
            }

            string temp =  Console.ReadLine();

        }

         steps = state.GetCurrentRoute();

        foreach (var step in steps)
        {
            Console.Write(step);
        }
    }
}