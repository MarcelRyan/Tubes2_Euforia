﻿using System.Drawing;
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
            timeStampBox = new NumericUpDown();
            timeLabel = new Label();
            progressButton = new FontAwesome.Sharp.IconButton();
            algorithmConfigPanel = new Panel();
            dfsPanel = new Panel();
            dfsMultipleVisitsButton = new FontAwesome.Sharp.IconButton();
            dfsButton = new FontAwesome.Sharp.IconButton();
            bfsPanel = new Panel();
            bfsMultipleVisitsButton = new FontAwesome.Sharp.IconButton();
            bfsButton = new FontAwesome.Sharp.IconButton();
            FileConfigPanel = new Panel();
            browseFileButton = new FontAwesome.Sharp.IconButton();
            fileNameBox = new TextBox();
            fileConfigLabel = new Label();
            visualizeButton = new FontAwesome.Sharp.IconButton();
            solveButton = new FontAwesome.Sharp.IconButton();
            logoPanel = new Panel();
            logoPictureBox = new PictureBox();
            executionPanel = new Panel();
            stepsCountPanel = new Panel();
            stepsCountValue = new Label();
            stepsCountLabel = new Label();
            nodesCountPanel = new Panel();
            nodesCountValue = new Label();
            stepCountLabel = new Label();
            executionTimePanel = new Panel();
            executionTimeValue = new Label();
            executionTimeLabel = new Label();
            executionButton = new FontAwesome.Sharp.IconButton();
            routePanel = new Panel();
            routeLabel = new Label();
            routeLabelButton = new FontAwesome.Sharp.IconButton();
            logPanel = new Panel();
            errorLog = new Label();
            ((System.ComponentModel.ISupportInitialize)mazeGridView).BeginInit();
            configPanel.SuspendLayout();
            tspModePanel.SuspendLayout();
            visualizeConfigPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timeStampBox).BeginInit();
            algorithmConfigPanel.SuspendLayout();
            dfsPanel.SuspendLayout();
            bfsPanel.SuspendLayout();
            FileConfigPanel.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            executionPanel.SuspendLayout();
            stepsCountPanel.SuspendLayout();
            nodesCountPanel.SuspendLayout();
            executionTimePanel.SuspendLayout();
            routePanel.SuspendLayout();
            logPanel.SuspendLayout();
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
            mazeGridView.BorderStyle = BorderStyle.None;
            mazeGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            mazeGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            mazeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mazeGridView.ColumnHeadersVisible = false;
            mazeGridView.Enabled = false;
            mazeGridView.GridColor = Color.FromArgb(46, 51, 73);
            mazeGridView.Location = new Point(269, 14);
            mazeGridView.Margin = new Padding(4, 5, 4, 5);
            mazeGridView.Name = "mazeGridView";
            mazeGridView.ReadOnly = true;
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
            tspButton.ForeColor = Color.White;
            tspButton.IconChar = FontAwesome.Sharp.IconChar.PlaneArrival;
            tspButton.IconColor = Color.White;
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
            visualizeConfigPanel.Controls.Add(timeStampBox);
            visualizeConfigPanel.Controls.Add(timeLabel);
            visualizeConfigPanel.Controls.Add(progressButton);
            visualizeConfigPanel.Dock = DockStyle.Bottom;
            visualizeConfigPanel.Location = new Point(0, 324);
            visualizeConfigPanel.Margin = new Padding(0);
            visualizeConfigPanel.Name = "visualizeConfigPanel";
            visualizeConfigPanel.Size = new Size(262, 120);
            visualizeConfigPanel.TabIndex = 24;
            // 
            // timeStampBox
            // 
            timeStampBox.BackColor = Color.FromArgb(24, 30, 54);
            timeStampBox.BorderStyle = BorderStyle.FixedSingle;
            timeStampBox.ForeColor = Color.White;
            timeStampBox.Location = new Point(67, 67);
            timeStampBox.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            timeStampBox.Name = "timeStampBox";
            timeStampBox.Size = new Size(109, 30);
            timeStampBox.TabIndex = 8;
            timeStampBox.ValueChanged += timeText_Click;
            timeStampBox.KeyDown += myNumericUpDown_KeyDown;
            timeStampBox.KeyUp += myNumericUpDown_KeyUp;
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
            algorithmConfigPanel.Controls.Add(dfsPanel);
            algorithmConfigPanel.Controls.Add(bfsPanel);
            algorithmConfigPanel.Location = new Point(0, 180);
            algorithmConfigPanel.Name = "algorithmConfigPanel";
            algorithmConfigPanel.Size = new Size(262, 70);
            algorithmConfigPanel.TabIndex = 23;
            // 
            // dfsPanel
            // 
            dfsPanel.Controls.Add(dfsMultipleVisitsButton);
            dfsPanel.Controls.Add(dfsButton);
            dfsPanel.Dock = DockStyle.Left;
            dfsPanel.Location = new Point(133, 0);
            dfsPanel.Name = "dfsPanel";
            dfsPanel.Size = new Size(129, 70);
            dfsPanel.TabIndex = 5;
            // 
            // dfsMultipleVisitsButton
            // 
            dfsMultipleVisitsButton.Dock = DockStyle.Top;
            dfsMultipleVisitsButton.FlatAppearance.BorderSize = 0;
            dfsMultipleVisitsButton.FlatStyle = FlatStyle.Flat;
            dfsMultipleVisitsButton.Font = new Font("Century Gothic", 6F, FontStyle.Regular, GraphicsUnit.Point);
            dfsMultipleVisitsButton.ForeColor = Color.White;
            dfsMultipleVisitsButton.IconChar = FontAwesome.Sharp.IconChar.None;
            dfsMultipleVisitsButton.IconColor = Color.White;
            dfsMultipleVisitsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            dfsMultipleVisitsButton.IconSize = 32;
            dfsMultipleVisitsButton.Location = new Point(0, 42);
            dfsMultipleVisitsButton.Margin = new Padding(3, 3, 0, 0);
            dfsMultipleVisitsButton.Name = "dfsMultipleVisitsButton";
            dfsMultipleVisitsButton.Size = new Size(129, 28);
            dfsMultipleVisitsButton.TabIndex = 5;
            dfsMultipleVisitsButton.Text = "Multiple Visits";
            dfsMultipleVisitsButton.UseVisualStyleBackColor = true;
            dfsMultipleVisitsButton.Click += dfsMultipleVisitsButton_Click;
            // 
            // dfsButton
            // 
            dfsButton.Dock = DockStyle.Top;
            dfsButton.FlatAppearance.BorderSize = 0;
            dfsButton.FlatStyle = FlatStyle.Flat;
            dfsButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dfsButton.ForeColor = Color.White;
            dfsButton.IconChar = FontAwesome.Sharp.IconChar.RulerVertical;
            dfsButton.IconColor = Color.White;
            dfsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            dfsButton.IconSize = 32;
            dfsButton.Location = new Point(0, 0);
            dfsButton.Margin = new Padding(3, 3, 0, 0);
            dfsButton.Name = "dfsButton";
            dfsButton.Size = new Size(129, 42);
            dfsButton.TabIndex = 4;
            dfsButton.Text = "DFS";
            dfsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            dfsButton.UseVisualStyleBackColor = true;
            dfsButton.Click += dfsButton_Click;
            // 
            // bfsPanel
            // 
            bfsPanel.Controls.Add(bfsMultipleVisitsButton);
            bfsPanel.Controls.Add(bfsButton);
            bfsPanel.Dock = DockStyle.Left;
            bfsPanel.Location = new Point(0, 0);
            bfsPanel.Name = "bfsPanel";
            bfsPanel.Size = new Size(133, 70);
            bfsPanel.TabIndex = 6;
            // 
            // bfsMultipleVisitsButton
            // 
            bfsMultipleVisitsButton.Dock = DockStyle.Top;
            bfsMultipleVisitsButton.FlatAppearance.BorderSize = 0;
            bfsMultipleVisitsButton.FlatStyle = FlatStyle.Flat;
            bfsMultipleVisitsButton.Font = new Font("Century Gothic", 6F, FontStyle.Regular, GraphicsUnit.Point);
            bfsMultipleVisitsButton.ForeColor = Color.White;
            bfsMultipleVisitsButton.IconChar = FontAwesome.Sharp.IconChar.None;
            bfsMultipleVisitsButton.IconColor = Color.White;
            bfsMultipleVisitsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bfsMultipleVisitsButton.IconSize = 32;
            bfsMultipleVisitsButton.Location = new Point(0, 42);
            bfsMultipleVisitsButton.Margin = new Padding(3, 3, 0, 0);
            bfsMultipleVisitsButton.Name = "bfsMultipleVisitsButton";
            bfsMultipleVisitsButton.Size = new Size(133, 28);
            bfsMultipleVisitsButton.TabIndex = 5;
            bfsMultipleVisitsButton.Text = "Multiple Visits";
            bfsMultipleVisitsButton.UseVisualStyleBackColor = true;
            bfsMultipleVisitsButton.Click += bfsMultipleVisitsButton_Click;
            // 
            // bfsButton
            // 
            bfsButton.Dock = DockStyle.Top;
            bfsButton.FlatAppearance.BorderSize = 0;
            bfsButton.FlatStyle = FlatStyle.Flat;
            bfsButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bfsButton.ForeColor = Color.White;
            bfsButton.IconChar = FontAwesome.Sharp.IconChar.RulerVertical;
            bfsButton.IconColor = Color.White;
            bfsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bfsButton.IconSize = 32;
            bfsButton.Location = new Point(0, 0);
            bfsButton.Margin = new Padding(3, 3, 0, 0);
            bfsButton.Name = "bfsButton";
            bfsButton.Size = new Size(133, 42);
            bfsButton.TabIndex = 4;
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
            fileNameBox.ForeColor = Color.White;
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
            fileConfigLabel.ForeColor = Color.White;
            fileConfigLabel.Location = new Point(0, 0);
            fileConfigLabel.Name = "fileConfigLabel";
            fileConfigLabel.Size = new Size(259, 25);
            fileConfigLabel.TabIndex = 0;
            fileConfigLabel.Text = "File Configuration";
            fileConfigLabel.Click += fileConfigLabel_Click;
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
            solveButton.ForeColor = Color.White;
            solveButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            solveButton.IconColor = Color.White;
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
            logoPictureBox.Click += logoPictureBox_Click;
            // 
            // executionPanel
            // 
            executionPanel.BackColor = Color.FromArgb(24, 30, 54);
            executionPanel.Controls.Add(stepsCountPanel);
            executionPanel.Controls.Add(nodesCountPanel);
            executionPanel.Controls.Add(executionTimePanel);
            executionPanel.Controls.Add(executionButton);
            executionPanel.Location = new Point(989, 14);
            executionPanel.Name = "executionPanel";
            executionPanel.Size = new Size(184, 443);
            executionPanel.TabIndex = 25;
            // 
            // stepsCountPanel
            // 
            stepsCountPanel.BackColor = Color.FromArgb(46, 51, 73);
            stepsCountPanel.Controls.Add(stepsCountValue);
            stepsCountPanel.Controls.Add(stepsCountLabel);
            stepsCountPanel.Location = new Point(5, 342);
            stepsCountPanel.Name = "stepsCountPanel";
            stepsCountPanel.Size = new Size(174, 88);
            stepsCountPanel.TabIndex = 2;
            // 
            // stepsCountValue
            // 
            stepsCountValue.BackColor = Color.BlueViolet;
            stepsCountValue.Dock = DockStyle.Bottom;
            stepsCountValue.ForeColor = Color.White;
            stepsCountValue.Location = new Point(0, 37);
            stepsCountValue.Name = "stepsCountValue";
            stepsCountValue.Size = new Size(174, 51);
            stepsCountValue.TabIndex = 3;
            stepsCountValue.Text = "[STEPS]";
            stepsCountValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stepsCountLabel
            // 
            stepsCountLabel.Dock = DockStyle.Top;
            stepsCountLabel.ForeColor = Color.White;
            stepsCountLabel.Location = new Point(0, 0);
            stepsCountLabel.Name = "stepsCountLabel";
            stepsCountLabel.Size = new Size(174, 38);
            stepsCountLabel.TabIndex = 1;
            stepsCountLabel.Text = "Steps Count";
            stepsCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nodesCountPanel
            // 
            nodesCountPanel.BackColor = Color.FromArgb(46, 51, 73);
            nodesCountPanel.Controls.Add(nodesCountValue);
            nodesCountPanel.Controls.Add(stepCountLabel);
            nodesCountPanel.Location = new Point(5, 234);
            nodesCountPanel.Name = "nodesCountPanel";
            nodesCountPanel.Size = new Size(174, 88);
            nodesCountPanel.TabIndex = 2;
            // 
            // nodesCountValue
            // 
            nodesCountValue.BackColor = Color.MediumSlateBlue;
            nodesCountValue.Dock = DockStyle.Bottom;
            nodesCountValue.ForeColor = Color.White;
            nodesCountValue.Location = new Point(0, 37);
            nodesCountValue.Name = "nodesCountValue";
            nodesCountValue.Size = new Size(174, 51);
            nodesCountValue.TabIndex = 2;
            nodesCountValue.Text = "[NODES]";
            nodesCountValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stepCountLabel
            // 
            stepCountLabel.Dock = DockStyle.Top;
            stepCountLabel.ForeColor = Color.White;
            stepCountLabel.Location = new Point(0, 0);
            stepCountLabel.Name = "stepCountLabel";
            stepCountLabel.Size = new Size(174, 38);
            stepCountLabel.TabIndex = 0;
            stepCountLabel.Text = "Nodes Count";
            stepCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // executionTimePanel
            // 
            executionTimePanel.BackColor = Color.FromArgb(46, 51, 73);
            executionTimePanel.Controls.Add(executionTimeValue);
            executionTimePanel.Controls.Add(executionTimeLabel);
            executionTimePanel.Location = new Point(5, 129);
            executionTimePanel.Name = "executionTimePanel";
            executionTimePanel.Size = new Size(174, 88);
            executionTimePanel.TabIndex = 1;
            // 
            // executionTimeValue
            // 
            executionTimeValue.BackColor = Color.DodgerBlue;
            executionTimeValue.Dock = DockStyle.Bottom;
            executionTimeValue.ForeColor = Color.White;
            executionTimeValue.Location = new Point(0, 37);
            executionTimeValue.Name = "executionTimeValue";
            executionTimeValue.Size = new Size(174, 51);
            executionTimeValue.TabIndex = 1;
            executionTimeValue.Text = "[TIME]";
            executionTimeValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // executionTimeLabel
            // 
            executionTimeLabel.Dock = DockStyle.Top;
            executionTimeLabel.ForeColor = Color.White;
            executionTimeLabel.ImageAlign = ContentAlignment.MiddleRight;
            executionTimeLabel.Location = new Point(0, 0);
            executionTimeLabel.Name = "executionTimeLabel";
            executionTimeLabel.Size = new Size(174, 38);
            executionTimeLabel.TabIndex = 0;
            executionTimeLabel.Text = "Execution Time";
            executionTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // executionButton
            // 
            executionButton.Dock = DockStyle.Top;
            executionButton.FlatAppearance.BorderColor = Color.SteelBlue;
            executionButton.FlatStyle = FlatStyle.Flat;
            executionButton.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            executionButton.ForeColor = Color.White;
            executionButton.IconChar = FontAwesome.Sharp.IconChar.Microchip;
            executionButton.IconColor = Color.White;
            executionButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            executionButton.IconSize = 50;
            executionButton.Location = new Point(0, 0);
            executionButton.Name = "executionButton";
            executionButton.Size = new Size(184, 109);
            executionButton.TabIndex = 0;
            executionButton.Text = "Execution";
            executionButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            executionButton.UseVisualStyleBackColor = false;
            // 
            // routePanel
            // 
            routePanel.BackColor = Color.FromArgb(24, 30, 54);
            routePanel.Controls.Add(routeLabel);
            routePanel.Controls.Add(routeLabelButton);
            routePanel.Location = new Point(269, 465);
            routePanel.Name = "routePanel";
            routePanel.Size = new Size(904, 129);
            routePanel.TabIndex = 26;
            // 
            // routeLabel
            // 
            routeLabel.Dock = DockStyle.Right;
            routeLabel.FlatStyle = FlatStyle.Flat;
            routeLabel.ForeColor = SystemColors.ControlLight;
            routeLabel.Location = new Point(142, 0);
            routeLabel.Name = "routeLabel";
            routeLabel.Size = new Size(762, 129);
            routeLabel.TabIndex = 1;
            routeLabel.Text = "[ROUTE]";
            routeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // routeLabelButton
            // 
            routeLabelButton.Dock = DockStyle.Left;
            routeLabelButton.FlatAppearance.BorderColor = Color.SteelBlue;
            routeLabelButton.FlatStyle = FlatStyle.Flat;
            routeLabelButton.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            routeLabelButton.ForeColor = Color.White;
            routeLabelButton.IconChar = FontAwesome.Sharp.IconChar.Route;
            routeLabelButton.IconColor = Color.White;
            routeLabelButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            routeLabelButton.IconSize = 70;
            routeLabelButton.Location = new Point(0, 0);
            routeLabelButton.Name = "routeLabelButton";
            routeLabelButton.Size = new Size(136, 129);
            routeLabelButton.TabIndex = 0;
            routeLabelButton.Text = "Route";
            routeLabelButton.TextImageRelation = TextImageRelation.TextAboveImage;
            routeLabelButton.UseVisualStyleBackColor = false;
            // 
            // logPanel
            // 
            logPanel.BackColor = Color.FromArgb(0, 0, 0, 0);
            logPanel.Controls.Add(errorLog);
            logPanel.ForeColor = Color.Transparent;
            logPanel.Location = new Point(281, 28);
            logPanel.Name = "logPanel";
            logPanel.Size = new Size(687, 62);
            logPanel.TabIndex = 27;
            // 
            // errorLog
            // 
            errorLog.BackColor = Color.FromArgb(0, 0, 0, 0);
            errorLog.Dock = DockStyle.Right;
            errorLog.FlatStyle = FlatStyle.Flat;
            errorLog.ForeColor = Color.Red;
            errorLog.Location = new Point(3, 0);
            errorLog.Name = "errorLog";
            errorLog.Size = new Size(684, 62);
            errorLog.TabIndex = 0;
            errorLog.Click += errorLog_Click;
            // 
            // Treasure_Hunt_Solver
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1178, 594);
            Controls.Add(logPanel);
            Controls.Add(routePanel);
            Controls.Add(executionPanel);
            Controls.Add(mazeGridView);
            Controls.Add(configPanel);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(1200, 650);
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
            ((System.ComponentModel.ISupportInitialize)timeStampBox).EndInit();
            algorithmConfigPanel.ResumeLayout(false);
            dfsPanel.ResumeLayout(false);
            bfsPanel.ResumeLayout(false);
            FileConfigPanel.ResumeLayout(false);
            FileConfigPanel.PerformLayout();
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            executionPanel.ResumeLayout(false);
            stepsCountPanel.ResumeLayout(false);
            nodesCountPanel.ResumeLayout(false);
            executionTimePanel.ResumeLayout(false);
            routePanel.ResumeLayout(false);
            logPanel.ResumeLayout(false);
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
        private Panel algorithmConfigPanel;
        private Panel tspModePanel;
        private FontAwesome.Sharp.IconButton tspButton;
        private FontAwesome.Sharp.IconButton dfsButton;
        private PictureBox logoPictureBox;
        private NumericUpDown timeStampBox;
        private Panel executionPanel;
        private FontAwesome.Sharp.IconButton executionButton;
        private Panel stepsCountPanel;
        private Panel nodesCountPanel;
        private Panel executionTimePanel;
        private Label stepsCountValue;
        private Label stepsCountLabel;
        private Label nodesCountValue;
        private Label stepCountLabel;
        private Label executionTimeValue;
        private Label executionTimeLabel;
        private Panel routePanel;
        private FontAwesome.Sharp.IconButton routeLabelButton;
        private Label routeLabel;
        private Panel logPanel;
        private Label errorLog;
        private Panel dfsPanel;
        private FontAwesome.Sharp.IconButton dfsMultipleVisitsButton;
        private Panel bfsPanel;
        private FontAwesome.Sharp.IconButton bfsButton;
        private FontAwesome.Sharp.IconButton bfsMultipleVisitsButton;
    }
}

