using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace ReduxSDK_Launcher
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        public static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private string basePath = "content\\maps\\";
        private string emptyPath = null;
        public bool dirNotFound = false;

        public MainForm()
        {
            InitializeComponent();

            dirNotFound = !ScanMapsToTree();
            //dirNotFound = false; // TEST
            if (dirNotFound)
            {
                MessageBox.Show("Directory '" + basePath + "' not found.");
            }
        }

        private bool ScanMapsToTree()
        {
            string basePath = Path.Combine(Application.StartupPath, "content", "maps");

            if (!Directory.Exists(basePath))
                return false;

            treeViewMaps.Nodes.Clear();

            var paths = Directory.GetFiles(basePath, "level", SearchOption.AllDirectories)
                .Select(file => Path.GetDirectoryName(file))
                .Select(dir => dir.Substring(basePath.Length).TrimStart('\\'))
                .ToList();

            // сортировка: empty первый
            var sorted = paths
                .OrderBy(x => x.Equals("empty", StringComparison.OrdinalIgnoreCase) ? 0 : 1)
                .ThenBy(x => x, StringComparer.OrdinalIgnoreCase)
                .ToList();

            foreach (var path in sorted)
            {
                AddPathToTree(treeViewMaps, path);
            }

            return true;
        }

        private void AddPathToTree(System.Windows.Forms.TreeView treeView, string path)
        {
            var parts = path.Split('\\');

            TreeNodeCollection nodes = treeView.Nodes;
            TreeNode currentNode = null;

            foreach (var part in parts)
            {
                TreeNode found = null;

                foreach (TreeNode node in nodes)
                {
                    if (node.Text.Equals(part, StringComparison.OrdinalIgnoreCase))
                    {
                        found = node;
                        break;
                    }
                }

                if (found == null)
                {
                    found = new TreeNode(part);
                    nodes.Add(found);
                }

                currentNode = found;
                nodes = found.Nodes;
            }

            currentNode.Tag = path;
        }

        private void onMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void onCloseClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void onMapsAfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = e.Node;

            if(node?.Tag != null) {
                textBoxArgs.Text = "-map " + node.Tag.ToString();
            }
        }

        private void onEditorClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxArgs.Text)) {
                Process.Start("bin_x64\\uengine_m.exe", "-editor " + textBoxArgs.Text);
                Application.Exit();
            } else {
                MessageBox.Show("Level not selected!");
            }
        }

        private void onGameClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxArgs.Text)) {
                Process.Start("bin_x64\\uengine_m.exe", textBoxArgs.Text);
                Application.Exit();
            } else {
                MessageBox.Show("Level not selected!");
            }
        }

        private void onLinkDiscordClick(object sender, MouseEventArgs e)
        {
            Process.Start("https://discord.gg/metromodding");
        }
    }
}
