using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WMPLib;
using Wifi.Media.Data;
using Wifi.Media.Medienverwaltung.Song_Detail;

namespace Wifi.Media.Medienverwaltung
{
    public partial class FormMain : Form
    {
        
        private List<Artist> artists = new List<Artist>();

        public FormMain()
        {
            InitializeComponent();
        }
        

        public void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //##############################################################################

            #region Listview


            if (e.Node.Tag is Album)
            {
                Album album = (Album)e.Node.Tag;
                ListViewItem item = null;
                this.listView1.Items.Clear();
                foreach (Song song in album.Songs)
                {
                    item = new ListViewItem();
                    item.Tag = song;
                    item.Text = song.TrackNo.ToString();
                    item.SubItems.Add(song.Name);
                    item.SubItems.Add(song.Duration.ToString(@"hh\:mm"));
                    item.SubItems.Add(song.Language);

                    this.listView1.Items.Add(item);
                    if (this.listView1.Items.Count % 2 == 0) item.BackColor = Color.SteelBlue;
                }
            }
            else
            {
                this.listView1.Items.Clear();
            }

            #endregion

            //##############################################################################
        }

        #region Play / SongDetail
        
        

        private void listView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == '\r')
            //{
            //    Play();
            //}
        }


        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (this.listView1.FocusedItem != null)
            //{
            //    Play();
            //}

            ListViewItem item = this.listView1.GetItemAt(e.X, e.Y);
            FormSongDetail fsd = new FormSongDetail((Song)item.Tag);
            fsd.ShowDialog();
            if (fsd.DialogResult == DialogResult.OK)
            {
                this.listView1.Items.Clear();
            }

        }

        private void Play()
        {
            string wmplayer = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Windows Media Player.lnk";
            string path = $"C:\\Solutions\\Wifi.Media\\Musik\\{this.treeView1.SelectedNode.FullPath}\\{this.listView1.FocusedItem.Text}";
            
            
            Process p = new Process();
            p.StartInfo.FileName = wmplayer;
            p.StartInfo.Arguments = "\"" + path + "\"";
            p.Start();
        }

        #endregion

        //##############################################################################

        #region Menu - Program


        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(dialog.FileName, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Artist>));
                List<Artist> artist = (List<Artist>)serializer.Deserialize(reader);
                reader.Close();
            }
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
           
        }

        private void MenuItemSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML-File|*.xml|All Files|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dialog.FileName, false, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Artist>));
                serializer.Serialize(writer, this.artists);
                writer.Close();

            }
        }

        private void importSongsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = "c:\\Solutions\\Wifi.Media\\Musik";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ReadFileSystem(dialog.SelectedPath);
            }
        }

        #endregion

        //##############################################################################

        #region Readfiles / Treeview


        private void ReadFileSystem(string path)
        {
            Artist artist = null;
            TreeNode artistNode = null;
            TreeNode albumNode = null;


            foreach (string dir in Directory.EnumerateDirectories(path))
            {
                artist = new Artist(dir);
                this.artists.Add(artist);
                artistNode = new TreeNode(artist.Name);
                artistNode.Tag = artist;
                this.treeView1.Nodes.Add(artistNode);

                foreach (Album album in artist.Albums)
                {
                    albumNode = new TreeNode(album.Name);
                    albumNode.Tag = album;
                    artistNode.Nodes.Add(albumNode);
                }

            }


        }


        






        #endregion

        //##############################################################################


        
    }
}
