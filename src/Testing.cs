using System;
using System.Collections;
using System.IO;
using System.Linq;


class Testing
{

    static void Main2(string[] args)
    {
        string[][] map = FileIO.ReadMapFile("test", false);

        BFSState state = new BFSState(map, true, true, false);

        ArrayList steps;

        while (!state.stop)
        {
            state.ShortestPathMove();
            Console.WriteLine(state.position);
            steps = state.GetCurrentPath();

            Console.Write("Path: ");
            foreach(var step in steps)
            {
                Console.Write(step);
            }

            //var temp = Console.ReadLine();
        }
    }
}