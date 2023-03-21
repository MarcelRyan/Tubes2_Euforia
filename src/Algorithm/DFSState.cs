using System;
using System.Collections;
using System.Linq;

class DFSState: MazeState
{

    private Stack _stack;

    // konfigurasi default objek
    protected override void DefaultConfig()
    {

        base.DefaultConfig();
        _stack = new Stack();
        _stack.Push(new Tuple<Tuple<int, int>, Tuple<int, int>>(initialPosition, position));
    }


    // solusi ditemukan
    protected override void Terminate()
    {
        base.Terminate();
        _stack.Clear();
    }

    // ctor
    public DFSState(string[][] map, bool tspMode, bool sequentialMode = false, bool allowMultipleVisits = false) 
        : base(map, tspMode, sequentialMode, allowMultipleVisits)
    {
    }


    // backtrack hingga ada node yang memiliki tetangga yang belum dikunjungi
    private void BackTrack()
    {
        if (_stack.Count == 0) return;

        if (allowMultipleVisits)

        {
            position = GetCheckMap(position).Item2;

            pathWithoutBacktrack.Add(position);
        }

        else
        {
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
    }

    // Berpindah satu langkah dengan pendekatan DFS
    public override void Move()
    {
        // sudah ditemukan solusi atau dapat dipastikan solusi tidak ada
        if (stop) return;

        // buang posisi tidak valid di stack
        while (_stack.Count > 0 && !IsValid(((Tuple<Tuple<int, int>, Tuple<int, int>>)_stack.Peek()).Item1))
        {
            _stack.Pop();
        }

        // jika stack kosong
        if (_stack.Count == 0)
        {
            // jika belum kembali dititik awal dan boleh visit kotak lebih dari sekali
            if (allowMultipleVisits && tspMode && foundAll && GetMapElmt(position) != "K")
            {
                position = GetCheckMap(position).Item2;
                pathWithoutBacktrack.Add(position);
            }

            // tidak ditemukan solusi
            else
            {
                stop = true;
                
            }

            return;

        }

        Tuple<Tuple<int, int>, Tuple<int, int>> top = (Tuple<Tuple<int, int>, Tuple<int, int>>)_stack.Peek();
       
        // jika tujuan bukan tetangga posisi saat ini
        if (top.Item2 != position)
        {
            BackTrack();

            if (allowMultipleVisits) return;
        }

        Tuple<int, int> newPosition = ((Tuple<Tuple<int, int>, Tuple<int, int>>)_stack.Pop()).Item1;

        SetCheckMap(newPosition, new Tuple<bool, Tuple<int, int>>(true, position));
        position = newPosition;

        // path for normal dfs (without backtrack)
        if (allowMultipleVisits) pathWithoutBacktrack.Add(newPosition);

        nodeCount++;

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
                if (tspMode) SetCheckMap(initialPosition, defaultCheckValue);

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

        // push tetangga ke stack
        for (int i = 0; i < 4; i++)
        {
            _stack.Push(
                new Tuple<Tuple<int, int>, Tuple<int, int>>(
                    new Tuple<int, int>(position.Item1 + directions[i].Item1, position.Item2 + directions[i].Item2),
                        position));
        }
    }
}