using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wifi.Media.Data;

namespace Wifi.Media.Medienverwaltung.Song_Detail
{
    public partial class FormSongDetail : Form
    {
        List<Song> songs = new List<Song>();
        int songsLeft = 0;
        int idx = 0;

        public FormSongDetail()
        {
            InitializeComponent();
        }
        

        public FormSongDetail(List<Song> songs)
        {
            InitializeComponent();
            this.songs = songs;
            this.songsLeft = this.songs.Count;
            this.buttonSave.Text = "Next";
        }

        private void FormSongDetail_Load(object sender, EventArgs e)
        {

            this.labelSongsleft.Text = $"Songs left: {this.songsLeft}";

            getSongDuration();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBoxDuration.Text = axWindowsMediaPlayer1.currentMedia.durationString;
            this.textBoxSongName.Text = songs[idx].Name;
            this.textBoxAlbumName.Text = songs[idx].AlbumName;
            this.textBoxTracknr.Text = songs[idx].TrackNo.ToString();
            this.textBoxLanguage.Text = "English";
            timer1.Stop();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (this.songsLeft != this.songs.Count)
            {
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.textBoxLanguage.Text != string.Empty && this.textBoxTracknr.Text != string.Empty)
            {
                songs[idx].Duration = TimeSpan.Parse(this.textBoxDuration.Text);
                songs[idx].Language = this.textBoxLanguage.Text;
                songs[idx].TrackNo = Convert.ToInt32(this.textBoxTracknr.Text);
                songs[idx].IsChanged = true;
                idx++;

                int songsLeft2 = songsLeft;
                this.labelSongsleft.Text = $"Songs left: {songsLeft2-1}";

                if (this.songsLeft == 2)
                {
                    this.buttonSave.Text = "Save";
                    getSongDuration();
                }
                else if (this.songsLeft > 2)
                {
                    getSongDuration();

                }
                else if (this.songsLeft == 1) 
                {
                    this.Close();
                }
            }
            
            songsLeft--;
            
        }

        private void getSongDuration()
        {
            axWindowsMediaPlayer1.URL = songs[idx].FilePath;
            axWindowsMediaPlayer1.settings.mute = true;
            timer1.Start();
        }
    }
}
