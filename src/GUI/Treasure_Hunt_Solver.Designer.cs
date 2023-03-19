using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class Treasure_Hunt_Solver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label4 = new Label();
            fileNameBox = new TextBox();
            browseFileButton = new Button();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            checkBox1 = new CheckBox();
            timeStampLabel = new Label();
            timeStampBox = new TextBox();
            mazeGridView = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            visualizeButton = new FontAwesome.Sharp.IconButton();
            solveButton = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)mazeGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(408, 469);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 3;
            label4.Text = "Filename";
            // 
            // fileNameBox
            // 
            fileNameBox.BackColor = Color.FromArgb(31, 30, 68);
            fileNameBox.BorderStyle = BorderStyle.FixedSingle;
            fileNameBox.ForeColor = SystemColors.InactiveBorder;
            fileNameBox.Location = new Point(417, 502);
            fileNameBox.Margin = new Padding(6, 5, 4, 5);
            fileNameBox.Name = "fileNameBox";
            fileNameBox.Size = new Size(124, 31);
            fileNameBox.TabIndex = 4;
            fileNameBox.TextChanged += textBox1_TextChanged;
            // 
            // browseFileButton
            // 
            browseFileButton.FlatStyle = FlatStyle.Flat;
            browseFileButton.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            browseFileButton.ForeColor = Color.White;
            browseFileButton.Location = new Point(549, 497);
            browseFileButton.Margin = new Padding(4, 5, 4, 5);
            browseFileButton.Name = "browseFileButton";
            browseFileButton.Size = new Size(94, 36);
            browseFileButton.TabIndex = 5;
            browseFileButton.Text = "Browse";
            browseFileButton.UseVisualStyleBackColor = true;
            browseFileButton.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(398, 556);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 23);
            label5.TabIndex = 6;
            label5.Text = "Algoritma";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(521, 556);
            radioButton1.Margin = new Padding(4, 5, 4, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 27);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "DFS";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(587, 556);
            radioButton2.Margin = new Padding(4, 5, 4, 5);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(66, 27);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "BFS";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(405, 620);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(40, 23);
            label6.TabIndex = 9;
            label6.Text = "TSP";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.ForeColor = Color.White;
            radioButton3.Location = new Point(462, 617);
            radioButton3.Margin = new Padding(4, 5, 4, 5);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(74, 27);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.Text = "True";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.ForeColor = Color.White;
            radioButton4.Location = new Point(541, 617);
            radioButton4.Margin = new Padding(4, 5, 4, 5);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(85, 27);
            radioButton4.TabIndex = 11;
            radioButton4.TabStop = true;
            radioButton4.Text = "False";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(426, 669);
            checkBox1.Margin = new Padding(4, 5, 4, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(176, 27);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Memakai jeda";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // timeStampLabel
            // 
            timeStampLabel.AutoSize = true;
            timeStampLabel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            timeStampLabel.ForeColor = Color.White;
            timeStampLabel.Location = new Point(704, 560);
            timeStampLabel.Margin = new Padding(4, 0, 4, 0);
            timeStampLabel.Name = "timeStampLabel";
            timeStampLabel.Size = new Size(163, 23);
            timeStampLabel.TabIndex = 13;
            timeStampLabel.Text = "input dalam ms";
            timeStampLabel.Click += label7_Click;
            // 
            // timeStampBox
            // 
            timeStampBox.BackColor = Color.FromArgb(31, 30, 68);
            timeStampBox.Location = new Point(919, 552);
            timeStampBox.Margin = new Padding(4, 5, 4, 5);
            timeStampBox.Name = "timeStampBox";
            timeStampBox.Size = new Size(124, 31);
            timeStampBox.TabIndex = 14;
            timeStampBox.TextChanged += textBox2_TextChanged;
            // 
            // mazeGridView
            // 
            mazeGridView.AllowUserToAddRows = false;
            mazeGridView.AllowUserToDeleteRows = false;
            mazeGridView.AllowUserToResizeColumns = false;
            mazeGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            mazeGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            mazeGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mazeGridView.BackgroundColor = Color.FromArgb(31, 30, 68);
            mazeGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            mazeGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            mazeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mazeGridView.ColumnHeadersVisible = false;
            mazeGridView.Location = new Point(309, 18);
            mazeGridView.Margin = new Padding(4, 5, 4, 5);
            mazeGridView.Name = "mazeGridView";
            mazeGridView.RowHeadersVisible = false;
            mazeGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mazeGridView.RowTemplate.Height = 24;
            mazeGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            mazeGridView.Size = new Size(832, 401);
            mazeGridView.TabIndex = 17;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 30, 68);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(visualizeButton);
            panel1.Controls.Add(solveButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 744);
            panel1.TabIndex = 24;
            // 
            // visualizeButton
            // 
            visualizeButton.AccessibleName = "visualizeButton";
            visualizeButton.Dock = DockStyle.Bottom;
            visualizeButton.FlatAppearance.BorderSize = 0;
            visualizeButton.FlatStyle = FlatStyle.Flat;
            visualizeButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            visualizeButton.ForeColor = Color.White;
            visualizeButton.IconChar = FontAwesome.Sharp.IconChar.Television;
            visualizeButton.IconColor = Color.White;
            visualizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            visualizeButton.IconSize = 32;
            visualizeButton.ImageAlign = ContentAlignment.MiddleLeft;
            visualizeButton.Location = new Point(0, 590);
            visualizeButton.Name = "visualizeButton";
            visualizeButton.Padding = new Padding(60, 0, 0, 0);
            visualizeButton.Size = new Size(262, 75);
            visualizeButton.TabIndex = 21;
            visualizeButton.Text = "Visualize";
            visualizeButton.TextAlign = ContentAlignment.MiddleLeft;
            visualizeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            visualizeButton.UseVisualStyleBackColor = true;
            visualizeButton.Click += iconButton2_Click;
            // 
            // solveButton
            // 
            solveButton.AccessibleName = "solveButton";
            solveButton.Dock = DockStyle.Bottom;
            solveButton.FlatAppearance.BorderSize = 0;
            solveButton.FlatStyle = FlatStyle.Flat;
            solveButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            solveButton.ForeColor = Color.White;
            solveButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            solveButton.IconColor = Color.White;
            solveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            solveButton.IconSize = 32;
            solveButton.ImageAlign = ContentAlignment.MiddleLeft;
            solveButton.Location = new Point(0, 665);
            solveButton.Name = "solveButton";
            solveButton.Padding = new Padding(60, 0, 0, 0);
            solveButton.Size = new Size(262, 79);
            solveButton.TabIndex = 20;
            solveButton.Text = "Solve";
            solveButton.TextAlign = ContentAlignment.MiddleLeft;
            solveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            solveButton.UseVisualStyleBackColor = true;
            solveButton.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 92);
            panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Tubes2_Euforia.Properties.Resources.euforia_logo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 76);
            panel3.TabIndex = 22;
            // 
            // Treasure_Hunt_Solver
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1178, 744);
            Controls.Add(mazeGridView);
            Controls.Add(panel1);
            Controls.Add(fileNameBox);
            Controls.Add(timeStampBox);
            Controls.Add(browseFileButton);
            Controls.Add(timeStampLabel);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(radioButton1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton3);
            Controls.Add(label6);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1200, 800);
            MinimumSize = new Size(1200, 800);
            Name = "Treasure_Hunt_Solver";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Euforia";
            Load += Treasure_Hunt_Solver_Load;
            ((System.ComponentModel.ISupportInitialize)mazeGridView).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.Button browseFileButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label timeStampLabel;
        private System.Windows.Forms.TextBox timeStampBox;
        private System.Windows.Forms.DataGridView mazeGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton solveButton;
        private FontAwesome.Sharp.IconButton visualizeButton;
        private Panel panel3;
    }
}

