using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class BFSState: MazeState{


    private Queue _queue;
    private Queue _shortestPathQueue;

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

    private int nReset;

    // konfigurasi default objek
    protected override void DefaultConfig()
    {
        base.DefaultConfig();
        _queue = new Queue();

        _shortestPathQueue = new Queue();

        TPosition = new ArrayList();

        _queue.Enqueue(new Tuple<Tuple<int, int>, Tuple<int, int>>(initialPosition, position));
        _shortestPathQueue.Enqueue(new Tuple<Tuple<int, int>, StateInfo>(
            initialPosition,
            new StateInfo(row, col)));
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
            StateInfo>) _shortestPathQueue.Dequeue();

        while (!IsValid(temp.Item1, temp.Item2.memo))
        {
            if (_shortestPathQueue.Count > 0)
                temp = (Tuple<Tuple<int, int>,
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

        temp.Item2.memo[newPosition.Item1, newPosition.Item2] = new Tuple<bool, Tuple<int, int>>(true, temp.Item2.prevPosition);

        temp.Item2.prevPosition = newPosition;
        position = newPosition;

        // hitung jumlah grid yang dikunjungi
        if (!totalMemo[newPosition.Item1, newPosition.Item2])
        {
            nodeCount++;
            totalMemo[newPosition.Item1, newPosition.Item2] = true;
        }
        
        _checkMap = temp.Item2.memo;

        temp.Item2.stepCount++;
        // sequential mode akan memastikan setiap atribute diperbarui tiap langkah
        if (sequentialMode)
        {
            updateStepCount();
        }

        foundTreasureCount = temp.Item2.foundTreasureCount;
        
        // jika menemukan treasure
        if (GetMapElmt(position) == "T")
        {
            temp.Item2.foundTreasureCount++;
            foundTreasureCount++;

            // semua treasure ditemukan
            if (temp.Item2.foundTreasureCount == treasureCount)
            {
                foundAll = true;

                // tspMode tidak terminate karena harus kembali ke titik awal
                if (tspMode) temp.Item2.memo[initialPosition.Item1, initialPosition.Item2] = defaultCheckValue;

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
                new Tuple<Tuple<int, int>, StateInfo>(
                    new Tuple<int, int>(position.Item1 + directions[i].Item1, position.Item2 + directions[i].Item2),
                    new StateInfo(temp.Item2)
                    ));
        }
    }

    private bool isVisitedTreasure(Tuple<int, int> target)
    {
        foreach(Tuple<int, int> p in TPosition)
        {
            if (p.Equals(target)) return true;
        }

        return false;
    }

    private void addPath(ArrayList nextPath)
    {
        nReset++;
        int idx = 0;
        foreach (Tuple<int, int> pathElement in nextPath)
        {
            if ((nReset > 1 && idx > 0) || (nReset <= 1))
            {
                multipleVisitPath.Add(pathElement);
            }

            idx++;
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

        treasureFound = false;

        SetCheckMap(top.Item1, new Tuple<bool, Tuple<int, int>>(true, top.Item2));

        position = newPosition;

        if (!totalMemo[newPosition.Item1, newPosition.Item2])
        {
            nodeCount++;
            totalMemo[newPosition.Item1, newPosition.Item2] = true;
        }

        // sequential mode akan memastikan setiap atribute diperbarui tiap langkah
        if (sequentialMode)
        {
            updateStepCount();
        }

        if(foundAll && GetMapElmt(position)=="K"){
           
            fromPosition = nowPosition;
            ArrayList tempPathBFS = GetCurrentPath(fromPosition);

            addPath(tempPathBFS);
        }

        if (GetMapElmt(position) == "T" && !isVisitedTreasure(position))
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

            ArrayList tempPathBFS = GetCurrentPath(fromPosition);
            if(foundTreasureCount>0){
                addPath(tempPathBFS);
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

            // semua treasure ditemukan
            if (foundTreasureCount == treasureCount)
            {
                foundAll = true;

                // tspMode tidak terminate karena harus kembali ke titik awal
                if (tspMode) 
                {
                    SetCheckMap(initialPosition, defaultCheckValue);
                }
                // terminate jika bukan tspMode
                else
                {
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

}