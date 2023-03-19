using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;

namespace GUI
{
    public partial class Treasure_Hunt_Solver : Form
    {
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse);

        private bool tspButtonIsClicked = false;

        private bool dfsButtonIsClicked = false;

        private bool bfsButtonIsClicked = false;

        private string filename;

        private ArrayList path;
        public Treasure_Hunt_Solver()
        {
            InitializeComponent();

            // making round rectangle form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            this.Height = 650;
            this.Width = 1200;

            CenterToScreen();
        }

        private void Treasure_Hunt_Solver_Load(object sender, EventArgs e)
        {
            timeStampBox.Enabled = false;
            mazeGridView.Enabled = false;
        }


        private void browseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse Text File",

                CheckFileExists = true,

                CheckPathExists = true,

                DefaultExt = "txt",

                Filter = "txt files (*.txt)|*.txt",

                FilterIndex = 2,

                RestoreDirectory = true,

                ReadOnlyChecked = true,

                ShowReadOnly = true,
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameBox.Text = openFileDialog1.SafeFileName;

                filename = openFileDialog1.FileName;

                Helper.file = filename;

            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < mazeGridView.RowCount; i++)
            {
                for (int j = 0; j < mazeGridView.ColumnCount; j++)
                {
                    if (e.RowIndex == i & e.ColumnIndex == j & e.Value.ToString() == "0")
                    {
                        e.CellStyle.BackColor = Color.Black;
                        e.Value = "";
                    }

                }
            }
            

        }

        // handle filename text box changes
        private void fileNameChange(object sender, EventArgs e)
        {

        }

        private void selectButton_Click(object sender, EventArgs e)
        {

        }

        private void bfsButton_Click(object sender, EventArgs e)
        {
            bfsButton.BackColor = Color.FromArgb(46, 51, 73);

            bfsButtonIsClicked = true;
        }
        private void dfsButton_Click(object sender, EventArgs e)
        {
            dfsButton.BackColor = Color.FromArgb(46, 51, 73);

            dfsButtonIsClicked = true;
        }
        private void tspButton_Click(object sender, EventArgs e)
        {
            tspButton.BackColor = Color.FromArgb(46, 51, 73);
            tspButtonIsClicked = true;
        }
        private void progressButton_Click(object sender, EventArgs e)
        {
            progressButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void visualizeButton_Click(object sender, EventArgs e)
        {
            visualizeButton.BackColor = Color.FromArgb(46, 51, 73);

            mazeGridView.DataSource = Helper.TableDataFromTextFile(filename);

            mazeGridView.ScrollBars = ScrollBars.None;

            mazeGridView.CellFormatting += dataGridView1_CellFormatting;

            mazeGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            int tinggi = mazeGridView.Height / mazeGridView.Rows.Count;

            foreach (DataGridViewRow row in mazeGridView.Rows)
            {
                row.Height = tinggi;
            }
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            solveButton.BackColor = Color.FromArgb(46, 51, 73);

            string[][] map = FileIO.ReadMapFile(fileNameBox.Text.Replace(".txt", ""));

            if (dfsButtonIsClicked)
            {
                DFSState dfs = new DFSState(map, tspButtonIsClicked);

                tspButtonIsClicked = false;

                while (!dfs.stop)
                {
                    dfs.Move();
                }

                path = dfs.GetCurrentPath();

                foreach (Tuple<int, int> tuple in path)
                {
                    mazeGridView.Rows[tuple.Item1].Cells[tuple.Item2].Style.BackColor = Color.YellowGreen;
                }

                dfsButtonIsClicked = false;
            }

            else if (bfsButtonIsClicked)
            {
                BFSState bfs = new BFSState(map, tspButtonIsClicked);

                tspButtonIsClicked = false;

                while (!bfs.stop)
                {
                    bfs.Move();
                }

                path = bfs.GetCurrentPath();

                foreach (Tuple<int, int> tuple in path)
                {
                    mazeGridView.Rows[tuple.Item1].Cells[tuple.Item2].Style.BackColor = Color.YellowGreen;
                }

                bfsButtonIsClicked = false;
            }
        }

        private void selectButton_Hover(object sender, EventArgs e)
        {

        }

        // handle time text changes
        private void timeText_Click(object sender, EventArgs e)
        {

        }

        private void visualize_Click(object sender, EventArgs e)
        {
            
        }

        private void solve_Click(object sender, EventArgs e)
        {

        }
    }
}
