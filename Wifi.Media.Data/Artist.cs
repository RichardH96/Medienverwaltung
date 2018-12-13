using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.Media.Data
{
    [System.Serializable()]
    public class Artist
    {

        //**************************************************************************************************
        #region constructors
        public Artist()
        {
            this.albums = new List<Album>();
        }

        public Artist(string path)
        {
            this.Name = Path.GetFileName(path);
            this.albums = new List<Album>();
            foreach (string dir in Directory.EnumerateDirectories(path))
            {
                this.albums.Add(new Album(dir));
            }
        }

        #endregion

        //**************************************************************************************************
        #region properties

        public string Name { get; set; }

        public string Country { get; set; }

        private List<Album> albums;

        public List<Album> Albums
        {
            get { return albums; }
            set { albums = value; }
        }

        #endregion
    }
}
