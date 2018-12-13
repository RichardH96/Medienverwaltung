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
        Song song = null;

        public FormSongDetail()
        {
            InitializeComponent();
        }

        public FormSongDetail(Song song)
        {
            InitializeComponent();
            this.song = song;
        }

        private void FormSongDetail_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = song.FilePath;
            axWindowsMediaPlayer1.settings.mute = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBoxDuration.Text = axWindowsMediaPlayer1.currentMedia.durationString;
            timer1.Stop();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.textBoxLanguage.Text != string.Empty && this.textBoxDuration.Text != string.Empty && this.textBoxTracknr.Text != string.Empty)
            {
                song.Duration = TimeSpan.Parse(this.textBoxDuration.Text);
                song.Language = this.textBoxLanguage.Text;
                song.TrackNo = Convert.ToInt32(this.textBoxTracknr.Text);
              //  this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
