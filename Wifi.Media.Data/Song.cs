using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.Media.Data
{
    [System.Serializable()]
    public class Song
    {
        public Song()
        {

        }

        public Song(string file)
        {
            this.FilePath = file;
            this.Name = Path.GetFileName(file);
        }
        //**************************************************************************************************
        #region Properties

        public int TrackNo { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public string Language { get; set; }
        public string FilePath { get; set; }
        #endregion
    }
}
