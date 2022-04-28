using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace FileExplorer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Directory.GetLogicalDrives())
            {
                treeView1.Nodes.Add(item[0] + ":");
                treeView1.Nodes[treeView1.Nodes.Count - 1].Nodes.Add("*");
                filelistView.Items.Add(item[0] + ":");
                filelistView.Items[filelistView.Items.Count - 1].Group = filelistView.Groups[0];
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            List<string> files = new List<string>();
            string path = e.Node.FullPath + "\\";
            e.Node.Nodes.Clear();
            treeView1.SelectedNode = e.Node;
            try
            {
                if (Directory.Exists(path))
                {
                    files.AddRange(Directory.EnumerateDirectories(path));
                    string[] buff = null;
                    for (int i = 0; i < files.Count; i++)
                    {
                        buff = files[i].Split('\\');
                        e.Node.Nodes.Add(buff[buff.Length - 1]);
                        e.Node.Nodes[e.Node.Nodes.Count - 1].Nodes.Add("*");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не получается получить файлы из заданной директивы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            OpenFileFolder(e.Node.FullPath);
        }
        private void ExpandTreeViewPath(TreeNode node, List<string> path)
        {
            path.RemoveAt(0);
            node.Expand();
            if (path.Count == 0 || string.IsNullOrWhiteSpace(path[0]))
            {
                treeView1.SelectedNode = node;
                return;
            }
            foreach (TreeNode mynode in node.Nodes)
                if (mynode.Text == path[0])
                    ExpandTreeViewPath(mynode, path); 
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            filelistView.Items.Clear();
            string path = "";
            try
            {
                path = e.Node.FullPath;
                if (Directory.Exists(path + "\\"))
                {
                    UpdateFileFolerListView(path);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не получается открыть запрашиваемый файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void path_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string path = path_txt.Text;
                filelistView.Items.Clear();
                try
                {
                    if (Directory.Exists(path))
                    {
                        UpdateTreeView(path);
                        UpdateFileFolerListView(path);
                    }
                    else if (File.Exists(path))
                        System.Diagnostics.Process.Start(path);
                }
                catch (Exception)
                {
                    MessageBox.Show("Невозможно октрыть заданный путь файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void filelistView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string path;
            if (path_txt.Text == "Computer")
                path = treeView1.SelectedNode.FullPath.Substring(0, 2);
            else
                path = $"{treeView1.SelectedNode.FullPath}\\{filelistView.SelectedItems[0].SubItems[0].Text}";
            if (File.Exists(path))
                OpenFileFolder(path);
            else if (Directory.Exists($"{path}\\"))
            {
                UpdateFileFolerListView(path);
                UpdateTreeView($"{path}\\");
            }
        }
        /// <summary>
        /// </summary>
        /// <param name="path">Path to directory</param>
        private void UpdateFileFolerListView(string path)
        {
            ClearColor_timer.Stop();
            DeleteFiles_timer.Stop();
            if (!path.EndsWith("\\"))
                path += "\\";
            path_txt.Text = path;
            FileAttributes atrib;
            string[] buff;
            ListViewItem lvi;
            filelistView.Items.Clear();
            //Files
            try
            {
                foreach (string item in Directory.EnumerateFiles(path))
                {
                    buff = item.Split('\\');
                    lvi = new ListViewItem(buff[buff.Length - 1]);
                    try
                    {
                        lvi.SubItems.Add(File.GetLastAccessTime(item).ToString());
                        atrib = File.GetAttributes(item);
                        lvi.SubItems.Add(atrib.HasFlag(FileAttributes.ReadOnly).ToString());
                        lvi.SubItems.Add(atrib.HasFlag(FileAttributes.Temporary).ToString());
                        lvi.SubItems.Add(atrib.HasFlag(FileAttributes.Hidden).ToString());
                        lvi.SubItems.Add(((new FileInfo(item)).Length / 1000.0).ToString() + " KB");
                        lvi.BackColor = Color.White;
                    }
                    catch (Exception)
                    {
                        lvi.Text = "!#Error";
                    }
                    filelistView.Items.Add(lvi);
                    filelistView.Items[filelistView.Items.Count - 1].Group = filelistView.Groups[1];
                }
                DirectoryInfo dirinfo;
                //Folders
                foreach (string item in Directory.EnumerateDirectories(path))
                {
                    buff = item.Split('\\');
                    lvi = new ListViewItem(buff[buff.Length - 1]);
                    try
                    {
                        lvi.SubItems.Add(Directory.GetLastAccessTime(item).ToString());
                        dirinfo = new DirectoryInfo(item);
                        lvi.SubItems.Add(dirinfo.Attributes.HasFlag(FileAttributes.ReadOnly).ToString());
                        lvi.SubItems.Add(dirinfo.Attributes.HasFlag(FileAttributes.Temporary).ToString());
                        lvi.SubItems.Add(dirinfo.Attributes.HasFlag(FileAttributes.Hidden).ToString());
                        lvi.BackColor = Color.White;
                    }
                    catch (Exception)
                    {
                        lvi.Text = "!#Error";
                    }
                    filelistView.Items.Add(lvi);
                    filelistView.Items[filelistView.Items.Count - 1].Group = filelistView.Groups[0];
                }
                fswatcher.Dispose();
                fswatcher = new FileSystemWatcher(path)
                {
                    NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.LastAccess | NotifyFilters.DirectoryName | NotifyFilters.Attributes | NotifyFilters.Size,
                    Filter = "*.*",
                    EnableRaisingEvents = true
                };
                fswatcher.Created += Fswatcher_DoUpdate;
                fswatcher.Deleted += Fswatcher_DoUpdate;
                fswatcher.Renamed += Fswatcher_DoUpdate;
                fswatcher.Changed += Fswatcher_DoUpdate;
            }
            catch (Exception)
            {
                fswatcher.Dispose();
                MessageBox.Show("Не получается выполнить операцию", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Fswatcher_DoUpdate(object sender, FileSystemEventArgs e)
        {
            BeginInvoke(new Action(() => fsChanged(e)));
        }

        private void fsChanged(FileSystemEventArgs e)
        {

            if (e.ChangeType == WatcherChangeTypes.Deleted)
            {
                DeleteFiles_timer.Stop();
                foreach (ListViewItem item in filelistView.Items)
                    if (item.Text == e.Name)
                        item.BackColor = Color.Red;
                DeleteFiles_timer.Start();
                return;
            }
            ClearColor_timer.Stop();
            if (e.ChangeType == WatcherChangeTypes.Created || e.ChangeType == WatcherChangeTypes.Renamed)
                UpdateFileFolerListView(path_txt.Text);
            foreach (ListViewItem item in filelistView.Items)
                if (item.Text == e.Name && item.BackColor == Color.White)
                {
                    if (e.ChangeType == WatcherChangeTypes.Created)
                        item.BackColor = Color.LightGreen;
                    else if (e.ChangeType == WatcherChangeTypes.Changed)
                        item.BackColor = Color.Yellow;
                    else if (e.ChangeType == WatcherChangeTypes.Renamed)
                        item.BackColor = Color.Yellow;
                }
            ClearColor_timer.Start();
        }
        /// <summary>
        /// </summary>
        /// <param name="path"></param>
        private void UpdateTreeView(string path)
        {
            if (!path.EndsWith("\\"))
                path += "\\";
            var path_list = path.Split('\\').ToList();
            foreach (TreeNode node in treeView1.Nodes)
                if (node.Text == path_list[0])
                    ExpandTreeViewPath(node, path_list);
        }
        /// <summary>
 

        private void OpenFileFolder(string path)
        {
            try
            {
                if (Directory.Exists(path + "\\"))
                    System.Diagnostics.Process.Start(path + "\\");
                else
                    System.Diagnostics.Process.Start(path);
            }
            catch (Exception)
            {
                MessageBox.Show("Не получается удалить выбранный объект", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void path_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string ext = "";
            switch (e.ClickedItem.Text)
            {
                case "Text file":
                    ext = "txt";
                    break;
                case "Rich Text Format file":
                    ext = "rtf";
                    break;
                case "Word Document":
                    ext = "docx";
                    break;
                case "Custom":
                    ext = null;
                    break;
                default:
                    return;
            }
            var dialog = new NewFileDialog(ext, path_txt.Text);
            dialog.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (filelistView.SelectedItems.Count < 1)
                return;
            string path;
            foreach (ListViewItem item in filelistView.SelectedItems)
            {
                path = path_txt.Text + item.SubItems[0].Text;
                if (Directory.Exists(path))
                {
                    try
                    {
                        Directory.Delete(path);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Не получается удалить эту папку: {item.SubItems[0].Text}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (File.Exists(path))
                {
                    try
                    {
                        File.Delete(path);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Не получается удалить эту папку: {item.SubItems[0].Text}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            var dialog = new NewFileDialog("\\", path_txt.Text);
            dialog.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // cd ..
            try
            {
                string path = $"{treeView1.SelectedNode.Parent.FullPath}\\";
                UpdateFileFolerListView(path);
                treeView1.SelectedNode.Collapse();
                treeView1.SelectedNode = treeView1.SelectedNode.Parent;
            }
            catch { }
        }

        private void DeleteFiles_timer_Tick(object sender, EventArgs e)
        {

            foreach (ListViewItem item in filelistView.Items)
                if (item.BackColor == Color.Red)
                    filelistView.Items.Remove(item);
        }

        private void ClearColor_timer_Tick(object sender, EventArgs e)
        {

            foreach (ListViewItem item in filelistView.Items)
                if (item.BackColor == Color.LightGreen || item.BackColor == Color.Yellow)
                    item.BackColor = Color.White;
        }
        
    }
}
