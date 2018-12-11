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
using WMPLib;

namespace Wifi.Media.Medienverwaltung
{
    public partial class FormMain : Form
    {
        List<string> playlist = new List<string>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //##############################################################################

            #region Treeview

            var di = new DirectoryInfo("C:\\Solutions\\Wifi.Media\\Musik");
            foreach (DirectoryInfo artist in di.GetDirectories())
            {
                TreeNode node = this.treeView1.Nodes.Add(artist.Name);

                foreach (DirectoryInfo album in artist.GetDirectories())
                {
                    TreeNode subNode = node.Nodes.Add(album.Name);
                }
            }

            

            #endregion

            //##############################################################################

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //##############################################################################

            #region Listview


            if (e.Node.Parent != null)
            {
                this.listView1.Items.Clear();

                var di = new DirectoryInfo($"C:\\Solutions\\Wifi.Media\\Musik\\{e.Node.FullPath}");
                foreach (FileInfo fi in di.GetFiles())
                {
                    
                    ListViewItem item = new ListViewItem();
                    item.Text = fi.Name;
                    item.ImageIndex = 0;
                    listView1.Items.Add(item); 
                    
                }
            }
            else
            {
                this.listView1.Items.Clear();
            }

            #endregion

            //##############################################################################



            

        }

        private void listView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                Play();
            }
        }


        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            playlist.Add($"C:\\Solutions\\Wifi.Media\\Musik\\{this.treeView1.SelectedNode.FullPath}\\{this.listView1.FocusedItem.Text}");

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.listView1.FocusedItem != null)
            {
                Play();
            }
        }

        private void Play()
        {
            string wmplayer = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Windows Media Player.lnk";
            string path = $"C:\\Solutions\\Wifi.Media\\Musik\\{this.treeView1.SelectedNode.FullPath}\\{this.listView1.FocusedItem.Text}";
            string test = this.treeView1.SelectedNode.FullPath;

            // Process.Start(wmplayer, "\"" + path + "\"");

            //for (int i = 0; i <= 2; i++)
            //{
            //    Process.Start(wmplayer, "\"" + playlist[i] + "\"");
            //}


            Process p = new Process();
            p.StartInfo.FileName = wmplayer;
            //p.StartInfo.Arguments = "\"" + playlist[0] + "\"";
            //p.StartInfo.Arguments = "\"" + playlist[1] + "\"";
            p.StartInfo.Arguments = "\"" + path + "\"";
            p.Start();
        }
    }
}
