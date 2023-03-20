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
using System.Windows.Controls;
using System.Diagnostics;
using System.Net;

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

        private bool bfsMode; // true jika pilih bfs

        private bool dfsMode; // true jika pilih dfs

        private bool tspMode; // true jika pilih tsp

        private bool showProgress; // true jika pilih progress

        private ArrayList path;

        private Stack _stack;

        private Queue _queue;

        private int time;

        private long execTime;

        private Color selectedButtonForeColor = Color.DodgerBlue;

        private Color defaultButtonForeColor = Color.White;

        private Color selectedButtonBackColor = Color.FromArgb(37, 47, 92);

        private Color defaultButtonBackColor = Color.FromArgb(37, 42, 64);
        public Treasure_Hunt_Solver()
        {
            InitializeComponent();

            // handle enter key
            this.fileNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);

            // making round rectangle form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            // set window size
            this.Height = 650;
            this.Width = 1200;

            CenterToScreen();

            // initialize attributes
            bfsMode = false;
            dfsMode = false;
            tspMode = false;
            showProgress = false;

            // styling
            progressButton.Dock = DockStyle.Fill;
            timeLabel.Hide();
            timeStampBox.Hide();
            timeStampBox.Enabled = false;
        }

        private void Treasure_Hunt_Solver_Load(object sender, EventArgs e)
        {
            timeStampBox.Enabled = false;     
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
            }
        }

        private void mazeGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void changeButtonVisual(FontAwesome.Sharp.IconButton btn, ref bool status)
        {
            status = !status;

            if (status)
            {
                btn.ForeColor = selectedButtonForeColor;
                btn.IconColor = selectedButtonForeColor;
                btn.BackColor = selectedButtonBackColor;
                btn.Font = new Font(progressButton.Font, FontStyle.Bold);
            }

            else
            {
                btn.ForeColor = defaultButtonForeColor;
                btn.IconColor = defaultButtonForeColor;
                btn.BackColor = defaultButtonBackColor;
                btn.Font = new Font(progressButton.Font, FontStyle.Regular);
            }
        }

        // handle filename text box changes
        private void fileNameChange(object sender, EventArgs e)
        {
            Helper.file = FileIO.GetTestPath(fileNameBox.Text);
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                exitFocus(sender, e);
                e.Handled = true;
            }
        }

        private void exitFocus(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void bfsButton_Click(object sender, EventArgs e)
        {
            changeButtonVisual(bfsButton, ref bfsMode);

            if (dfsMode && bfsMode)
            {
                changeButtonVisual(dfsButton, ref dfsMode);
            }
        }
        private void dfsButton_Click(object sender, EventArgs e)
        {
            changeButtonVisual(dfsButton, ref dfsMode);

            if (dfsMode && bfsMode)
            {
                changeButtonVisual(bfsButton, ref bfsMode);
            }
        }
        private void tspButton_Click(object sender, EventArgs e)
        {
            changeButtonVisual(tspButton, ref tspMode);

        }
        private void progressButton_Click(object sender, EventArgs e)
        {
            changeButtonVisual(progressButton, ref showProgress);

            if (showProgress)
            {
                progressButton.Dock = DockStyle.Top;
                timeLabel.Show();
                timeStampBox.Show();
                timeStampBox.Enabled = true;
            }

            else
            {
                progressButton.Dock = DockStyle.Fill;
                timeLabel.Hide();
                timeStampBox.Hide();
                timeStampBox.Enabled = false;
            }
        }

        private void visualizeButton_Click(object sender, EventArgs e)
        {
            mazeGridView.DataSource = Helper.TableDataFromTextFile(fileNameBox.Text);

            mazeGridView.CellFormatting += mazeGrid_CellFormatting;

            mazeGridView.ScrollBars = ScrollBars.None;

            mazeGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            int tinggi = mazeGridView.Height / mazeGridView.Rows.Count;

            foreach (DataGridViewRow row in mazeGridView.Rows)
            {
                row.Height = tinggi;
            }
        }

        private async void solveButton_Click(object sender, EventArgs e)
        {

            string[][] map = FileIO.ReadMapFile(fileNameBox.Text.Replace(".txt", ""));

            var watch = new Stopwatch();

            watch.Start();

            if (dfsMode)
            {
                DFSState dfs = new DFSState(map, tspMode);

                if (showProgress)
                {
                    while (!dfs.stop)
                    {
                        await Task.Delay(time);
                        dfs.Move();
                        _stack = dfs.GetStack();
                        Tuple<int, int> pathTuple = new Tuple<int, int>(0, 0);
                        if (_stack.Count > 0)
                        {
                            pathTuple = (Tuple<int, int>)_stack.Pop();
                        }
                        if (pathTuple != null)
                        {
                            if (pathTuple.Item1 >= 0 && pathTuple.Item1 < mazeGridView.RowCount && pathTuple.Item2 >= 0 && pathTuple.Item2 < mazeGridView.ColumnCount)
                            {
                                this.mazeGridView.CurrentCell = this.mazeGridView[pathTuple.Item2, pathTuple.Item1];
                                this.mazeGridView.CurrentCell.Style.BackColor = Color.Blue;
                                mazeGridView.Rows[pathTuple.Item1].Cells[pathTuple.Item2].Style.BackColor = Color.YellowGreen;
                            }
                        }
                    }
                }
                else
                {
                    while (!dfs.stop)
                    {
                        dfs.Move();
                    }
                }

                path = dfs.GetCurrentPath();

                watch.Stop();

                foreach (Tuple<int, int> tuple in path)
                {
                    mazeGridView.Rows[tuple.Item1].Cells[tuple.Item2].Style.BackColor = Color.YellowGreen;
                }

                nodesCountValue.Text = dfs.nodeCount.ToString();

                stepsCountValue.Text = dfs.stepCount.ToString();
            }

            else if (bfsMode)
            {
                BFSState bfs = new BFSState(map, tspMode);

                if (showProgress)
                {
                    while (!bfs.stop)
                    {
                        await Task.Delay(time);
                        bfs.Move();
                        _queue = bfs.GetQueue();
                        Tuple<int, int> pathTuple = new Tuple<int, int>(0, 0);
                        if (_queue.Count > 0)
                        {
                            pathTuple = (Tuple<int, int>)_queue.Dequeue();
                        }
                        if (pathTuple != null)
                        {
                            if (pathTuple.Item1 >= 0 && pathTuple.Item1 < mazeGridView.RowCount && pathTuple.Item2 >= 0 && pathTuple.Item2 < mazeGridView.ColumnCount)
                            {
                                this.mazeGridView.CurrentCell = this.mazeGridView[pathTuple.Item2, pathTuple.Item1];
                                this.mazeGridView.CurrentCell.Style.BackColor = Color.Blue;
                                mazeGridView.Rows[pathTuple.Item1].Cells[pathTuple.Item2].Style.BackColor = Color.YellowGreen;
                            }
                        }
                    }
                }
                else
                {
                    while (!bfs.stop)
                    {
                        bfs.Move();
                    }
                }

                path = bfs.GetCurrentPath();

                watch.Stop();

                foreach (Tuple<int, int> tuple in path)
                {
                    mazeGridView.Rows[tuple.Item1].Cells[tuple.Item2].Style.BackColor = Color.YellowGreen;
                }

                nodesCountValue.Text = bfs.nodeCount.ToString();

                stepsCountValue.Text = bfs.stepCount.ToString();
            }

            execTime = watch.ElapsedMilliseconds;

            executionTimeValue.Text = execTime.ToString() + " ms";

            executionTimeValue.Refresh();

            nodesCountValue.Refresh();

            stepsCountValue.Refresh();
        }

        private void selectButton_Hover(object sender, EventArgs e)
        {

        }

        // handle time text changes
        private void timeText_Click(object sender, EventArgs e)
        {
            Helper.time = timeStampBox.Text;
            time = Convert.ToInt32(Helper.time);
        }

        private void myNumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void myNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                exitFocus(sender, e);
            }
        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void executionGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void executionTimeValue_Click(object sender, EventArgs e)
        {
           
        }

        private void fileConfigLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
