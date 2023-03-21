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

        private bool dfsMultipleVisits; // true jika dfs diperbolehkan melakukan visit kotak lebih dari 2 kali
        private bool bfsMultipleVisits; // true jika bfs diperbolehkan melakukan visit kotak lebih dari 2 kali

        private bool showProgress; // true jika pilih progress

        private ArrayList path;

        private int time;

        private long execTime;

        private Color selectedButtonForeColor = Color.DodgerBlue;

        private Color defaultButtonForeColor = Color.White;

        private Color selectedButtonBackColor = Color.FromArgb(37, 47, 92);

        private Color defaultButtonBackColor = Color.FromArgb(37, 42, 64);
        public Treasure_Hunt_Solver()
        {
            InitializeComponent();
            logPanel.Hide();

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
            dfsMultipleVisits = false;
            bfsMultipleVisits = false;

            // styling
            progressButton.Dock = DockStyle.Fill;
            timeLabel.Hide();
            timeStampBox.Hide();
            timeStampBox.Enabled = false;
            bfsButton.Dock = DockStyle.Left;
            dfsButton.Dock = DockStyle.Right;
            dfsMultipleVisitsButton.Hide();
        }

        private void Treasure_Hunt_Solver_Load(object sender, EventArgs e)
        {
            timeStampBox.Enabled = false;
        }

        private void refresh_Labels(
            string route = "[ROUTE]",
            string time = "[TIME]",
            string nodes = "[NODES]",
            string steps = "[STEPS]")
        {
            routeLabel.Text = route;

            executionTimeValue.Text = time;

            nodesCountValue.Text = nodes;

            stepsCountValue.Text = steps;

            routeLabel.Refresh();

            executionTimeValue.Refresh();

            nodesCountValue.Refresh();

            stepsCountValue.Refresh();
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

                // WARNING : SET HELPER.ISABSOLUTE HARUS SETELAH SET NILAI FILENAMEBOX.TEXT!!!
                fileNameBox.Text = openFileDialog1.SafeFileName;
                Helper.file = openFileDialog1.FileName;
                Helper.isAbsolute = true;
                refresh_Labels();
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
                btn.Font = new Font(btn.Font, FontStyle.Bold);
            }

            else
            {
                btn.ForeColor = defaultButtonForeColor;
                btn.IconColor = defaultButtonForeColor;
                btn.BackColor = defaultButtonBackColor;
                btn.Font = new Font(btn.Font, FontStyle.Regular);
            }
        }

        // handle filename text box changes
        private void fileNameChange(object sender, EventArgs e)
        {
            Helper.isAbsolute = false;
            Helper.file = fileNameBox.Text;
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

        private void unclickBfsButton(object sender, EventArgs e)
        {
            bfsButton.Dock = DockStyle.Left;

            bfsMultipleVisitsButton.Hide();

            // SET MULTIPLEVISITS MENJADI TRUE UNTUK KEMUDIAN DISET LAGI MENJADI FALSE DI DALAM FUNGSI CHANGEBUTTONVISUAL
            bfsMultipleVisits = true;
            changeButtonVisual(bfsMultipleVisitsButton, ref bfsMultipleVisits);
        }

        private void unclickDfsButton(object sender, EventArgs e)
        {
            dfsButton.Dock = DockStyle.Right;

            dfsMultipleVisitsButton.Hide();

            // SET MULTIPLEVISITS MENJADI TRUE UNTUK KEMUDIAN DISET LAGI MENJADI FALSE DI DALAM FUNGSI CHANGEBUTTONVISUAL
            dfsMultipleVisits = true;
            changeButtonVisual(dfsMultipleVisitsButton, ref dfsMultipleVisits);
        }

        private void bfsButton_Click(object sender, EventArgs e)
        {
            changeButtonVisual(bfsButton, ref bfsMode);

            if (dfsMode && bfsMode)
            {
                changeButtonVisual(dfsButton, ref dfsMode);
            }

            if (bfsMode)
            {
                unclickDfsButton(sender, e);
                bfsButton.Dock = DockStyle.Top;
                bfsMultipleVisitsButton.Show();
                bfsMultipleVisitsButton.Enabled = true;
            }

            else
            {
                unclickBfsButton(sender, e);
            }
        }

        private void dfsButton_Click(object sender, EventArgs e)
        {
            changeButtonVisual(dfsButton, ref dfsMode);

            if (dfsMode && bfsMode)
            {
                changeButtonVisual(bfsButton, ref bfsMode);
            }

            if (dfsMode)
            {
                unclickBfsButton(sender, e);
                dfsButton.Dock = DockStyle.Top;
                dfsMultipleVisitsButton.Show();
                dfsMultipleVisitsButton.Enabled = true;
            }

            else
            {
                unclickDfsButton(sender, e);
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

        private void visualizeMap()
        {
            logPanel.Hide();

            mazeGridView.DataSource = Helper.TableDataFromTextFile();

            mazeGridView.CellFormatting += mazeGrid_CellFormatting;

            mazeGridView.ScrollBars = ScrollBars.None;

            mazeGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            int tinggi = mazeGridView.Height / mazeGridView.Rows.Count;

            foreach (DataGridViewRow row in mazeGridView.Rows)
            {
                row.Height = tinggi;
            }

            mazeGridView.CurrentCell.Style.BackColor = Color.Cyan;
            mazeGridView.CurrentCell.Selected = false;

            refresh_Labels();
        }
        private void visualizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                visualizeMap();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void showError(string msg)
        {
            errorLog.Text = msg;
            logPanel.Show();

        }

        // update grid display based on progress
        private void updateGridDisplay(int i, int j, bool wasYellowGreen, bool wasCrimson)
        {

            if (!wasYellowGreen && !wasCrimson)
            {
                this.mazeGridView.Rows[i].Cells[j].Style.BackColor = Color.YellowGreen;
            }
            else
            {
                this.mazeGridView.Rows[i].Cells[j].Style.BackColor = Color.Crimson;
            }
        }


        // show only solution after progress is finished
        private async Task resetGridDisplay()
        {
            await Task.Delay(200);

            for (int i = 0; i < mazeGridView.Rows.Count; i++)
            {
                for (int j = 0; j < mazeGridView.Columns.Count; j++)
                {
                    if ((mazeGridView.Rows[i].Cells[j].Value == "" || mazeGridView.Rows[i].Cells[j].Value == "Start" || mazeGridView.Rows[i].Cells[j].Value == "Treasure") && (mazeGridView.Rows[i].Cells[j].Style.BackColor == Color.YellowGreen || mazeGridView.Rows[i].Cells[j].Style.BackColor == Color.Red)) ;
                    {
                        mazeGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                }
            }

            foreach (Tuple<int, int> tuple in path)
            {
                mazeGridView.Rows[tuple.Item1].Cells[tuple.Item2].Style.BackColor = Color.YellowGreen;
            }
        }

        private void updateExecutionInfo(MazeState mazeState, string execTime)
        {
            ArrayList route;
  
            route = mazeState.GetCurrentRoute();

            string routeString = "";

            for (int i = 0; i < route.Count; i++)
            {
                routeString += (string)route[i];
                if (i < route.Count - 1) routeString += "-";
            }

            refresh_Labels(
                routeString,
                execTime,
                mazeState.nodeCount.ToString(),
                mazeState.stepCount.ToString());

            logPanel.Hide();
        }

        private async void solveButton_Click(object sender, EventArgs e)
        {
            solveButton.Enabled = false;

            try
            {
                visualizeMap();
                logPanel.Hide();

                path = new ArrayList();

                await resetGridDisplay();

                string[][] map = FileIO.ReadMapFile(Helper.file, Helper.isAbsolute);

                var watch = new Stopwatch();
                MazeState mazeState;

                if (!dfsMode && !bfsMode) throw new Exception("Pick one algorithm to go (BFS/DFS)!");

                // jika dfs
                if (dfsMode) mazeState = new DFSState(map, tspMode, showProgress, dfsMultipleVisits);
                // jika bfs
                else mazeState = new BFSState(map, tspMode, showProgress, bfsMultipleVisits);

                watch.Start();
                this.mazeGridView.CurrentCell.Selected = false;

                if (showProgress)
                {
                    while (!mazeState.stop)
                    {
                        mazeState.Move();

                        bool wasYellowGreen = (this.mazeGridView.Rows[mazeState.position.Item1].Cells[mazeState.position.Item2].Style.BackColor == Color.YellowGreen);
                        bool wasCrimson = this.mazeGridView.Rows[mazeState.position.Item1].Cells[mazeState.position.Item2].Style.BackColor == Color.Crimson;

                        if (dfsMode){
                            this.mazeGridView.Rows[mazeState.position.Item1].Cells[mazeState.position.Item2].Style.BackColor = Color.Cyan;
                            await Task.Delay(time);
                            updateGridDisplay(mazeState.position.Item1, mazeState.position.Item2, wasYellowGreen, wasCrimson);
                        }
                        else
                        {

                            if (bfsMultipleVisits)
                            {
                                this.mazeGridView.Rows[mazeState.position.Item1].Cells[mazeState.position.Item2].Style.BackColor = Color.Cyan;
                                await Task.Delay(time);
                                if (mazeState.treasureFound)
                                {
                                    await resetGridDisplay();
                                    await Task.Delay(time);
                                }
                                updateGridDisplay(mazeState.position.Item1, mazeState.position.Item2, wasYellowGreen, wasCrimson);
                            }
                            else
                            {
                                ArrayList path = mazeState.GetCurrentPath();
                                await resetGridDisplay();
                                foreach (Tuple<int, int> tuple in path)
                                {
                                    this.mazeGridView.Rows[tuple.Item1].Cells[tuple.Item2].Style.BackColor = Color.Cyan;
                                    await Task.Delay(time);
                                    this.mazeGridView.Rows[tuple.Item1].Cells[tuple.Item2].Style.BackColor = Color.YellowGreen;
                                }
                            }
                        }
                    }
                }

                else
                {
                    mazeState.AutoComplete();
                }

                watch.Stop();

                path = mazeState.GetCurrentPath();

                string execTime = watch.ElapsedMilliseconds.ToString() + " ms";

                if (!mazeState.foundAll || (tspMode && !mazeState.position.Equals(mazeState.initialPosition)))
                {
                    Exception noSolutionException = new Exception("Solution is not found!");
                    noSolutionException.Data.Add("time", execTime);
                    throw new Exception("Solution is not found!");
                }

                resetGridDisplay();
                updateExecutionInfo(mazeState, execTime);

            }

            catch (Exception ex)
            {
                showError(ex.Message);

                refresh_Labels((string)ex.Data["time"], "No Solution", "No Solution", "No Solution");

            }
            

            solveButton.Enabled = true;

        }


        // handle time text changes
        private void timeText_Click(object sender, EventArgs e)
        {
            time = Convert.ToInt32(timeStampBox.Text);

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

        private void fileConfigLabel_Click(object sender, EventArgs e)
        {

        }

        private void errorLog_Click(object sender, EventArgs e)
        {

        }

        private void dfsMultipleVisitsButton_Click(object sender, EventArgs e)
        {
            changeButtonVisual(dfsMultipleVisitsButton, ref dfsMultipleVisits);
        }

        private void bfsMultipleVisitsButton_Click(object sender, EventArgs e)
        {
            changeButtonVisual(bfsMultipleVisitsButton, ref bfsMultipleVisits);
        }
    }
}
