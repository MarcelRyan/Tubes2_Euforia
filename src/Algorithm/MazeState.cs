using System;
using System.Collections;
using System.Collections.Generic;
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
    public bool allowMultipleVisits { get; protected set; }
    public bool stop { get; protected set; }
    public int treasureCount { get; protected set; }
    public int foundTreasureCount { get; protected set; }

    protected bool sequentialMode;

    public bool treasureFound;
    protected bool[,] totalMemo;
    public Tuple<int, int> initialPosition { get; protected set; }

    protected Tuple<bool, Tuple<int, int>>[,] _checkMap;

    protected ArrayList multipleVisitPath = new ArrayList();

    static protected Tuple<bool, Tuple<int, int>> defaultCheckValue = new Tuple<bool, Tuple<int, int>>(false, new Tuple<int, int>(-1, -1));

    // arah terbawah menunjukkan arah pertama yang dieksekusi pada DFS (prinsip stack)
    // iterasi arah sebaliknya untuk BFS (prinsip queue)
    static protected Tuple<int, int>[] directions = new Tuple<int, int>[4] {
        new Tuple<int, int>(0, -1),
        new Tuple<int, int>(1, 0),
        new Tuple<int, int>(0, 1),
        new Tuple<int, int>(-1, 0),
    };

    static protected Dictionary<(int, int), string> directionMap = new Dictionary<(int, int), string>
    {
        {(0, -1), "L"},
        {(1, 0), "D"},
        {(0, 1), "R"},
        {(-1, 0), "U"},
    };

    // ctor
    public MazeState(string[][] map, bool tspMode, bool sequentialMode = false, bool allowMultipleVisits = false)
    {
        this.map = map;
        this.tspMode = tspMode;
        this.sequentialMode = sequentialMode;
        this.allowMultipleVisits = allowMultipleVisits;
        DefaultConfig();
    }

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
        totalMemo = new bool[row, col];
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

    virtual protected void updateStepCount()
    {
        stepCount = GetCurrentPath().Count - 1;
    }

    // KALAU BISA NODECOUNT UDAH DIHANDLE DIDALAM FUNGSI MOVE DI BFSSTATE
    // UDAH DIHANDLE PAKAI TOTALMEMO
   /* virtual public void updateNodeCountBFS()
    {
        ArrayList tempVisitedPathBFS = new ArrayList();
        foreach(Tuple<int, int> pathTuple in multipleVisitPath){

            int flag = 0;

            foreach(Tuple<int, int> visited in tempVisitedPathBFS){
                if(pathTuple.Item1 == visited.Item1 && pathTuple.Item2 == visited.Item2){
                    flag++;
                }
            }

            if(flag==0)
            {
                nodeCount++;
            }
            else{}
            tempVisitedPathBFS.Add(pathTuple);

        }
    }*/

    // solusi ditemukan
    virtual protected void Terminate()
    {
        updateStepCount();
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

    // mengembalikan urutan arah berdasarkan current path
    virtual public ArrayList GetCurrentRoute()
    {

        ArrayList currentPath = GetCurrentPath();
        ArrayList result = new ArrayList();

        for (int i = 0; i < currentPath.Count - 1; i++)
        {
            Tuple<int, int> current = (Tuple<int, int>)currentPath[i];
            Tuple<int, int> next = (Tuple<int, int>)currentPath[i + 1];

            result.Add(directionMap[(next.Item1 - current.Item1, next.Item2 - current.Item2)]);
        }

        return result;
    }

    

    // mengembalikan path dari Krusty Crab ke posisi saat ini
    virtual public ArrayList GetCurrentPath()
    {
        if (allowMultipleVisits) return multipleVisitPath;

        ArrayList path = new ArrayList();

        Tuple<int, int> tempPosition = position;

        bool visitedInitialPosition = false;

        while (tempPosition.Item1 != -1 && tempPosition.Item2 != -1)
        {
        
            path.Add(tempPosition);

            if (tempPosition.Equals(initialPosition))
            {
                
                if (visitedInitialPosition) tempPosition = defaultCheckValue.Item2;

                else
                {
                    visitedInitialPosition = true;
                    tempPosition = GetCheckMap(tempPosition).Item2;
                }
            }

            else
            {
                tempPosition = GetCheckMap(tempPosition).Item2;
            }

        }

        path.Reverse();

        return path;
    }

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