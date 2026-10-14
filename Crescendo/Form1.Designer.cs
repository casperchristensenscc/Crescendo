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
            renamePlaylistButton = new Button();
            durationLabel = new Label();
            currentTimeLabel = new Label();
            progressBarPanel = new Panel();
            progressFillPanel = new Panel();
            playbackTimer = new System.Windows.Forms.Timer(components);
            shuffleButton = new Button();
            artistLabel = new Label();
            albumLabel = new Label();
            progressBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // songListBox
            // 
            songListBox.FormattingEnabled = true;
            songListBox.Location = new Point(85, 247);
            songListBox.Name = "songListBox";
            songListBox.Size = new Size(174, 164);
            songListBox.TabIndex = 0;
            songListBox.SelectedIndexChanged += songListBox_SelectedIndexChanged;
            // 
            // playButton
            // 
            playButton.Location = new Point(178, 131);
            playButton.Name = "playButton";
            playButton.Size = new Size(102, 29);
            playButton.TabIndex = 1;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.Location = new Point(286, 131);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(104, 29);
            pauseButton.TabIndex = 1;
            pauseButton.Text = "Pause";
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // stopbutton
            // 
            stopbutton.Location = new Point(396, 131);
            stopbutton.Name = "stopbutton";
            stopbutton.Size = new Size(105, 29);
            stopbutton.TabIndex = 1;
            stopbutton.Text = "Stop";
            stopbutton.UseVisualStyleBackColor = true;
            stopbutton.Click += stopbutton_Click;
            // 
            // loadMusicButton
            // 
            loadMusicButton.Location = new Point(85, 432);
            loadMusicButton.Name = "loadMusicButton";
            loadMusicButton.Size = new Size(174, 29);
            loadMusicButton.TabIndex = 1;
            loadMusicButton.Text = "Load Music";
            loadMusicButton.UseVisualStyleBackColor = true;
            loadMusicButton.Click += loadMusicButton_Click;
            // 
            // currentSongLabel
            // 
            currentSongLabel.AutoSize = true;
            currentSongLabel.Location = new Point(286, 42);
            currentSongLabel.Name = "currentSongLabel";
            currentSongLabel.Size = new Size(135, 20);
            currentSongLabel.TabIndex = 2;
            currentSongLabel.Text = "Now Playing: None";
            // 
            // playlistListBox
            // 
            playlistListBox.FormattingEnabled = true;
            playlistListBox.Location = new Point(299, 247);
            playlistListBox.Name = "playlistListBox";
            playlistListBox.Size = new Size(165, 164);
            playlistListBox.TabIndex = 0;
            playlistListBox.SelectedIndexChanged += playlistListBox_SelectedIndexChanged;
            // 
            // addToPlaylistButton
            // 
            addToPlaylistButton.Location = new Point(499, 432);
            addToPlaylistButton.Name = "addToPlaylistButton";
            addToPlaylistButton.Size = new Size(166, 29);
            addToPlaylistButton.TabIndex = 1;
            addToPlaylistButton.Text = "Add to Playlist";
            addToPlaylistButton.UseVisualStyleBackColor = true;
            addToPlaylistButton.Click += addToPlaylistButton_Click;
            // 
            // createPlaylistButton
            // 
            createPlaylistButton.Location = new Point(299, 432);
            createPlaylistButton.Name = "createPlaylistButton";
            createPlaylistButton.Size = new Size(165, 29);
            createPlaylistButton.TabIndex = 3;
            createPlaylistButton.Text = "New Playlist";
            createPlaylistButton.UseVisualStyleBackColor = true;
            createPlaylistButton.Click += createPlaylistButton_Click;
            // 
            // playlistSongsListBox
            // 
            playlistSongsListBox.FormattingEnabled = true;
            playlistSongsListBox.Location = new Point(499, 247);
            playlistSongsListBox.Name = "playlistSongsListBox";
            playlistSongsListBox.Size = new Size(166, 164);
            playlistSongsListBox.TabIndex = 4;
            playlistSongsListBox.SelectedIndexChanged += playlistSongsListBox_SelectedIndexChanged;
            // 
            // removeFromPlaylistButton
            // 
            removeFromPlaylistButton.Location = new Point(499, 478);
            removeFromPlaylistButton.Name = "removeFromPlaylistButton";
            removeFromPlaylistButton.Size = new Size(166, 29);
            removeFromPlaylistButton.TabIndex = 5;
            removeFromPlaylistButton.Text = "Remove";
            removeFromPlaylistButton.UseVisualStyleBackColor = true;
            removeFromPlaylistButton.Click += removeFromPlaylistButton_Click;
            // 
            // renamePlaylistButton
            // 
            renamePlaylistButton.Location = new Point(299, 478);
            renamePlaylistButton.Name = "renamePlaylistButton";
            renamePlaylistButton.Size = new Size(165, 29);
            renamePlaylistButton.TabIndex = 6;
            renamePlaylistButton.Text = "Rename Playlist";
            renamePlaylistButton.UseVisualStyleBackColor = true;
            renamePlaylistButton.Click += renamePlaylistButton_Click;
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
            progressBarPanel.BackColor = Color.LightGray;
            progressBarPanel.Controls.Add(progressFillPanel);
            progressBarPanel.Controls.Add(durationLabel);
            progressBarPanel.Controls.Add(currentTimeLabel);
            progressBarPanel.Location = new Point(180, 166);
            progressBarPanel.Name = "progressBarPanel";
            progressBarPanel.Size = new Size(400, 40);
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
            shuffleButton.Location = new Point(507, 131);
            shuffleButton.Name = "shuffleButton";
            shuffleButton.Size = new Size(73, 29);
            shuffleButton.TabIndex = 9;
            shuffleButton.Text = "Shuffle";
            shuffleButton.UseVisualStyleBackColor = true;
            shuffleButton.Click += shuffleButton_Click;
            // 
            // artistLabel
            // 
            artistLabel.AutoSize = true;
            artistLabel.Location = new Point(230, 75);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(112, 20);
            artistLabel.TabIndex = 10;
            artistLabel.Text = "Artist: Unknown";
            // 
            // albumLabel
            // 
            albumLabel.AutoSize = true;
            albumLabel.Location = new Point(230, 108);
            albumLabel.Name = "albumLabel";
            albumLabel.Size = new Size(121, 20);
            albumLabel.TabIndex = 10;
            albumLabel.Text = "Album: Unknown";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 581);
            Controls.Add(albumLabel);
            Controls.Add(artistLabel);
            Controls.Add(shuffleButton);
            Controls.Add(progressBarPanel);
            Controls.Add(renamePlaylistButton);
            Controls.Add(removeFromPlaylistButton);
            Controls.Add(playlistSongsListBox);
            Controls.Add(createPlaylistButton);
            Controls.Add(currentSongLabel);
            Controls.Add(addToPlaylistButton);
            Controls.Add(loadMusicButton);
            Controls.Add(stopbutton);
            Controls.Add(pauseButton);
            Controls.Add(playButton);
            Controls.Add(playlistListBox);
            Controls.Add(songListBox);
            Name = "Form1";
            Text = "Crescendo - Music Player";
            progressBarPanel.ResumeLayout(false);
            progressBarPanel.PerformLayout();
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
        private Button renamePlaylistButton;
        private Label durationLabel;
        private Label currentTimeLabel;
        private Panel progressBarPanel;
        private Panel progressFillPanel;
        private System.Windows.Forms.Timer playbackTimer;
        private Button shuffleButton;
        private Label artistLabel;
        private Label albumLabel;
    }
}
