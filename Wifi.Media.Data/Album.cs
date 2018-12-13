using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.Media.Data
{
    [System.Serializable()]
    public class Album
    {
        //**************************************************************************************************
        #region constructors

        public Album()
        {
            this.songs = new List<Song>();
        }

        public Album(string path)
        {
            this.Name = Path.GetFileName(path);
            this.songs = new List<Song>();
            int idx = 0;
            foreach (string file in Directory.EnumerateFiles(path, "*.mp3"))
            {
                this.songs.Add(new Song(file) { TrackNo = ++idx });
            }
        }

        #endregion

        //**************************************************************************************************
        #region Properties

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        private List<Song> songs;
        public List<Song> Songs
        {
            get { return songs; }
            set { songs = value; }
        }

        #endregion

    }
}
