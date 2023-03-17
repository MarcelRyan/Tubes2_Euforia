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
    public int treasureCount { get; private set; }
    public int foundTreasureCount { get; private set; }

    private bool sequentialMode;

    private Tuple<int, int> initialPosition;

    private Tuple<bool, Tuple<int, int>>[,] _checkMap;

    public Stack _stack; 

    static Tuple<bool, Tuple<int, int>> defaultCheckValue = new Tuple<bool, Tuple<int, int>>(false, new Tuple<int, int>(-1, -1));

    // arah terbawah menunjukkan arah pertama yang dieksekusi pada DFS (prinsip stack)
    static Tuple<int, int>[] directions = new Tuple<int, int>[4] {
        new Tuple<int, int>(0, -1),
        new Tuple<int, int>(1, 0),
        new Tuple<int, int>(0, 1),
        new Tuple<int, int>(-1, 0),
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

                if (map[i][j] == "T") treasureCount++;

                _checkMap[i, j] = defaultCheckValue;
            }
        }
        _stack = new Stack();
        _stack.Push(new Tuple<Tuple<int, int>, Tuple<int, int>>(initialPosition, position));
    }

    // cek apakah posisi saat ini valid
    private bool isValid(Tuple<int, int> target)
    {
        if (target.Item1 < 0 || target.Item2 < 0 || target.Item1 >= row || target.Item2 >= col
            || GetMapElmt(target) == "X"
            || GetCheckMap(target).Item1
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

    private string GetMapElmt(Tuple<int, int> p)
    {
        return map[p.Item1][p.Item2];
    }

    private Tuple<bool, Tuple<int, int>> GetCheckMap(Tuple<int, int> p)
    {
        return _checkMap[p.Item1, p.Item2];
    }

    private void SetCheckMap(Tuple<int, int> p, Tuple<bool, Tuple<int, int>> val)
    {
        _checkMap[p.Item1, p.Item2] = val;
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

            tempPosition = GetCheckMap(tempPosition).Item2;
        }

        path.Reverse();

        return path;
    }

    // backtrack hingga ada node yang memiliki tetangga yang belum dikunjungi
    private void BackTrack()
    {
        if (_stack.Count == 0) return;

        Tuple<int, int> backtrackPoint = ((Tuple<Tuple<int, int>, Tuple<int, int>>)_stack.Peek()).Item2;

        while (position != backtrackPoint)
        {
            if (GetMapElmt(position) == "T")
            {
                foundTreasureCount--;

                foundAll = false;

                if (tspMode)
                {
                    SetCheckMap(initialPosition, new Tuple<bool, Tuple<int, int>>(true, defaultCheckValue.Item2));
                }
            }

            var temp = position;

            position = GetCheckMap(position).Item2;
     
            SetCheckMap(temp, defaultCheckValue);
        }
    }

    // Berpindah satu langkah dengan pendekatan DFS
    public void Move()
    {
        if (stop) return;

        while (_stack.Count > 0 && !isValid(((Tuple<Tuple<int, int>, Tuple<int, int>>)_stack.Peek()).Item1))
        {
            _stack.Pop();
        }

        if (_stack.Count == 0)
        {
            stop = true;
            return;
        }

        Tuple<Tuple<int, int>, Tuple<int, int>> top = (Tuple<Tuple<int, int>, Tuple<int, int>>)_stack.Peek();
       
        if (top.Item2 != position)
        {
            BackTrack();
            return;
        }

        Tuple<int, int> newPosition = ((Tuple<Tuple<int, int>, Tuple<int, int>>)_stack.Pop()).Item1;

        SetCheckMap(newPosition, new Tuple<bool, Tuple<int, int>>(true, position));

        position = newPosition;

        nodeCount++;

        // sequential mode akan memastikan setiap atribute diperbarui tiap langkah
        if (sequentialMode)
        {
            stepCount = GetCurrentPath().Count;
        }

        if (GetMapElmt(position) == "T")
        {
            foundTreasureCount++;

            // semua treasure ditemukan
            if (foundTreasureCount == treasureCount)
            {
                foundAll = true;

                // tspMode tidak terminate karena harus kembali ke titik awal
                if (tspMode) SetCheckMap(initialPosition, defaultCheckValue);

                // terminate jika bukan tspMode
                else
                {
                    stepCount = GetCurrentPath().Count;
                    Terminate();
                    return;
                }
            }
        }

        else if (tspMode && GetMapElmt(position) == "K" && foundAll)
        {
            Terminate();
            return;
        }

        for (int i = 0; i < 4; i++)
        {
            _stack.Push(
                new Tuple<Tuple<int, int>, Tuple<int, int>>(
                    new Tuple<int, int>(position.Item1 + directions[i].Item1, position.Item2 + directions[i].Item2),
                        position));
        }
    }

    public void AutoComplete()
    {
        // loop sampai tujuan dicapai
        while (!stop)
        {
            Move();
        }
    }

    public void Reset()
    {
        // reset ke posisi awal
        defaultConfig();
    }

}