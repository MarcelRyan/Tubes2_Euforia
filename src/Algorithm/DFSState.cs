using System;
using System.Collections;
using System.Linq;

class DFSState
{
    public Tuple<int, int> position { get; private set; }
    public int nodeCount { get; private set; }
    public int stepCount { get; private set; }
    public string[][] map { get; private set; }
    public int row { get; private set; }
    public int col { get; private set; }
    public bool foundAll { get; private set; }
    public bool tspMode { get; private set; }
    
    public bool stop { get; private set; }

    private int treasureCount, foundTreasureCount;

    private bool sequentialMode;

    private Tuple<int, int> initialPosition;

    private Tuple<bool, Tuple<int, int>>[,] _checkMap;

    private Stack _stack; 

    static Tuple<bool, Tuple<int, int>> defaultCheckValue = new Tuple<bool, Tuple<int, int>>(false, new Tuple<int, int>(-1, -1));

    static Tuple<int, int>[] directions = new Tuple<int, int>[4] { 
        new Tuple<int, int>(0, 1), 
        new Tuple<int, int>(1, 0), 
        new Tuple<int, int>(0, -1), 
        new Tuple<int, int>(1, 0) 
    };

    // konfigurasi default objek
    private void defaultConfig()
    {

        position = new Tuple<int, int>(-1, -1);
        nodeCount = 0;
        stepCount = 0;
        treasureCount = 0;
        foundTreasureCount = 0;
        stop = false;
        foundAll = false;
        row = map.Length;
        col = map[0].Length;
        _checkMap = new Tuple<bool, Tuple<int, int>>[row, col];


        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (map[i][j] == "K") initialPosition = new Tuple<int, int>(i, j);

                if (map[i][j] == "T") foundTreasureCount++;

                _checkMap[i, j] = defaultCheckValue;
            }
        }
        _stack = new Stack();
        _stack.Push(initialPosition);
    }

    // cek apakah posisi saat ini valid
    private bool isValid(Tuple<int, int> target)
    {
        if (target.Item1 < 0 || target.Item2 < 0 || target.Item1 >= row || target.Item2 >= col
            || map[target.Item1][target.Item2] == "X"
            || _checkMap[target.Item1, target.Item2].Item1
           )
        {
            return false;
        }

        return true;
    }

    // solusi ditemukan
    private void Terminate()
    {
        stop = true;
        _stack.Clear();
    }

    // ctor
    public DFSState(string[][] map, bool tspMode, bool sequentialMode = false)
    {
        this.map = map;
        this.tspMode = tspMode;
        this.sequentialMode = sequentialMode;
        defaultConfig();
    }

    // mengembalikan matriks visited
    public bool[,] GetVisited()
    {
        bool[,] visited = new bool[row, col];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                visited[i, j] = _checkMap[i, j].Item1;
            }
        }

        return visited;
    }

    // mengembalikan path dari Krusty Crab ke posisi saat ini
    public ArrayList GetCurrentPath()
    {
        ArrayList path = new ArrayList();

        Tuple<int, int> tempPosition = position;

        while (tempPosition.Item1 != -1 && tempPosition.Item2 != -1)
        {
            path.Add(tempPosition);

            tempPosition = _checkMap[tempPosition.Item1, tempPosition.Item2].Item2;
        }

        path.Reverse();

        return path;
    }

    // Berpindah satu langkah dengan pendekatan DFS
    public void Move()
    {
        if (_stack.Count == 0 || stop) return;

        Tuple<int, int> newPosition = (Tuple<int, int>) _stack.Pop();

        if (!isValid(newPosition)) return;

        _checkMap[newPosition.Item1, newPosition.Item2] = new Tuple<bool, Tuple<int, int>>(true, position);

        position = newPosition;

        nodeCount++;

        // sequential mode akan memastikan setiap atribute diperbarui tiap langkah
        if (sequentialMode)
        {
            stepCount = GetCurrentPath().Count;
        }

        if (map[position.Item1][position.Item2] == "T")
        {
            foundTreasureCount++;
            
            // semua treasure ditemukan
            if (foundTreasureCount == treasureCount)
            {
                foundAll = true;
                
                // tspMode tidak terminate karena harus kembali ke titik awal
                if (tspMode) _checkMap[initialPosition.Item1, initialPosition.Item2] = defaultCheckValue;

                // terminate jika bukan tspMode
                else
                {
                    stepCount = GetCurrentPath().Count;
                    Terminate();
                    return;
                }
            }
        }

        else if (map[position.Item1][position.Item2] == "K") Terminate();

        for (int i = 0; i < 4; i++) _stack.Push(new Tuple<int, int>(position.Item1 + directions[i].Item1, position.Item2 + directions[i].Item2));
    }

    public void AutoComplete()
    {
        while (!stop)
        {
            Move();
        }
    }

    public void Reset()
    {
        defaultConfig();
    }

}