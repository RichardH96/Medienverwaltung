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
        public List<Song> allSongs = null;
        private List<Artist> artists = new List<Artist>();
        bool changesSaved = true;
        string savePath = string.Empty;

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

        #region Play 
        
        

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

        #region Menu - Program / SongDetail

        //************************************************

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            if (changesSaved == true)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("unsaved Changes");
            }
            
        }

        //************************************************

        private void MenuItemLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.treeView1.Nodes.Clear();
                savePath = dialog.FileName;
                StreamReader reader = new StreamReader(dialog.FileName, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Artist>));
                List<Artist> artists = (List<Artist>)serializer.Deserialize(reader);
                reader.Close();

                //*********************************************************
                #region Load Treeview

                TreeNode artistNode = null;
                TreeNode albumNode = null;
                foreach (Artist artist in artists) // Load Treeview
                {
                    
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

                #endregion
                //*********************************************************
            }
        }

        //************************************************

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            File.Delete(savePath);
            StreamWriter writer = new StreamWriter(savePath, false, Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Artist>));
            serializer.Serialize(writer, this.artists);
            writer.Close();
            this.changesSaved = true;
        }

        //************************************************

        private void MenuItemSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML-File|*.xml|All Files|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                savePath = dialog.FileName;
                StreamWriter writer = new StreamWriter(dialog.FileName, false, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Artist>));
                serializer.Serialize(writer, this.artists);
                writer.Close();
                this.changesSaved = true;
            }
        }

        //************************************************

        private void importSongsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = "c:\\Solutions\\Wifi.Media\\Musik";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.treeView1.Nodes.Clear();
                ReadFileSystem(dialog.SelectedPath);
            }
            this.changesSaved = false;
        }

        //************************************************

        private void editSongsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Song> unchangedSongs = new List<Song>();

            foreach (TreeNode node in this.treeView1.Nodes)
            {
                foreach(TreeNode subNodes in node.Nodes)
                {
                    if (subNodes.Tag is Album)
                    {
                        Album album = (Album)subNodes.Tag;

                        foreach (Song song in album.Songs)
                        {
                            if (!song.IsChanged)
                            {
                                unchangedSongs.Add(song);
                            }
                        }
                    }
                }

                
            }


            if (unchangedSongs == null)
            {
                MessageBox.Show("No unedited Songs!");
            }
            else
            {
                FormSongDetail fsd = new FormSongDetail(unchangedSongs);
                fsd.Show();
                if (fsd.DialogResult == DialogResult.OK)
                {
                    this.listView1.Items.Clear();
                    this.changesSaved = false;
                }
            }
           
            
        }

        //************************************************

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
