﻿using System;
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

        private bool bfsMode; // true jika pilih bfs

        private bool dfsMode; // true jika pilih dfs

        private bool tspMode;

        private bool showProgress;

        private string filename;

        private ArrayList path;

        private Color selectedButtonForeColor = Color.FromArgb(99, 55, 245);

        private Color defaultButtonForeColor = Color.FromArgb(163, 55, 245);

        private Color selectedButtonBackColor = Color.FromArgb(37, 47, 92);

        private Color defaultButtonBackColor = Color.FromArgb(24, 30, 54);
        public Treasure_Hunt_Solver()
        {
            InitializeComponent();
            this.fileNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);

            // making round rectangle form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            this.Height = 650;
            this.Width = 1200;

            CenterToScreen();

            bfsMode = false;
            dfsMode = false;
            tspMode = false;
            showProgress = false;

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
            mazeGridView.DataSource = Helper.TableDataFromTextFile(filename);

            mazeGridView.CellFormatting += dataGridView1_CellFormatting;

            mazeGridView.ScrollBars = ScrollBars.None;

            mazeGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            int tinggi = mazeGridView.Height / mazeGridView.Rows.Count;

            foreach (DataGridViewRow row in mazeGridView.Rows)
            {
                row.Height = tinggi;
            }
        }

        private void solveButton_Click(object sender, EventArgs e)
        {

            string[][] map = FileIO.ReadMapFile(fileNameBox.Text.Replace(".txt", ""));

            if (dfsMode)
            {
                DFSState dfs = new DFSState(map, tspMode);

                while (!dfs.stop)
                {
                    dfs.Move();
                }

                path = dfs.GetCurrentPath();

                foreach (Tuple<int, int> tuple in path)
                {
                    mazeGridView.Rows[tuple.Item1].Cells[tuple.Item2].Style.BackColor = Color.YellowGreen;
                }
            }

            else if (bfsMode)
            {
                BFSState bfs = new BFSState(map, tspMode);

                while (!bfs.stop)
                {
                    bfs.Move();
                }

                path = bfs.GetCurrentPath();

                foreach (Tuple<int, int> tuple in path)
                {
                    mazeGridView.Rows[tuple.Item1].Cells[tuple.Item2].Style.BackColor = Color.YellowGreen;
                }
            }
        }

        private void selectButton_Hover(object sender, EventArgs e)
        {

        }

        // handle time text changes
        private void timeText_Click(object sender, EventArgs e)
        {
            Helper.time = timeStampBox.Text;
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
    }
}
