using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace GUI
{
    class Helper
    {
        public static string file;
        public static DataTable TableDataFromTextFile(string location)
        {
            DataTable result;
            string[][] map = FileIO.ReadMapFile(location);
            result = FromDataTable(map);
            return result;
        }

        private static DataTable FromDataTable(string[][] map)
        {
            DataTable dt = new DataTable();

            AddColumnToTable(map, ref dt);
            AddRowToTable(map, ref dt);
            return dt;
        }

        private static void AddRowToTable(string[][] map, ref DataTable dt)
        {
            for (int i = 0; i < map.Length; i++)
            {
                DataRow row = dt.NewRow();

                for (int j = 0; j < map[i].Length; j++)
                {
                    if (map[i][j] == "K")
                    {
                        row[j] = "Start";
                    }
                    else if (map[i][j] == "T")
                    {
                        row[j] = "Treasure";
                    }
                    else if (map[i][j] == "R")
                    {
                        row[j] = "";
                    }
                    else if (map[i][j] == "X")
                    {
                        row[j] = 0;
                    }
                }
                dt.Rows.Add(row);
            }
        }

        private static void AddColumnToTable(string[][] map, ref DataTable dt)
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < map[i].Length; j++)
                {
                    DataColumn column = new DataColumn("", typeof(string));
                    dt.Columns.Add(column);
                }
            }
        }
    }
}
