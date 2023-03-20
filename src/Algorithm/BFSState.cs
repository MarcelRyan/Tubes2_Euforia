using System;
using System.Collections;
using System.Linq;

class BFSState: MazeState{


    private Queue _queue;
    private Queue _queue2;

    // konfigurasi default objek
    protected override void DefaultConfig()
    {
        base.DefaultConfig();
        _queue = new Queue();
        _queue2 = new Queue();
        _queue.Enqueue(new Tuple<Tuple<int, int>, Tuple<int, int>>(initialPosition, position));
    }

    // solusi ditemukan
    protected override void Terminate()
    {
        base.Terminate();
        _queue.Clear();
    }

    // ctor

    public BFSState(string[][] map, bool tspMode, bool sequentialMode = false) : base(map, tspMode, sequentialMode)
    {
    }

    //backtrack hingga ada node yang memiliki tetangga yang belum dikunjungi

    protected override void BackTrack()
    {
    }

    public override void Move()
    {
        if (stop) return;

        while (_queue.Count > 0 && !IsValid(((Tuple<Tuple<int, int>, Tuple<int, int>>)_queue.Peek()).Item1))
        {
            _queue.Dequeue();
        }

        Tuple<Tuple<int, int>, Tuple<int, int>> top = (Tuple<Tuple<int, int>, Tuple<int, int>>)_queue.Peek();

        Tuple<int, int> newPosition = ((Tuple<Tuple<int, int>, Tuple<int, int>>)_queue.Dequeue()).Item1;

        _queue2.Enqueue(newPosition);

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

    public Queue GetQueue()
    {
        // Queue temp = new Queue();
        // while(_queue2.Count != 0){
        //     temp.Enqueue(_queue2.Dequeue());
        // }
        // return temp;
        return _queue2;
    }
}