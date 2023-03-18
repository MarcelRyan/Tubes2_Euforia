using System;
using System.Collections;
using System.Linq;

abstract class MazeState
{
    public Tuple<int, int> position { get; protected set; }
    public int nodeCount { get; protected set; }
    public int stepCount { get; protected set; }
    public string[][] map { get; protected set; }
    public int row { get; protected set; }
    public int col { get; protected set; }
    public bool foundAll { get; protected set; }
    public bool tspMode { get; protected set; }
    public bool stop { get; protected set; }
    public int treasureCount { get; protected set; }
    public int foundTreasureCount { get; protected set; }

    protected bool sequentialMode;

    protected Tuple<int, int> initialPosition;

    protected Tuple<bool, Tuple<int, int>>[,] _checkMap;

    static protected Tuple<bool, Tuple<int, int>> defaultCheckValue = new Tuple<bool, Tuple<int, int>>(false, new Tuple<int, int>(-1, -1));

    // arah terbawah menunjukkan arah pertama yang dieksekusi pada DFS (prinsip stack)
    // iterasi arah sebaliknya untuk BFS (prinsip queue)
    static protected Tuple<int, int>[] directions = new Tuple<int, int>[4] {
        new Tuple<int, int>(0, -1),
        new Tuple<int, int>(1, 0),
        new Tuple<int, int>(0, 1),
        new Tuple<int, int>(-1, 0),
    };

    // konfigurasi default objek
    virtual protected void DefaultConfig()
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
    }

    // cek apakah posisi saat ini valid
    protected bool IsValid(Tuple<int, int> target)
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
    virtual protected void Terminate()
    {
        stop = true;
    }

    protected string GetMapElmt(Tuple<int, int> p)
    {
        return map[p.Item1][p.Item2];
    }

    protected Tuple<bool, Tuple<int, int>> GetCheckMap(Tuple<int, int> p)
    {
        return _checkMap[p.Item1, p.Item2];
    }

    protected void SetCheckMap(Tuple<int, int> p, Tuple<bool, Tuple<int, int>> val)
    {
        _checkMap[p.Item1, p.Item2] = val;
    }

    // ctor
    public MazeState(string[][] map, bool tspMode, bool sequentialMode = false)
    {
        this.map = map;
        this.tspMode = tspMode;
        this.sequentialMode = sequentialMode;
        DefaultConfig();
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

    public void GetCurrentPath2(Tuple<Tuple<int, int>, Tuple<int, int>> top)
    {
        Tuple<int, int> tempPosition = top.Item1;
        int nTimes = 0;
        
        while (tempPosition.Item1 != -1 && tempPosition.Item2 != -1)
        {
            Tuple<int, int> temp = tempPosition;
            tempPosition = GetCheckMap(tempPosition).Item2;
            if(nTimes > 0){
                SetCheckMap(temp, new Tuple<bool, Tuple<int, int>>(false, tempPosition));
            }
            nTimes++;
        }
    }

    // backtrack hingga ada node yang memiliki tetangga yang belum dikunjungi
    abstract protected void BackTrack();

    // Berpindah satu langkah dengan pendekatan tertentu
    abstract public void Move();
   
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
        DefaultConfig();
    }

}