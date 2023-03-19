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
            configPanel = new Panel();
            FileConfigPanel = new Panel();
            browseFileButton = new FontAwesome.Sharp.IconButton();
            fileNameBox = new TextBox();
            fileConfigLabel = new Label();
            visualizeButton = new FontAwesome.Sharp.IconButton();
            solveButton = new FontAwesome.Sharp.IconButton();
            logoPanel = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)mazeGridView).BeginInit();
            configPanel.SuspendLayout();
            FileConfigPanel.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(447, 250);
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
            radioButton1.Location = new Point(570, 250);
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
            radioButton2.Location = new Point(636, 250);
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
            label6.Location = new Point(454, 314);
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
            radioButton3.Location = new Point(511, 311);
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
            radioButton4.Location = new Point(590, 311);
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
            checkBox1.Location = new Point(475, 363);
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
            timeStampLabel.Location = new Point(753, 254);
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
            timeStampBox.Location = new Point(968, 246);
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
            mazeGridView.Size = new Size(832, 218);
            mazeGridView.TabIndex = 17;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // configPanel
            // 
            configPanel.BackColor = Color.FromArgb(31, 30, 68);
            configPanel.Controls.Add(FileConfigPanel);
            configPanel.Controls.Add(visualizeButton);
            configPanel.Controls.Add(solveButton);
            configPanel.Controls.Add(logoPanel);
            configPanel.Dock = DockStyle.Left;
            configPanel.Location = new Point(0, 0);
            configPanel.Name = "configPanel";
            configPanel.Size = new Size(262, 594);
            configPanel.TabIndex = 24;
            // 
            // FileConfigPanel
            // 
            FileConfigPanel.Controls.Add(browseFileButton);
            FileConfigPanel.Controls.Add(fileNameBox);
            FileConfigPanel.Controls.Add(fileConfigLabel);
            FileConfigPanel.Location = new Point(3, 98);
            FileConfigPanel.Name = "FileConfigPanel";
            FileConfigPanel.Size = new Size(259, 76);
            FileConfigPanel.TabIndex = 22;
            // 
            // browseFileButton
            // 
            browseFileButton.Anchor = AnchorStyles.Right;
            browseFileButton.FlatStyle = FlatStyle.Flat;
            browseFileButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            browseFileButton.ForeColor = Color.White;
            browseFileButton.IconChar = FontAwesome.Sharp.IconChar.File;
            browseFileButton.IconColor = Color.White;
            browseFileButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            browseFileButton.IconSize = 28;
            browseFileButton.Location = new Point(208, 28);
            browseFileButton.Name = "browseFileButton";
            browseFileButton.Size = new Size(48, 31);
            browseFileButton.TabIndex = 2;
            browseFileButton.UseVisualStyleBackColor = true;
            browseFileButton.Click += button1_Click;
            // 
            // fileNameBox
            // 
            fileNameBox.Anchor = AnchorStyles.Left;
            fileNameBox.BackColor = Color.FromArgb(31, 30, 68);
            fileNameBox.Location = new Point(3, 28);
            fileNameBox.Name = "fileNameBox";
            fileNameBox.Size = new Size(199, 31);
            fileNameBox.TabIndex = 1;
            fileNameBox.TextChanged += textBox1_TextChanged;
            // 
            // fileConfigLabel
            // 
            fileConfigLabel.Dock = DockStyle.Top;
            fileConfigLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fileConfigLabel.ForeColor = Color.White;
            fileConfigLabel.Location = new Point(0, 0);
            fileConfigLabel.Name = "fileConfigLabel";
            fileConfigLabel.Size = new Size(259, 25);
            fileConfigLabel.TabIndex = 0;
            fileConfigLabel.Text = "File Configuration";
            fileConfigLabel.Click += label1_Click;
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
            visualizeButton.Location = new Point(0, 440);
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
            solveButton.Location = new Point(0, 515);
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
            // logoPanel
            // 
            logoPanel.Controls.Add(pictureBox1);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(262, 92);
            logoPanel.TabIndex = 19;
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
            // Treasure_Hunt_Solver
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1178, 594);
            Controls.Add(mazeGridView);
            Controls.Add(configPanel);
            Controls.Add(timeStampBox);
            Controls.Add(timeStampLabel);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(radioButton1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton3);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1200, 650);
            MinimumSize = new Size(1200, 650);
            Name = "Treasure_Hunt_Solver";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Euforia";
            Load += Treasure_Hunt_Solver_Load;
            ((System.ComponentModel.ISupportInitialize)mazeGridView).EndInit();
            configPanel.ResumeLayout(false);
            FileConfigPanel.ResumeLayout(false);
            FileConfigPanel.PerformLayout();
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileNameBox;
        private FontAwesome.Sharp.IconButton browseFileButton;
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
        private Panel configPanel;
        private Panel logoPanel;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton solveButton;
        private FontAwesome.Sharp.IconButton visualizeButton;
        private Panel FileConfigPanel;
        private Label fileConfigLabel;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

