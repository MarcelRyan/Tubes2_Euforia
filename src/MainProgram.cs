using System;
using System.IO;
using System.Linq;

class MainProgram
{

    static void Main(string[] args)
    {
        string[][] map = FileIO.ReadMapFile("test");
        // DFSState dfsState = new DFSState(map, true);
        BFSState bfsState = new BFSState(map, true);

        foreach (var line in map)
        {
            foreach (var c in line)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }

        while (!bfsState.stop)
        {
            bfsState.Move();
            Console.WriteLine(bfsState.position);
            Console.WriteLine(bfsState.foundTreasureCount);
            //Console.WriteLine("stack top:" + (Tuple<Tuple<int, int>, Tuple<int, int>>)dfsState._stack.Peek());
            string temp =  Console.ReadLine();
            
        }
    }
}