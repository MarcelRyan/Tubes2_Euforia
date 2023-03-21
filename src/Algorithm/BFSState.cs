using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class BFSState: MazeState{


    private Queue _queue;
    private Queue _shortestPathQueue;
    private bool[,] totalMemo;
    class StateInfo
    {
        public int stepCount;
        public int foundTreasureCount;
        public Tuple<bool, Tuple<int, int>>[,] memo;
        public Tuple<int, int> prevPosition;

        public int row { get; private set; }
        public int col { get; private set; }

        public static Tuple<bool, Tuple<int, int>>[,] getMemo(int row, int col)
        {
            Tuple<bool, Tuple<int, int>>[,] defaultMemo = new Tuple<bool, Tuple<int, int>>[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    defaultMemo[i, j] = new Tuple<bool, Tuple<int, int>>(false, defaultCheckValue.Item2);
                }
            }

            return defaultMemo;
        }
        private Tuple<bool, Tuple<int, int>>[,] getMemo()
        {
            Tuple<bool, Tuple<int, int>>[,] defaultMemo = new Tuple<bool, Tuple<int, int>>[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    defaultMemo[i, j] = new Tuple<bool, Tuple<int, int>>(false, defaultCheckValue.Item2);
                }
            }

            return defaultMemo;
        }

        private Tuple<bool, Tuple<int, int>>[,] getMemo(Tuple<bool, Tuple<int, int>>[,] other)
        {
            Tuple<bool, Tuple<int, int>>[,] copy = new Tuple<bool, Tuple<int, int>>[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    copy[i, j] = new Tuple<bool, Tuple<int, int>>(other[i, j].Item1, other[i, j].Item2);
                }
            }

            return copy;
        }

        public StateInfo(int row, int col)
        {
            this.prevPosition = new Tuple<int, int>(-1, -1);
            this.foundTreasureCount = 0;
            this.row = row;
            this.col = col;
            this.memo = getMemo();
            this.stepCount = 0;
        }

        public StateInfo(StateInfo other)
        {
            this.prevPosition = other.prevPosition;
            this.foundTreasureCount = other.foundTreasureCount;
            this.row = other.row;
            this.col = other.col;
            this.memo = getMemo(other.memo);
            this.stepCount = other.stepCount;
        }

    };
    // ctor

    public BFSState(string[][] map, bool tspMode, bool sequentialMode = false, bool allowMultipleVisits = false) : base(map, tspMode, sequentialMode, allowMultipleVisits)
    {

    }

    private Tuple<int, int> fromPosition;

    private Tuple<int, int> nowPosition;

    private ArrayList TPosition;

    // konfigurasi default objek
    protected override void DefaultConfig()
    {
        base.DefaultConfig();
        _queue = new Queue();

        _shortestPathQueue = new Queue();

        TPosition = new ArrayList();

        _queue.Enqueue(new Tuple<Tuple<int, int>, Tuple<int, int>>(initialPosition, position));
        _shortestPathQueue.Enqueue(new Tuple<Tuple<int, int>, Tuple<int, int>, StateInfo>(
            initialPosition,
            defaultCheckValue.Item2,
            new StateInfo(row, col)));

        totalMemo = new bool[row, col];
    }

    // solusi ditemukan
    protected override void Terminate()
    {
        base.Terminate();
        _queue.Clear();
        _shortestPathQueue.Clear();
    }

    protected Tuple<bool, Tuple<int, int>> GetCheckMap(Tuple<int, int> p, Tuple<bool, Tuple<int, int>>[,] memo)
    {
        return memo[p.Item1, p.Item2];
    }

    private bool IsValid(Tuple<int, int> target, Tuple<bool, Tuple<int, int>>[,] memo)
    {
        if (target.Item1 < 0 || target.Item2 < 0 || target.Item1 >= row || target.Item2 >= col
           || GetMapElmt(target) == "X"
           || GetCheckMap(target, memo).Item1
          )
        {
            return false;
        }

        return true;
    }

    // hanya untuk allowMultipleVisit = FALSE
    public void ShortestPathMove()
    {
        if (stop) return;
        
        var temp = (Tuple<Tuple<int, int>, 
            Tuple<int, int>,
            StateInfo>) _shortestPathQueue.Dequeue();

        while (_shortestPathQueue.Count > 0 && !IsValid(temp.Item1, temp.Item3.memo))
        {
            if (_shortestPathQueue.Count > 0)
                temp = (Tuple<Tuple<int, int>,
                    Tuple<int, int>,
                    StateInfo>) _shortestPathQueue.Dequeue();

            // jika queue kosong
            else
            {
                // tidak ditemukan solusi
                stop = true;
                return;
            }
        }

        Tuple<int, int> newPosition = temp.Item1;
        temp.Item3.memo[newPosition.Item1, newPosition.Item2] = new Tuple<bool, Tuple<int, int>>(true, temp.Item3.prevPosition);

        temp.Item3.prevPosition = newPosition;
        position = newPosition;


        if (!totalMemo[newPosition.Item1, newPosition.Item2])
        {
            nodeCount++;
            totalMemo[newPosition.Item1, newPosition.Item2] = true;
        }
        

        _checkMap = temp.Item3.memo;

        temp.Item3.stepCount++;
        // sequential mode akan memastikan setiap atribute diperbarui tiap langkah
        if (sequentialMode)
        {
            updateStepCount();
        }

        foundTreasureCount = temp.Item3.foundTreasureCount;

        // jika menemukan treasure
        if (GetMapElmt(position) == "T")
        {
            temp.Item3.foundTreasureCount++;
            foundTreasureCount++;

            // semua treasure ditemukan
            if (temp.Item3.foundTreasureCount == treasureCount)
            {
                foundAll = true;

                // tspMode tidak terminate karena harus kembali ke titik awal
                if (tspMode) temp.Item3.memo[initialPosition.Item1, initialPosition.Item2] = defaultCheckValue;

                // terminate jika bukan tspMode
                else
                {
                    Terminate();
                    return;
                }
            }
        }

        // titik berhenti tsp
        else if (tspMode && GetMapElmt(position) == "K" && foundAll)
        {
            Terminate();
            return;
        }

        // push tetangga ke queue

        for (int i = 3; i >= 0; i--)
        {
            _shortestPathQueue.Enqueue(
                new Tuple<Tuple<int, int>, Tuple<int, int>, StateInfo>(
                    new Tuple<int, int>(position.Item1 + directions[i].Item1, position.Item2 + directions[i].Item2),
                    position,
                    new StateInfo(temp.Item3)
                    ));
        }
    }

    public override void Move()
    {
        if (stop) return;

        if (!allowMultipleVisits)
        {
            ShortestPathMove();
            return;
        }

        while (_queue.Count > 0 && !IsValid(((Tuple<Tuple<int, int>, Tuple<int, int>>)_queue.Peek()).Item1))
        {
            _queue.Dequeue();
        }

        if (_queue.Count == 0)
        {
            stop = true;
            return;
        }

        Tuple<Tuple<int, int>, Tuple<int, int>> top = (Tuple<Tuple<int, int>, Tuple<int, int>>)_queue.Peek();

        Tuple<int, int> newPosition = ((Tuple<Tuple<int, int>, Tuple<int, int>>)_queue.Dequeue()).Item1;

        multipleVisitPath.Add(newPosition);

        treasureFound = false;

        SetCheckMap(top.Item1, new Tuple<bool, Tuple<int, int>>(true, top.Item2));

        position = newPosition;

        // sequential mode akan memastikan setiap atribute diperbarui tiap langkah
        if (sequentialMode)
        {
            updateStepCount();
        }

        if(foundAll && GetMapElmt(position)=="K"){
            fromPosition = nowPosition;
            ArrayList tempPathBFS = new ArrayList();
            tempPathBFS = GetCurrentPath(fromPosition);
            foreach(Tuple<int, int> pathElement in tempPathBFS){
                pathBFS.Add(pathElement);
            }
        }

        if (GetMapElmt(position) == "T")
        {
            foundTreasureCount++;
            treasureFound = true;

            //Mengubah asal dan tujuan untuk path
            TPosition.Add(position);

            if(foundTreasureCount==1){
                fromPosition = defaultCheckValue.Item2;
                nowPosition = position;
            }
            else {
                fromPosition = nowPosition;
                nowPosition = position;
            }

            //Menggabungkan Path
            ArrayList tempPathBFS = new ArrayList();
            tempPathBFS = GetCurrentPath(fromPosition);
            if(foundTreasureCount>0){
                foreach(Tuple<int, int> pathElement in tempPathBFS){
                    pathBFS.Add(pathElement);
                }
            }

            //Mereset semua cell kecuali initial menjadi default
            for ( int i = 0; i < row ; i++){
                for (int j = 0; j < col ; j++){
                    if ((i != position.Item1 || j != position.Item2)&&(i != 0 || j != 0)){
                        Tuple<int, int> temp = new Tuple<int, int>(i,j);
                        SetCheckMap(temp, defaultCheckValue);
                    }
                }
            }
            _queue.Clear();

            //Mengubah treasure yang sudah dilewati supaya tidak masuk bagian ini lagi
            map[position.Item1][position.Item2] = "R";

            // semua treasure ditemukan
            if (foundTreasureCount == treasureCount)
            {
                foundAll = true;

                // tspMode tidak terminate karena harus kembali ke titik awal
                if (tspMode) {
                    GetCurrentPath2(top);
                    SetCheckMap(initialPosition, defaultCheckValue);
                    _queue.Clear();
                }
                // terminate jika bukan tspMode
                else
                {
                    stepCount = GetCurrentPath().Count;
                    Terminate();
                    return;
                }
            }
            if(foundTreasureCount > treasureCount){
                foundTreasureCount--;
            }
        }

        else if (tspMode && GetMapElmt(position) == "K" && foundAll)
        {
            Terminate();
            return;
        }

        for (int i = 3; i >= 0; i--)
        {
            _queue.Enqueue(
                new Tuple<Tuple<int, int>, Tuple<int, int>>(
                    new Tuple<int, int>(position.Item1 + directions[i].Item1, position.Item2 + directions[i].Item2),
                        position));
        }
    }

    public ArrayList GetCurrentPath(Tuple<int, int> fromPosition)
    {
        ArrayList path = new ArrayList();

        Tuple<int, int> tempPosition;

        bool visitedFromPosition = false;
        tempPosition = position;
        while (tempPosition.Item1 != fromPosition.Item1 || tempPosition.Item2 != fromPosition.Item2)
        {
            if(tempPosition.Item1!=-1 && tempPosition.Item2!=-1){
                path.Add(tempPosition);
            }

            if (tempPosition == fromPosition)
            {
                if (visitedFromPosition) tempPosition = fromPosition;

                else visitedFromPosition = true;
            }

            else
            {
                tempPosition = GetCheckMap(tempPosition).Item2;
            }
        }
        if(tempPosition.Item1!=-1 && tempPosition.Item2!=-1){
            path.Add(tempPosition);
        }
        path.Reverse();

        return path;
    }

    public override ArrayList GetCurrentRoute()
    {
        ArrayList currentPath;

        currentPath = getPathBFS();
        
        ArrayList result = new ArrayList();

        for (int i = 0; i < currentPath.Count - 1; i++)
        {

            Tuple<int, int> current = (Tuple<int, int>)currentPath[i];
            Tuple<int, int> next = (Tuple<int, int>)currentPath[i + 1];

            if (next.Item1 - current.Item1 != 0 || next.Item2 - current.Item2 != 0)
                result.Add(directionMap[(next.Item1 - current.Item1, next.Item2 - current.Item2)]);
        }

        return result;
    }

    public void GetCurrentPath2(Tuple<Tuple<int, int>, Tuple<int, int>> top)
    {
        Tuple<int, int> tempPosition = top.Item1;
        int nTimes = 0;

        while (tempPosition.Item1 != -1 && tempPosition.Item2 != -1)
        {
            Tuple<int, int> temp = tempPosition;
            tempPosition = GetCheckMap(tempPosition).Item2;
            if (nTimes > 0)
            {
                SetCheckMap(temp, new Tuple<bool, Tuple<int, int>>(false, tempPosition));
            }
            nTimes++;
        }
    }
}