using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class BFSState: MazeState{


    private Queue _queue;
    private Queue _shortestPathQueue;

    // ctor

    public BFSState(string[][] map, bool tspMode, bool sequentialMode = false, bool allowMultipleVisits = false) : base(map, tspMode, sequentialMode, allowMultipleVisits)
    {
    }

    // konfigurasi default objek
    protected override void DefaultConfig()
    {
        base.DefaultConfig();
        _queue = new Queue();
        _shortestPathQueue = new Queue();

        _queue.Enqueue(new Tuple<Tuple<int, int>, Tuple<int, int>>(initialPosition, position));
        _shortestPathQueue.Enqueue(new Tuple<Tuple<int, int>, Tuple<int, int>, Tuple<bool, Tuple<int, int>>[,]>(
            initialPosition,
            defaultCheckValue.Item2,
            getMemo()));
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
            Tuple<bool, Tuple<int, int>>[,]>) _shortestPathQueue.Peek();

        while (_shortestPathQueue.Count > 0 && !IsValid(temp.Item1, temp.Item3));
        {
            _shortestPathQueue.Dequeue();

            if (_shortestPathQueue.Count > 0)
                temp = (Tuple<Tuple<int, int>,
                    Tuple<int, int>,
                    Tuple<bool, Tuple<int, int>>[,]>)_shortestPathQueue.Peek();
        }

        // jika queue kosong
        if (_shortestPathQueue.Count == 0)
        {
            // tidak ditemukan solusi

            stop = true;
            return;
        }

        Tuple<int, int> newPosition = temp.Item1;
        temp.Item3[newPosition.Item1, newPosition.Item2] = new Tuple<bool, Tuple<int, int>>(true, position);
        position = newPosition;

        nodeCount++;

        _checkMap = temp.Item3;

        // sequential mode akan memastikan setiap atribute diperbarui tiap langkah
        if (sequentialMode)
        {
            updateStepCount();
        }

        // jika menemukan treasure
        if (GetMapElmt(position) == "T")
        {
            foundTreasureCount++;

            // semua treasure ditemukan
            if (foundTreasureCount == treasureCount)
            {
                foundAll = true;

                // tspMode tidak terminate karena harus kembali ke titik awal
                if (tspMode) temp.Item3[initialPosition.Item1, initialPosition.Item2] = defaultCheckValue;

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
                new Tuple<Tuple<int, int>, Tuple<int, int>, Tuple<bool, Tuple<int, int>>[,]>(
                    new Tuple<int, int>(position.Item1 + directions[i].Item1, position.Item2 + directions[i].Item2),
                    position,
                    getMemo(temp.Item3)
                    ));
        }
    }

    public override void Move()
    {
        if (stop) return;

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


        SetCheckMap(top.Item1, new Tuple<bool, Tuple<int, int>>(true, top.Item2));

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

        
        if (foundAll){
            // Tuple<int, int> position2 = GetCheckMap(position).Item2;
            Tuple<int, int> position = GetCheckMap(top.Item1).Item2;
            Tuple<int, int> position2 = GetCheckMap(position).Item2;
            _queue.Enqueue(
                new Tuple<Tuple<int, int>, Tuple<int, int>>(position,
                        position2));
        }
        else {
            for (int i = 3; i >= 0; i--)
            {
                _queue.Enqueue(
                    new Tuple<Tuple<int, int>, Tuple<int, int>>(
                        new Tuple<int, int>(position.Item1 + directions[i].Item1, position.Item2 + directions[i].Item2),
                            position));
                // }
            }
        }

    }
}