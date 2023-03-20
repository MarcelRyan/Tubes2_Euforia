using System;
using System.Collections;
using System.Linq;

class DFSState: MazeState
{

    private Stack _stack;

    private Stack _stack2;

    // konfigurasi default objek
    protected override void DefaultConfig()
    {

        base.DefaultConfig();
        _stack = new Stack();
        _stack2 = new Stack();
        _stack.Push(new Tuple<Tuple<int, int>, Tuple<int, int>>(initialPosition, position));
    }

    // solusi ditemukan
    protected override void Terminate()
    {
        stepCount = GetCurrentPath().Count - 1;
        base.Terminate();
        _stack.Clear();
    }

    // ctor
    public DFSState(string[][] map, bool tspMode, bool sequentialMode = false) : base(map, tspMode, sequentialMode)
    {
    }


    // backtrack hingga ada node yang memiliki tetangga yang belum dikunjungi
    protected override void BackTrack()
    {
        if (_stack.Count == 0) return;

        Tuple<int, int> backtrackPoint = ((Tuple<Tuple<int, int>, Tuple<int, int>>)_stack.Peek()).Item2;

        _stack2.Push(backtrackPoint);

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
    public override void Move()
    {
        if (stop) return;

        while (_stack.Count > 0 && !IsValid(((Tuple<Tuple<int, int>, Tuple<int, int>>)_stack.Peek()).Item1))
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

        _stack2.Push(newPosition);

        SetCheckMap(newPosition, new Tuple<bool, Tuple<int, int>>(true, position));

        position = newPosition;

        nodeCount++;

        // sequential mode akan memastikan setiap atribute diperbarui tiap langkah
        if (sequentialMode)
        {
            stepCount = GetCurrentPath().Count-1;
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

    public Stack GetStack()
    {
        Stack temp = new Stack();
        while(_stack2.Count != 0)
        {
            temp.Push(_stack2.Pop());
        }
        return temp;
    }
}