using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Treasure_Hunt_Solver : Form
    {
        public Treasure_Hunt_Solver()
        {
            InitializeComponent();

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
                fileNameBox.Text = openFileDialog1.FileName;
                Helper.file = fileNameBox.Text;
                mazeGridView.DataSource = Helper.TableDataFromTextFile(fileNameBox.Text);
                fileNameBox.Text = openFileDialog1.SafeFileName;
                mazeGridView.CellFormatting += dataGridView1_CellFormatting;
                mazeGridView.ScrollBars = ScrollBars.None;
                mazeGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                int tinggi = mazeGridView.Height / mazeGridView.Rows.Count;
                foreach (DataGridViewRow row in mazeGridView.Rows)
                {
                    row.Height = tinggi;
                }
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
                    }

                }
            }
        }

        // handle filename text box changes
        private void fileNameChange(object sender, EventArgs e)
        {

        }

        // handle visual changes when button is clicked
        private void selectButton_Click(object sender, EventArgs e)
        {

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
