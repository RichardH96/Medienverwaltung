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
                string wmplayer = "wmplayer.exe";
                string path = @"C:\Solutions\Wifi.Media\Musik\Slipknot\Album 1\Before I Forget.mp3";
                if (1 == 1) ;
                
                Process.Start(wmplayer, path);
            }
        }
    }
}
