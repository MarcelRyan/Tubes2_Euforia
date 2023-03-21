// using System;
// using System.Collections;
// using System.IO;
// using System.Linq;

class Testing
{

    static void Main2(string[] args)
    {
        string[][] map = FileIO.ReadMapFile("test", false);

        BFSState state = new BFSState(map, false, true, true);

        ArrayList steps;

        while (!state.stop)
        {
            state.ShortestPathMove();
            Console.WriteLine(state.position);
            Console.WriteLine(state.foundTreasureCount);
           steps = state.GetCurrentRoute();
        }
    }
}