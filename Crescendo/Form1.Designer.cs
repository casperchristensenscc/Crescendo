namespace Crescendo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            songListBox = new ListBox();
            playButton = new Button();
            pauseButton = new Button();
            stopbutton = new Button();
            loadMusicButton = new Button();
            currentSongLabel = new Label();
            playlistListBox = new ListBox();
            addToPlaylistButton = new Button();
            createPlaylistButton = new Button();
            playlistSongsListBox = new ListBox();
            removeFromPlaylistButton = new Button();
            durationLabel = new Label();
            currentTimeLabel = new Label();
            progressBarPanel = new Panel();
            progressFillPanel = new Panel();
            playbackTimer = new System.Windows.Forms.Timer(components);
            shuffleButton = new Button();
            artistLabel = new Label();
            albumLabel = new Label();
            nextButton = new Button();
            previousButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            renamePlaylistButton = new Button();
            progressBarPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // songListBox
            // 
            songListBox.Dock = DockStyle.Fill;
            songListBox.FormattingEnabled = true;
            songListBox.Location = new Point(3, 3);
            songListBox.Name = "songListBox";
            songListBox.Size = new Size(205, 218);
            songListBox.TabIndex = 0;
            songListBox.SelectedIndexChanged += songListBox_SelectedIndexChanged;
            // 
            // playButton
            // 
            playButton.Anchor = AnchorStyles.Top;
            playButton.FlatAppearance.BorderSize = 0;
            playButton.FlatAppearance.MouseDownBackColor = Color.LightGray;
            playButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            playButton.FlatStyle = FlatStyle.Flat;
            playButton.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playButton.Location = new Point(178, 116);
            playButton.Name = "playButton";
            playButton.Size = new Size(102, 44);
            playButton.TabIndex = 1;
            playButton.Text = "\t▶";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.Anchor = AnchorStyles.Top;
            pauseButton.FlatAppearance.BorderSize = 0;
            pauseButton.FlatAppearance.MouseDownBackColor = Color.LightGray;
            pauseButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            pauseButton.FlatStyle = FlatStyle.Flat;
            pauseButton.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pauseButton.Location = new Point(286, 116);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(104, 44);
            pauseButton.TabIndex = 1;
            pauseButton.Text = "\tⅡ";
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // stopbutton
            // 
            stopbutton.Anchor = AnchorStyles.Top;
            stopbutton.FlatAppearance.BorderSize = 0;
            stopbutton.FlatAppearance.MouseDownBackColor = Color.LightGray;
            stopbutton.FlatAppearance.MouseOverBackColor = Color.Silver;
            stopbutton.FlatStyle = FlatStyle.Flat;
            stopbutton.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stopbutton.Location = new Point(396, 116);
            stopbutton.Name = "stopbutton";
            stopbutton.Size = new Size(105, 44);
            stopbutton.TabIndex = 1;
            stopbutton.Text = "■";
            stopbutton.UseVisualStyleBackColor = true;
            stopbutton.Click += stopbutton_Click;
            // 
            // loadMusicButton
            // 
            loadMusicButton.Dock = DockStyle.Fill;
            loadMusicButton.Location = new Point(3, 227);
            loadMusicButton.Name = "loadMusicButton";
            loadMusicButton.Size = new Size(205, 29);
            loadMusicButton.TabIndex = 1;
            loadMusicButton.Text = "Load Music";
            loadMusicButton.UseVisualStyleBackColor = true;
            loadMusicButton.Click += loadMusicButton_Click;
            // 
            // currentSongLabel
            // 
            currentSongLabel.Anchor = AnchorStyles.Top;
            currentSongLabel.AutoSize = true;
            currentSongLabel.Location = new Point(255, 23);
            currentSongLabel.Name = "currentSongLabel";
            currentSongLabel.Size = new Size(135, 20);
            currentSongLabel.TabIndex = 2;
            currentSongLabel.Text = "Now Playing: None";
            // 
            // playlistListBox
            // 
            playlistListBox.Dock = DockStyle.Fill;
            playlistListBox.FormattingEnabled = true;
            playlistListBox.Location = new Point(214, 3);
            playlistListBox.Name = "playlistListBox";
            playlistListBox.Size = new Size(205, 218);
            playlistListBox.TabIndex = 0;
            playlistListBox.SelectedIndexChanged += playlistListBox_SelectedIndexChanged;
            // 
            // addToPlaylistButton
            // 
            addToPlaylistButton.Dock = DockStyle.Fill;
            addToPlaylistButton.Location = new Point(425, 227);
            addToPlaylistButton.Name = "addToPlaylistButton";
            addToPlaylistButton.Size = new Size(206, 29);
            addToPlaylistButton.TabIndex = 1;
            addToPlaylistButton.Text = "Add to Playlist";
            addToPlaylistButton.UseVisualStyleBackColor = true;
            addToPlaylistButton.Click += addToPlaylistButton_Click;
            // 
            // createPlaylistButton
            // 
            createPlaylistButton.Dock = DockStyle.Fill;
            createPlaylistButton.Location = new Point(214, 227);
            createPlaylistButton.Name = "createPlaylistButton";
            createPlaylistButton.Size = new Size(205, 29);
            createPlaylistButton.TabIndex = 3;
            createPlaylistButton.Text = "New Playlist";
            createPlaylistButton.UseVisualStyleBackColor = true;
            createPlaylistButton.Click += createPlaylistButton_Click;
            // 
            // playlistSongsListBox
            // 
            playlistSongsListBox.Dock = DockStyle.Fill;
            playlistSongsListBox.FormattingEnabled = true;
            playlistSongsListBox.Location = new Point(425, 3);
            playlistSongsListBox.Name = "playlistSongsListBox";
            playlistSongsListBox.Size = new Size(206, 218);
            playlistSongsListBox.TabIndex = 4;
            playlistSongsListBox.SelectedIndexChanged += playlistSongsListBox_SelectedIndexChanged;
            // 
            // removeFromPlaylistButton
            // 
            removeFromPlaylistButton.Dock = DockStyle.Fill;
            removeFromPlaylistButton.Location = new Point(425, 262);
            removeFromPlaylistButton.Name = "removeFromPlaylistButton";
            removeFromPlaylistButton.Size = new Size(206, 29);
            removeFromPlaylistButton.TabIndex = 5;
            removeFromPlaylistButton.Text = "Remove";
            removeFromPlaylistButton.UseVisualStyleBackColor = true;
            removeFromPlaylistButton.Click += removeFromPlaylistButton_Click;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(350, 0);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(44, 20);
            durationLabel.TabIndex = 7;
            durationLabel.Text = "00:00";
            // 
            // currentTimeLabel
            // 
            currentTimeLabel.AutoSize = true;
            currentTimeLabel.Location = new Point(0, 0);
            currentTimeLabel.Name = "currentTimeLabel";
            currentTimeLabel.Size = new Size(44, 20);
            currentTimeLabel.TabIndex = 7;
            currentTimeLabel.Text = "00:00";
            // 
            // progressBarPanel
            // 
            progressBarPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBarPanel.BackColor = Color.LightGray;
            progressBarPanel.Controls.Add(progressFillPanel);
            progressBarPanel.Controls.Add(durationLabel);
            progressBarPanel.Controls.Add(currentTimeLabel);
            progressBarPanel.Location = new Point(178, 166);
            progressBarPanel.Name = "progressBarPanel";
            progressBarPanel.Size = new Size(400, 42);
            progressBarPanel.TabIndex = 8;
            // 
            // progressFillPanel
            // 
            progressFillPanel.BackColor = Color.FromArgb(107, 23, 209);
            progressFillPanel.Location = new Point(0, 25);
            progressFillPanel.Name = "progressFillPanel";
            progressFillPanel.Size = new Size(100, 7);
            progressFillPanel.TabIndex = 9;
            // 
            // playbackTimer
            // 
            playbackTimer.Interval = 500;
            playbackTimer.Tick += playbackTimer_Tick;
            // 
            // shuffleButton
            // 
            shuffleButton.Anchor = AnchorStyles.Top;
            shuffleButton.FlatAppearance.BorderSize = 0;
            shuffleButton.FlatAppearance.MouseDownBackColor = Color.LightGray;
            shuffleButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            shuffleButton.FlatStyle = FlatStyle.Flat;
            shuffleButton.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shuffleButton.Location = new Point(607, 116);
            shuffleButton.Name = "shuffleButton";
            shuffleButton.Size = new Size(73, 44);
            shuffleButton.TabIndex = 9;
            shuffleButton.Text = "⤨";
            shuffleButton.UseVisualStyleBackColor = true;
            shuffleButton.Click += shuffleButton_Click;
            // 
            // artistLabel
            // 
            artistLabel.Anchor = AnchorStyles.Top;
            artistLabel.AutoSize = true;
            artistLabel.Location = new Point(222, 56);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(112, 20);
            artistLabel.TabIndex = 10;
            artistLabel.Text = "Artist: Unknown";
            // 
            // albumLabel
            // 
            albumLabel.Anchor = AnchorStyles.Top;
            albumLabel.AutoSize = true;
            albumLabel.Location = new Point(222, 85);
            albumLabel.Name = "albumLabel";
            albumLabel.Size = new Size(121, 20);
            albumLabel.TabIndex = 10;
            albumLabel.Text = "Album: Unknown";
            // 
            // nextButton
            // 
            nextButton.Anchor = AnchorStyles.Top;
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatAppearance.MouseDownBackColor = Color.LightGray;
            nextButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextButton.Location = new Point(507, 116);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(94, 44);
            nextButton.TabIndex = 11;
            nextButton.Text = "▶|";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // previousButton
            // 
            previousButton.Anchor = AnchorStyles.Top;
            previousButton.FlatAppearance.BorderSize = 0;
            previousButton.FlatAppearance.MouseDownBackColor = Color.LightGray;
            previousButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            previousButton.FlatStyle = FlatStyle.Flat;
            previousButton.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            previousButton.Location = new Point(78, 116);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(94, 44);
            previousButton.TabIndex = 11;
            previousButton.Text = "|◀";
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33351F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33325F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33324F));
            tableLayoutPanel1.Controls.Add(renamePlaylistButton, 0, 2);
            tableLayoutPanel1.Controls.Add(songListBox, 0, 0);
            tableLayoutPanel1.Controls.Add(playlistListBox, 1, 0);
            tableLayoutPanel1.Controls.Add(playlistSongsListBox, 2, 0);
            tableLayoutPanel1.Controls.Add(loadMusicButton, 0, 1);
            tableLayoutPanel1.Controls.Add(createPlaylistButton, 1, 1);
            tableLayoutPanel1.Controls.Add(addToPlaylistButton, 2, 1);
            tableLayoutPanel1.Controls.Add(removeFromPlaylistButton, 2, 2);
            tableLayoutPanel1.Location = new Point(46, 250);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(634, 294);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // renamePlaylistButton
            // 
            tableLayoutPanel1.SetColumnSpan(renamePlaylistButton, 2);
            renamePlaylistButton.Dock = DockStyle.Fill;
            renamePlaylistButton.Location = new Point(3, 262);
            renamePlaylistButton.Name = "renamePlaylistButton";
            renamePlaylistButton.Size = new Size(416, 29);
            renamePlaylistButton.TabIndex = 7;
            renamePlaylistButton.Text = "Rename Playlist";
            renamePlaylistButton.UseVisualStyleBackColor = true;
            renamePlaylistButton.Click += renamePlaylistButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 581);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(previousButton);
            Controls.Add(nextButton);
            Controls.Add(albumLabel);
            Controls.Add(artistLabel);
            Controls.Add(shuffleButton);
            Controls.Add(progressBarPanel);
            Controls.Add(currentSongLabel);
            Controls.Add(stopbutton);
            Controls.Add(pauseButton);
            Controls.Add(playButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(776, 628);
            Name = "Form1";
            Text = "Crescendo - Music Player";
            progressBarPanel.ResumeLayout(false);
            progressBarPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox songListBox;
        private Button playButton;
        private Button pauseButton;
        private Button stopbutton;
        private Button loadMusicButton;
        private Label currentSongLabel;
        private ListBox playlistListBox;
        private Button addToPlaylistButton;
        private Button createPlaylistButton;
        private ListBox playlistSongsListBox;
        private Button removeFromPlaylistButton;
        private Label durationLabel;
        private Label currentTimeLabel;
        private Panel progressBarPanel;
        private Panel progressFillPanel;
        private System.Windows.Forms.Timer playbackTimer;
        private Button shuffleButton;
        private Label artistLabel;
        private Label albumLabel;
        private Button nextButton;
        private Button previousButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Button renamePlaylistButton;
    }
}
