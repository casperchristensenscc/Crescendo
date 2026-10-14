using System;
using System.Windows.Forms;
using NAudio.Wave;
using System.Collections.Generic;
using System.IO;
namespace Crescendo
{
    public partial class Form1 : Form
    {
        private IWavePlayer? outputDevice;
        private AudioFileReader? audioFile;
        private Dictionary<string, string> songPaths = new Dictionary<string, string>(); // for ano shorten ng name ng file
        private Dictionary<string, List<string>> playlists = new Dictionary<string, List<string>>(); // this variable naman is for the playlist
        private string? currentSongName;
        private void playbackTimer_Tick(object sender, EventArgs e)
        {
            if (audioFile == null || audioFile.TotalTime.TotalSeconds <= 0)
            {
                return;
            }

            currentTimeLabel.Text = audioFile.CurrentTime.ToString(@"mm\:ss");
            durationLabel.Text = audioFile.TotalTime.ToString(@"mm\:ss");

            double progress = audioFile.CurrentTime.TotalSeconds / audioFile.TotalTime.TotalSeconds;
            progressFillPanel.Width = (int)(progressBarPanel.Width * progress);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void loadMusicButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Music Files|*.mp3;*.wav;*.flac|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string songName = Path.GetFileNameWithoutExtension(selectedFilePath);

                songPaths[songName] = selectedFilePath;
                songListBox.Items.Add(songName);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            string? selectedSongName = null;

            if (playlistSongsListBox.SelectedItem is string playlistSong)
            {
                selectedSongName = playlistSong;
            }
            else if (songListBox.SelectedItem is string librarySong)
            {
                selectedSongName = librarySong;
            }

            if (selectedSongName == null)
            {
                MessageBox.Show("Please select a song to play.");
                return;
            }

            if (outputDevice == null)
            {
                outputDevice = new WaveOut();
            }

            if (currentSongName != selectedSongName)
            {
                string selectedFilePath = songPaths[selectedSongName];

                outputDevice.Stop();

                audioFile?.Dispose();

                audioFile = new AudioFileReader(selectedFilePath);
                outputDevice.Init(audioFile);

                currentSongName = selectedSongName;

                currentSongLabel.Text = "Now Playing: " + selectedSongName;
                var file = TagLib.File.Create(selectedFilePath);

                artistLabel.Text = "Artist: " + (file.Tag.FirstPerformer ?? "Unknown");
                albumLabel.Text = "Album: " + (file.Tag.Album ?? "Unknown");
            }

            outputDevice.Play();
            playbackTimer.Start();
        }


        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Pause();
                playbackTimer.Stop();
            }
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            if (outputDevice != null && audioFile != null)
            {
                outputDevice.Stop();
                playbackTimer.Stop();
                audioFile.Position = 0;
                currentTimeLabel.Text = "00:00";
                progressFillPanel.Width = 1;
            }
        }

        private void addToPlaylistButton_Click(object sender, EventArgs e)
        {
            if (songListBox.SelectedItem is not string selectedSong)
            {
                MessageBox.Show("Please select a song first.");
                return;
            }

            if (playlistListBox.SelectedItem is not string selectedPlaylist)
            {
                MessageBox.Show("Please select a playlist first.");
                return;
            }

            playlists[selectedPlaylist].Add(selectedSong);

            playlistSongsListBox.Items.Add(selectedSong);
        }

        private void createPlaylistButton_Click(object sender, EventArgs e)
        {
            string playlistName = Microsoft.VisualBasic.Interaction.InputBox(
             "Enter a name for your playlist:",
             "New Playlist",
             "Playlist 1");
            if (!string.IsNullOrWhiteSpace(playlistName))
            {
                playlists.Add(playlistName, new List<string>());
                playlistListBox.Items.Add(playlistName);
            }
        }

        private void playlistListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playlistListBox.SelectedItem is not string selectedPlaylist)
            {
                return;
            }

            songListBox.ClearSelected();

            playlistSongsListBox.Items.Clear();

            foreach (string song in playlists[selectedPlaylist])
            {
                playlistSongsListBox.Items.Add(song);
            }
        }



        private void removeFromPlaylistButton_Click(object sender, EventArgs e)
        {
            // Remove the selected song from a playlist
            if (playlistSongsListBox.SelectedItem is string selectedSong)
            {
                if (playlistListBox.SelectedItem is not string selectedPlaylist)
                {
                    MessageBox.Show("Please select a playlist first.");
                    return;
                }

                playlists[selectedPlaylist].Remove(selectedSong);
                playlistSongsListBox.Items.Remove(selectedSong);

                return;
            }

            // Remove the selected playlist
            if (playlistListBox.SelectedItem is string playlistToRemove)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to remove this playlist?",
                    "Remove Playlist",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    playlists.Remove(playlistToRemove);
                    playlistListBox.Items.Remove(playlistToRemove);
                    playlistSongsListBox.Items.Clear();
                }

                return;
            }


            if (songListBox.SelectedItem is string librarySong)
            {
                DialogResult result = MessageBox.Show(
                    "Remove this song from the library and all playlists? The audio file on your computer will not be deleted.",
                    "Remove Song",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    songListBox.Items.Remove(librarySong);
                    songPaths.Remove(librarySong);

                    foreach (List<string> songs in playlists.Values)
                    {
                        songs.RemoveAll(song => song == librarySong);
                    }

                    playlistSongsListBox.Items.Remove(librarySong);
                }

                return;
            }

            MessageBox.Show("Please select a song or playlist to remove.");
        }

        private void playlistSongsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            songListBox.ClearSelected();
        }

        private void songListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            playlistSongsListBox.ClearSelected();
        }


        private void renamePlaylistButton_Click(object sender, EventArgs e)
        {
            if (playlistListBox.SelectedItem is not string oldName)
            {
                MessageBox.Show("Please select a playlist to rename.");
                return;
            }

            string newName = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the new playlist name:",
                "Rename Playlist",
                oldName);

            if (string.IsNullOrWhiteSpace(newName))
            {
                return;
            }

            newName = newName.Trim();

            if (playlists.ContainsKey(newName))
            {
                MessageBox.Show("A playlist with that name already exists.");
                return;
            }

            List<string> songs = playlists[oldName];

            playlists.Remove(oldName);
            playlists.Add(newName, songs);

            int selectedIndex = playlistListBox.SelectedIndex;

            playlistListBox.Items[selectedIndex] = newName;
            playlistListBox.SelectedIndex = selectedIndex;
        }


        private void shuffleButton_Click(object sender, EventArgs e)
        {
            if (songListBox.Items.Count == 0)
            {
                MessageBox.Show("Please load some songs first.");
                return;
            }

            Random random = new Random();
            int randomIndex = random.Next(songListBox.Items.Count);

            songListBox.SelectedIndex = randomIndex;

            playButton_Click(sender, e);
        }
    }
}
