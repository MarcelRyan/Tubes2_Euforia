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
            mazeGridView = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            configPanel = new Panel();
            tspModePanel = new Panel();
            tspButton = new FontAwesome.Sharp.IconButton();
            visualizeConfigPanel = new Panel();
            timeLabel = new Label();
            timeStampBox = new TextBox();
            progressButton = new FontAwesome.Sharp.IconButton();
            algorithmConfigPanel = new Panel();
            dfsButton = new FontAwesome.Sharp.IconButton();
            bfsButton = new FontAwesome.Sharp.IconButton();
            FileConfigPanel = new Panel();
            browseFileButton = new FontAwesome.Sharp.IconButton();
            fileNameBox = new TextBox();
            fileConfigLabel = new Label();
            visualizeButton = new FontAwesome.Sharp.IconButton();
            solveButton = new FontAwesome.Sharp.IconButton();
            logoPanel = new Panel();
            logoPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)mazeGridView).BeginInit();
            configPanel.SuspendLayout();
            tspModePanel.SuspendLayout();
            visualizeConfigPanel.SuspendLayout();
            algorithmConfigPanel.SuspendLayout();
            FileConfigPanel.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // mazeGridView
            // 
            mazeGridView.AllowUserToAddRows = false;
            mazeGridView.AllowUserToDeleteRows = false;
            mazeGridView.AllowUserToResizeColumns = false;
            mazeGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            mazeGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            mazeGridView.Anchor = AnchorStyles.Top;
            mazeGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mazeGridView.BackgroundColor = Color.FromArgb(37, 42, 64);
            mazeGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            mazeGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            mazeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mazeGridView.ColumnHeadersVisible = false;
            mazeGridView.GridColor = Color.FromArgb(46, 51, 73);
            mazeGridView.Location = new Point(269, 14);
            mazeGridView.Margin = new Padding(4, 5, 4, 5);
            mazeGridView.Name = "mazeGridView";
            mazeGridView.RowHeadersVisible = false;
            mazeGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mazeGridView.RowTemplate.Height = 24;
            mazeGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            mazeGridView.Size = new Size(713, 443);
            mazeGridView.TabIndex = 17;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // configPanel
            // 
            configPanel.BackColor = Color.FromArgb(24, 30, 54);
            configPanel.Controls.Add(tspModePanel);
            configPanel.Controls.Add(visualizeConfigPanel);
            configPanel.Controls.Add(algorithmConfigPanel);
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
            // tspModePanel
            // 
            tspModePanel.Controls.Add(tspButton);
            tspModePanel.Location = new Point(0, 248);
            tspModePanel.Margin = new Padding(0);
            tspModePanel.Name = "tspModePanel";
            tspModePanel.Size = new Size(262, 93);
            tspModePanel.TabIndex = 24;
            // 
            // tspButton
            // 
            tspButton.Dock = DockStyle.Top;
            tspButton.FlatAppearance.BorderSize = 0;
            tspButton.FlatStyle = FlatStyle.Flat;
            tspButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tspButton.ForeColor = Color.FromArgb(163, 55, 245);
            tspButton.IconChar = FontAwesome.Sharp.IconChar.PlaneArrival;
            tspButton.IconColor = Color.FromArgb(163, 55, 245);
            tspButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            tspButton.IconSize = 32;
            tspButton.Location = new Point(0, 0);
            tspButton.Margin = new Padding(3, 3, 0, 0);
            tspButton.Name = "tspButton";
            tspButton.Padding = new Padding(25, 0, 0, 0);
            tspButton.Size = new Size(262, 97);
            tspButton.TabIndex = 3;
            tspButton.Text = "TSP Mode";
            tspButton.TextAlign = ContentAlignment.MiddleLeft;
            tspButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            tspButton.UseVisualStyleBackColor = true;
            tspButton.Click += tspButton_Click;
            // 
            // visualizeConfigPanel
            // 
            visualizeConfigPanel.Controls.Add(timeLabel);
            visualizeConfigPanel.Controls.Add(timeStampBox);
            visualizeConfigPanel.Controls.Add(progressButton);
            visualizeConfigPanel.Dock = DockStyle.Bottom;
            visualizeConfigPanel.Location = new Point(0, 324);
            visualizeConfigPanel.Margin = new Padding(0);
            visualizeConfigPanel.Name = "visualizeConfigPanel";
            visualizeConfigPanel.Size = new Size(262, 120);
            visualizeConfigPanel.TabIndex = 24;
            // 
            // timeLabel
            // 
            timeLabel.FlatStyle = FlatStyle.Flat;
            timeLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.ForeColor = Color.White;
            timeLabel.Location = new Point(182, 69);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(34, 30);
            timeLabel.TabIndex = 7;
            timeLabel.Text = "ms";
            // 
            // timeStampBox
            // 
            timeStampBox.BackColor = Color.FromArgb(24, 30, 54);
            timeStampBox.Location = new Point(55, 69);
            timeStampBox.MaxLength = 3;
            timeStampBox.Name = "timeStampBox";
            timeStampBox.Size = new Size(121, 30);
            timeStampBox.TabIndex = 6;
            // 
            // progressButton
            // 
            progressButton.Dock = DockStyle.Top;
            progressButton.FlatAppearance.BorderSize = 0;
            progressButton.FlatStyle = FlatStyle.Flat;
            progressButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            progressButton.ForeColor = Color.FromArgb(163, 55, 245);
            progressButton.IconChar = FontAwesome.Sharp.IconChar.TasksAlt;
            progressButton.IconColor = Color.FromArgb(163, 55, 245);
            progressButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            progressButton.IconSize = 32;
            progressButton.Location = new Point(0, 0);
            progressButton.Margin = new Padding(0);
            progressButton.Name = "progressButton";
            progressButton.Padding = new Padding(35, 0, 0, 0);
            progressButton.Size = new Size(262, 66);
            progressButton.TabIndex = 5;
            progressButton.Text = "Show Progress";
            progressButton.TextAlign = ContentAlignment.MiddleLeft;
            progressButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            progressButton.UseVisualStyleBackColor = true;
            progressButton.Click += progressButton_Click;
            // 
            // algorithmConfigPanel
            // 
            algorithmConfigPanel.Controls.Add(dfsButton);
            algorithmConfigPanel.Controls.Add(bfsButton);
            algorithmConfigPanel.Location = new Point(0, 180);
            algorithmConfigPanel.Name = "algorithmConfigPanel";
            algorithmConfigPanel.Size = new Size(262, 70);
            algorithmConfigPanel.TabIndex = 23;
            // 
            // dfsButton
            // 
            dfsButton.Dock = DockStyle.Right;
            dfsButton.FlatAppearance.BorderSize = 0;
            dfsButton.FlatStyle = FlatStyle.Flat;
            dfsButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dfsButton.ForeColor = Color.FromArgb(163, 55, 245);
            dfsButton.IconChar = FontAwesome.Sharp.IconChar.RulerVertical;
            dfsButton.IconColor = Color.FromArgb(163, 55, 245);
            dfsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            dfsButton.IconSize = 32;
            dfsButton.Location = new Point(127, 0);
            dfsButton.Margin = new Padding(3, 3, 0, 0);
            dfsButton.Name = "dfsButton";
            dfsButton.Size = new Size(135, 70);
            dfsButton.TabIndex = 4;
            dfsButton.Text = "DFS";
            dfsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            dfsButton.UseVisualStyleBackColor = true;
            dfsButton.Click += dfsButton_Click;
            // 
            // bfsButton
            // 
            bfsButton.Dock = DockStyle.Left;
            bfsButton.FlatAppearance.BorderSize = 0;
            bfsButton.FlatStyle = FlatStyle.Flat;
            bfsButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bfsButton.ForeColor = Color.FromArgb(163, 55, 245);
            bfsButton.IconChar = FontAwesome.Sharp.IconChar.RulerHorizontal;
            bfsButton.IconColor = Color.FromArgb(163, 55, 245);
            bfsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bfsButton.ImageAlign = ContentAlignment.MiddleLeft;
            bfsButton.Location = new Point(0, 0);
            bfsButton.Margin = new Padding(3, 3, 0, 0);
            bfsButton.Name = "bfsButton";
            bfsButton.Size = new Size(135, 70);
            bfsButton.TabIndex = 3;
            bfsButton.Text = "BFS";
            bfsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            bfsButton.UseVisualStyleBackColor = true;
            bfsButton.Click += bfsButton_Click;
            // 
            // FileConfigPanel
            // 
            FileConfigPanel.BackColor = Color.Transparent;
            FileConfigPanel.Controls.Add(browseFileButton);
            FileConfigPanel.Controls.Add(fileNameBox);
            FileConfigPanel.Controls.Add(fileConfigLabel);
            FileConfigPanel.Location = new Point(3, 98);
            FileConfigPanel.Name = "FileConfigPanel";
            FileConfigPanel.Size = new Size(259, 80);
            FileConfigPanel.TabIndex = 22;
            // 
            // browseFileButton
            // 
            browseFileButton.Anchor = AnchorStyles.Right;
            browseFileButton.FlatAppearance.BorderSize = 0;
            browseFileButton.FlatStyle = FlatStyle.Flat;
            browseFileButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            browseFileButton.ForeColor = Color.White;
            browseFileButton.IconChar = FontAwesome.Sharp.IconChar.File;
            browseFileButton.IconColor = Color.White;
            browseFileButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            browseFileButton.IconSize = 28;
            browseFileButton.Location = new Point(208, 30);
            browseFileButton.Name = "browseFileButton";
            browseFileButton.Size = new Size(48, 31);
            browseFileButton.TabIndex = 2;
            browseFileButton.UseVisualStyleBackColor = true;
            browseFileButton.Click += browseFile_Click;
            // 
            // fileNameBox
            // 
            fileNameBox.Anchor = AnchorStyles.Left;
            fileNameBox.BackColor = Color.FromArgb(24, 30, 54);
            fileNameBox.ForeColor = Color.FromArgb(163, 55, 245);
            fileNameBox.Location = new Point(3, 30);
            fileNameBox.Name = "fileNameBox";
            fileNameBox.Size = new Size(199, 30);
            fileNameBox.TabIndex = 1;
            fileNameBox.TextChanged += fileNameChange;
            // 
            // fileConfigLabel
            // 
            fileConfigLabel.Dock = DockStyle.Top;
            fileConfigLabel.FlatStyle = FlatStyle.Flat;
            fileConfigLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fileConfigLabel.ForeColor = Color.FromArgb(163, 55, 245);
            fileConfigLabel.Location = new Point(0, 0);
            fileConfigLabel.Name = "fileConfigLabel";
            fileConfigLabel.Size = new Size(259, 25);
            fileConfigLabel.TabIndex = 0;
            fileConfigLabel.Text = "File Configuration";
            // 
            // visualizeButton
            // 
            visualizeButton.AccessibleName = "visualizeButton";
            visualizeButton.Dock = DockStyle.Bottom;
            visualizeButton.FlatAppearance.BorderSize = 0;
            visualizeButton.FlatStyle = FlatStyle.Flat;
            visualizeButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            visualizeButton.ForeColor = Color.FromArgb(163, 55, 245);
            visualizeButton.IconChar = FontAwesome.Sharp.IconChar.Television;
            visualizeButton.IconColor = Color.FromArgb(163, 55, 245);
            visualizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            visualizeButton.IconSize = 32;
            visualizeButton.ImageAlign = ContentAlignment.MiddleLeft;
            visualizeButton.Location = new Point(0, 444);
            visualizeButton.Name = "visualizeButton";
            visualizeButton.Padding = new Padding(60, 0, 0, 0);
            visualizeButton.Size = new Size(262, 75);
            visualizeButton.TabIndex = 21;
            visualizeButton.Text = "Visualize";
            visualizeButton.TextAlign = ContentAlignment.MiddleLeft;
            visualizeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            visualizeButton.UseVisualStyleBackColor = true;
            visualizeButton.Click += visualizeButton_Click;
            // 
            // solveButton
            // 
            solveButton.AccessibleName = "solveButton";
            solveButton.Dock = DockStyle.Bottom;
            solveButton.FlatAppearance.BorderSize = 0;
            solveButton.FlatStyle = FlatStyle.Flat;
            solveButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            solveButton.ForeColor = Color.FromArgb(163, 55, 245);
            solveButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            solveButton.IconColor = Color.FromArgb(163, 55, 245);
            solveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            solveButton.IconSize = 32;
            solveButton.ImageAlign = ContentAlignment.MiddleLeft;
            solveButton.Location = new Point(0, 519);
            solveButton.Name = "solveButton";
            solveButton.Padding = new Padding(60, 0, 0, 0);
            solveButton.Size = new Size(262, 75);
            solveButton.TabIndex = 20;
            solveButton.Text = "Solve";
            solveButton.TextAlign = ContentAlignment.MiddleLeft;
            solveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            solveButton.UseVisualStyleBackColor = true;
            solveButton.Click += solveButton_Click;
            // 
            // logoPanel
            // 
            logoPanel.Controls.Add(logoPictureBox);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(262, 90);
            logoPanel.TabIndex = 19;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = DockStyle.Fill;
            logoPictureBox.Image = Tubes2_Euforia.Properties.Resources.euforia_logo1;
            logoPictureBox.Location = new Point(0, 0);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(262, 90);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // Treasure_Hunt_Solver
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1178, 594);
            Controls.Add(mazeGridView);
            Controls.Add(configPanel);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(1200, 650);
            MinimizeBox = false;
            MinimumSize = new Size(1200, 650);
            Name = "Treasure_Hunt_Solver";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            Text = "Euforia";
            Load += Treasure_Hunt_Solver_Load;
            ((System.ComponentModel.ISupportInitialize)mazeGridView).EndInit();
            configPanel.ResumeLayout(false);
            tspModePanel.ResumeLayout(false);
            visualizeConfigPanel.ResumeLayout(false);
            visualizeConfigPanel.PerformLayout();
            algorithmConfigPanel.ResumeLayout(false);
            FileConfigPanel.ResumeLayout(false);
            FileConfigPanel.PerformLayout();
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileNameBox;
        private FontAwesome.Sharp.IconButton browseFileButton;
        private System.Windows.Forms.DataGridView mazeGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Panel configPanel;
        private Panel logoPanel;
        private FontAwesome.Sharp.IconButton solveButton;
        private FontAwesome.Sharp.IconButton visualizeButton;
        private Panel FileConfigPanel;
        private Label fileConfigLabel;
        private Panel visualizeConfigPanel;
        private FontAwesome.Sharp.IconButton progressButton;
        private Label timeLabel;
        private TextBox timeStampBox;
        private Panel algorithmConfigPanel;
        private Panel tspModePanel;
        private FontAwesome.Sharp.IconButton tspButton;
        private FontAwesome.Sharp.IconButton bfsButton;
        private FontAwesome.Sharp.IconButton dfsButton;
        private PictureBox logoPictureBox;
    }
}

