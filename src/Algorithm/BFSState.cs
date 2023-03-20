using System;
using System.Collections;
using System.Linq;

class BFSState: MazeState{


    private Queue _queue;

    private Tuple<int, int> fromPosition;

    private Tuple<int, int> nowPosition;

    private ArrayList TPosition;

    // konfigurasi default objek
    protected override void DefaultConfig()
    {
        base.DefaultConfig();
        _queue = new Queue();
        _queueProgress = new Queue();
        TPosition = new ArrayList();
        _queue.Enqueue(new Tuple<Tuple<int, int>, Tuple<int, int>>(initialPosition, position));
    }

    // solusi ditemukan
    protected override void Terminate()
    {
        base.Terminate();
        _queue.Clear();
    }

    // ctor

    public BFSState(string[][] map, bool tspMode, bool sequentialMode = false, bool allowMultipleVisits = false) : base(map, tspMode, sequentialMode, allowMultipleVisits)
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

        if (_queue.Count == 0)
        {
            stop = true;
            return;
        }

        Tuple<Tuple<int, int>, Tuple<int, int>> top = (Tuple<Tuple<int, int>, Tuple<int, int>>)_queue.Peek();

        Tuple<int, int> newPosition = ((Tuple<Tuple<int, int>, Tuple<int, int>>)_queue.Dequeue()).Item1;

        _queueProgress.Enqueue(newPosition);


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
                    if ((i != 0 || j != 0)){
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

        
        // if (foundAll){
        //     // Tuple<int, int> position2 = GetCheckMap(position).Item2;
        //     Tuple<int, int> position = GetCheckMap(top.Item1).Item2;
        //     Tuple<int, int> position2 = GetCheckMap(position).Item2;
        //     _queue.Enqueue(
        //         new Tuple<Tuple<int, int>, Tuple<int, int>>(position,
        //                 position2));
        // }
        // else {
        for (int i = 3; i >= 0; i--)
        {
            _queue.Enqueue(
                new Tuple<Tuple<int, int>, Tuple<int, int>>(
                    new Tuple<int, int>(position.Item1 + directions[i].Item1, position.Item2 + directions[i].Item2),
                        position));
            // }
        }
        // }

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
            Console.WriteLine("masuk sini");
            Console.WriteLine(fromPosition);
            Console.WriteLine(tempPosition);
        }
        if(tempPosition.Item1!=-1 && tempPosition.Item2!=-1){
            path.Add(tempPosition);
        }
        Console.WriteLine("masuk sini");
        Console.WriteLine(fromPosition);
        Console.WriteLine(tempPosition);

        path.Reverse();

        return path;
    }
}