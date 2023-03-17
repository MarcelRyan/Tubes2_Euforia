using System;
using System.IO;
using System.Linq;

class MainProgram
{

    static void Main(string[] args)
    {
        string[][] map = FileIO.ReadMapFile("test");
        DFSState dfsState = new DFSState(map, true);

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
            //Console.WriteLine("stack top:" + (Tuple<Tuple<int, int>, Tuple<int, int>>)dfsState._stack.Peek());
            string temp =  Console.ReadLine();
            
        }
    }
}