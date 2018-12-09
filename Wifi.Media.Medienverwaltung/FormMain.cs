using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            
            foreach (string artist in Directory.EnumerateDirectories(@"C:\Solutions\Wifi.Media\Musik")) 
            {
                string artistName = artist.Substring(artist.LastIndexOf('\\')+1);
                TreeNode node = this.treeView1.Nodes.Add(artistName);

                foreach (string album in Directory.EnumerateDirectories(artist))
                {
                    string albumName = album.Substring(album.LastIndexOf('\\')+1);
                    TreeNode subNode = node.Nodes.Add(albumName);
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
                    string ext = fi.Extension;
                    if (!imageList1.Images.Keys.Contains(ext))
                    {
                        imageList1.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                    }
                    int index = imageList1.Images.Keys.IndexOf(ext);
                    ListViewItem item = new ListViewItem();
                    item.Text = fi.Name;
                    item.ImageIndex = index;
                    listView1.Items.Add(item);
                }
            }

            #endregion

            //##############################################################################

        }
    }
}
