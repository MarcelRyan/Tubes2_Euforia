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
            panel1 = new Panel();
            tspButton = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            textBox3 = new TextBox();
            visualizeConfigPanel = new Panel();
            timeLabel = new Label();
            timeStampBox = new TextBox();
            progressButton = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBox2 = new TextBox();
            algorithmConfigPanel = new Panel();
            dfsButton = new FontAwesome.Sharp.IconButton();
            bfsButton = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            FileConfigPanel = new Panel();
            browseFileButton = new FontAwesome.Sharp.IconButton();
            fileNameBox = new TextBox();
            fileConfigLabel = new Label();
            visualizeButton = new FontAwesome.Sharp.IconButton();
            solveButton = new FontAwesome.Sharp.IconButton();
            logoPanel = new Panel();
            pictureBox1 = new PictureBox();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            ((System.ComponentModel.ISupportInitialize)mazeGridView).BeginInit();
            configPanel.SuspendLayout();
            panel1.SuspendLayout();
            visualizeConfigPanel.SuspendLayout();
            algorithmConfigPanel.SuspendLayout();
            FileConfigPanel.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            mazeGridView.BackgroundColor = Color.FromArgb(31, 30, 68);
            mazeGridView.BorderStyle = BorderStyle.None;
            mazeGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            mazeGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            mazeGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            mazeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mazeGridView.ColumnHeadersVisible = false;
            mazeGridView.GridColor = Color.White;
            mazeGridView.Location = new Point(291, 14);
            mazeGridView.Margin = new Padding(4, 5, 4, 5);
            mazeGridView.Name = "mazeGridView";
            mazeGridView.RowHeadersVisible = false;
            mazeGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mazeGridView.RowTemplate.Height = 24;
            mazeGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            mazeGridView.Size = new Size(904, 420);
            mazeGridView.TabIndex = 17;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // configPanel
            // 
            configPanel.BackColor = Color.FromArgb(31, 30, 68);
            configPanel.Controls.Add(panel1);
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
            // panel1
            // 
            panel1.Controls.Add(tspButton);
            panel1.Controls.Add(iconButton5);
            panel1.Controls.Add(textBox3);
            panel1.Location = new Point(0, 248);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 69);
            panel1.TabIndex = 24;
            // 
            // tspButton
            // 
            tspButton.Dock = DockStyle.Fill;
            tspButton.FlatAppearance.BorderSize = 0;
            tspButton.FlatStyle = FlatStyle.Flat;
            tspButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tspButton.ForeColor = Color.White;
            tspButton.IconChar = FontAwesome.Sharp.IconChar.PlaneArrival;
            tspButton.IconColor = Color.White;
            tspButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            tspButton.IconSize = 32;
            tspButton.Location = new Point(0, 0);
            tspButton.Margin = new Padding(3, 3, 0, 0);
            tspButton.Name = "tspButton";
            tspButton.Padding = new Padding(25, 0, 0, 0);
            tspButton.Size = new Size(262, 69);
            tspButton.TabIndex = 3;
            tspButton.Text = "TSP Mode";
            tspButton.TextAlign = ContentAlignment.MiddleLeft;
            tspButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            tspButton.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            iconButton5.Anchor = AnchorStyles.Right;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton5.ForeColor = Color.White;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.File;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 28;
            iconButton5.Location = new Point(329, -146);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(48, 31);
            iconButton5.TabIndex = 2;
            iconButton5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.BackColor = Color.FromArgb(31, 30, 68);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(3, -146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 30);
            textBox3.TabIndex = 1;
            // 
            // visualizeConfigPanel
            // 
            visualizeConfigPanel.Controls.Add(timeLabel);
            visualizeConfigPanel.Controls.Add(timeStampBox);
            visualizeConfigPanel.Controls.Add(progressButton);
            visualizeConfigPanel.Controls.Add(iconButton1);
            visualizeConfigPanel.Controls.Add(textBox2);
            visualizeConfigPanel.Dock = DockStyle.Bottom;
            visualizeConfigPanel.Location = new Point(0, 323);
            visualizeConfigPanel.Name = "visualizeConfigPanel";
            visualizeConfigPanel.Size = new Size(262, 117);
            visualizeConfigPanel.TabIndex = 24;
            // 
            // timeLabel
            // 
            timeLabel.FlatStyle = FlatStyle.Flat;
            timeLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.ForeColor = Color.White;
            timeLabel.Location = new Point(182, 56);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(34, 31);
            timeLabel.TabIndex = 7;
            timeLabel.Text = "ms";
            // 
            // timeStampBox
            // 
            timeStampBox.BackColor = Color.FromArgb(31, 30, 68);
            timeStampBox.Location = new Point(55, 56);
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
            progressButton.ForeColor = Color.White;
            progressButton.IconChar = FontAwesome.Sharp.IconChar.TasksAlt;
            progressButton.IconColor = Color.White;
            progressButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            progressButton.IconSize = 32;
            progressButton.Location = new Point(0, 0);
            progressButton.Margin = new Padding(3, 3, 0, 0);
            progressButton.Name = "progressButton";
            progressButton.Padding = new Padding(35, 0, 0, 0);
            progressButton.Size = new Size(262, 50);
            progressButton.TabIndex = 5;
            progressButton.Text = "Show Progress";
            progressButton.TextAlign = ContentAlignment.MiddleLeft;
            progressButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            progressButton.UseVisualStyleBackColor = true;
            progressButton.Click += progressButton_Click;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Right;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.File;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 28;
            iconButton1.Location = new Point(326, -82);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(48, 31);
            iconButton1.TabIndex = 2;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.BackColor = Color.FromArgb(31, 30, 68);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(3, -82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 30);
            textBox2.TabIndex = 1;
            // 
            // algorithmConfigPanel
            // 
            algorithmConfigPanel.Controls.Add(dfsButton);
            algorithmConfigPanel.Controls.Add(bfsButton);
            algorithmConfigPanel.Controls.Add(iconButton2);
            algorithmConfigPanel.Controls.Add(textBox1);
            algorithmConfigPanel.Location = new Point(0, 180);
            algorithmConfigPanel.Name = "algorithmConfigPanel";
            algorithmConfigPanel.Size = new Size(262, 66);
            algorithmConfigPanel.TabIndex = 23;
            // 
            // dfsButton
            // 
            dfsButton.Dock = DockStyle.Right;
            dfsButton.FlatAppearance.BorderSize = 0;
            dfsButton.FlatStyle = FlatStyle.Flat;
            dfsButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dfsButton.ForeColor = Color.White;
            dfsButton.IconChar = FontAwesome.Sharp.IconChar.RulerVertical;
            dfsButton.IconColor = Color.White;
            dfsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            dfsButton.IconSize = 32;
            dfsButton.Location = new Point(127, 0);
            dfsButton.Margin = new Padding(3, 3, 0, 0);
            dfsButton.Name = "dfsButton";
            dfsButton.Size = new Size(135, 66);
            dfsButton.TabIndex = 4;
            dfsButton.Text = "DFS";
            dfsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            dfsButton.UseVisualStyleBackColor = true;
            // 
            // bfsButton
            // 
            bfsButton.Dock = DockStyle.Left;
            bfsButton.FlatAppearance.BorderSize = 0;
            bfsButton.FlatStyle = FlatStyle.Flat;
            bfsButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bfsButton.ForeColor = Color.White;
            bfsButton.IconChar = FontAwesome.Sharp.IconChar.RulerHorizontal;
            bfsButton.IconColor = Color.White;
            bfsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bfsButton.Location = new Point(0, 0);
            bfsButton.Margin = new Padding(3, 3, 0, 0);
            bfsButton.Name = "bfsButton";
            bfsButton.Size = new Size(135, 66);
            bfsButton.TabIndex = 3;
            bfsButton.Text = "BFS";
            bfsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            bfsButton.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Right;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.File;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 28;
            iconButton2.Location = new Point(267, -125);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(48, 31);
            iconButton2.TabIndex = 2;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.BackColor = Color.FromArgb(31, 30, 68);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(3, -125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 30);
            textBox1.TabIndex = 1;
            // 
            // FileConfigPanel
            // 
            FileConfigPanel.BackColor = Color.FromArgb(31, 30, 68);
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
            browseFileButton.FlatAppearance.BorderSize = 0;
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
            fileNameBox.ForeColor = Color.White;
            fileNameBox.Location = new Point(3, 28);
            fileNameBox.Name = "fileNameBox";
            fileNameBox.Size = new Size(199, 30);
            fileNameBox.TabIndex = 1;
            fileNameBox.TextChanged += textBox1_TextChanged;
            // 
            // fileConfigLabel
            // 
            fileConfigLabel.Dock = DockStyle.Top;
            fileConfigLabel.FlatStyle = FlatStyle.Flat;
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
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // Treasure_Hunt_Solver
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(34, 33, 74);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            visualizeConfigPanel.ResumeLayout(false);
            visualizeConfigPanel.PerformLayout();
            algorithmConfigPanel.ResumeLayout(false);
            algorithmConfigPanel.PerformLayout();
            FileConfigPanel.ResumeLayout(false);
            FileConfigPanel.PerformLayout();
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton solveButton;
        private FontAwesome.Sharp.IconButton visualizeButton;
        private Panel FileConfigPanel;
        private Label fileConfigLabel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel visualizeConfigPanel;
        private TextBox textBox2;
        private FontAwesome.Sharp.IconButton progressButton;
        private Label timeLabel;
        private TextBox timeStampBox;
        private Panel algorithmConfigPanel;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TextBox textBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton tspButton;
        private FontAwesome.Sharp.IconButton iconButton5;
        private TextBox textBox3;
        private FontAwesome.Sharp.IconButton bfsButton;
        private FontAwesome.Sharp.IconButton dfsButton;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
    }
}

