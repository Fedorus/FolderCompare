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

namespace FolderCompare
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                return;
            }
            var stats = new Stats();
            ListFolders(treeView1, folderBrowserDialog1.SelectedPath, stats);
            gb1FilesLabel.Text = stats.Files.ToString();
            gb1FoldersLabel.Text = stats.Folders.ToString();
            if (stats.Size > 1000000)
            {
                gb1FileSizeLabel.Text = $"{(stats.Size / 1024 / 1024 / 1024 / 1024):0.###} TB";
            }
            else
                gb1FileSizeLabel.Text = $"{((stats.Size / 1024 / 1024 / 1024)):0.###} GB";
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                return;
            }
            var stats = new UpdateStats();
            treeView2.Nodes.Clear();

            var res = await Task.Run(() => CompareFolders(textBox1.Text, textBox2.Text, stats));

            treeView2.Nodes.Add(res);

            gb2FilesLabel.Text = stats.CheckedFiles.ToString();
            gb2FoldersLabel.Text = stats.CheckedFolders.ToString();
            gb2FileNotExistLabel.Text = stats.FileNotExist.ToString();
            gb2FolderNotExistLabel.Text = stats.FolderNotExist.ToString();
            gb2FileSizeIssueLabel.Text = stats.FileSizeDifferent.ToString();
        }

        private void ListFolders(TreeView treeView, string path, Stats stats)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo, stats));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo, Stats stats)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
            {
                stats.Folders++;
                directoryNode.Nodes.Add(CreateDirectoryNode(directory, stats));
            }
            foreach (var file in directoryInfo.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name));
                stats.Files++;
                stats.Size += file.Length;
            }
            return directoryNode;
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            mainButton.Enabled = false;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both folders should be selected");
            }
            progressBar1.Maximum = int.Parse(gb2FolderNotExistLabel.Text) + int.Parse(gb2FileNotExistLabel.Text) + int.Parse(gb2FileSizeIssueLabel.Text);

            backgroundWorker1.RunWorkerAsync();
            mainButton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            FixIssues((ExtentedTreeNode)treeView2.Nodes[0]);
            File.WriteAllText("fix.txt", sb.ToString());
        }

        StringBuilder sb = new StringBuilder();
        public void FixIssues(ExtentedTreeNode node)
        {
            if (node == null) { return; }

            switch (node.Status)
            {   
                case FileStatus.Ok:
                    break;
                case FileStatus.DontExist:
                    if (node.IsFolder)
                    {
                        sb.AppendLine($"robocopy \"{node.PathOld}\" \"{node.PathNew}\" /E");
                    }
                    else
                    {
                        sb.AppendLine($"copy \"{node.PathOld}\" \"{node.PathNew}\"");
                    }
                    backgroundWorker1.ReportProgress(1);
                    break;
                case FileStatus.SizeIssue:
                    sb.AppendLine($"copy \"{node.PathOld}\" \"{node.PathNew}\" /Y");
                    backgroundWorker1.ReportProgress(1);
                    break;
                default:
                    break;
            }

            foreach (var item in node.Nodes)
            {
                FixIssues((ExtentedTreeNode)item);
            }
        }


        private ExtentedTreeNode CompareFolders(string basePath, string newPath, UpdateStats stats)
        {
            DirectoryInfo dir = new DirectoryInfo(basePath);
            DirectoryInfo newDir = new DirectoryInfo(newPath);
            var directoryNode = new ExtentedTreeNode(dir.Name, basePath, newPath, true);
            if (!newDir.Exists)
            {
                stats.FolderNotExist++;
                directoryNode.BackColor = Color.Red;
                directoryNode.Status = FileStatus.DontExist;
                return directoryNode;
            }
            else
            {
                stats.CheckedFolders++;
            }
            foreach (var item in dir.GetDirectories())
            {
                directoryNode.Nodes.Add(CompareFolders(basePath+"\\"+item, newPath+"\\"+item.Name, stats));
            }
            var newDirFiles = newDir.GetFiles();
            foreach (var item in dir.GetFiles())
            {
                var info = newDirFiles.FirstOrDefault(x => x.Name == item.Name);
                if (info != null)
                {
                    if (info.Length == item.Length)
                    {
                        stats.CheckedFiles++;
                        directoryNode.Nodes.Add(new ExtentedTreeNode(item.Name, item.FullName, info.FullName, false));
                    }
                    else
                    {
                        stats.FileSizeDifferent++;
                        directoryNode.Nodes.Add(new ExtentedTreeNode(item.Name, item.FullName, info.FullName, false, FileStatus.SizeIssue) { BackColor = Color.Yellow });
                    }
                }
                else
                {
                    stats.FileNotExist++;
                    directoryNode.Nodes.Add(new ExtentedTreeNode(item.Name, item.FullName, newPath+"\\"+item.Name, false, FileStatus.DontExist) { BackColor = Color.Red });
                }
            }
            return directoryNode;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value++;
        }
        static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }
    }

    public class FileComparer : IEqualityComparer<FileInfo>
    {
        public bool Equals(FileInfo x, FileInfo y)
        {
            if(x == y) return true;
            if(x == null || y == null) return false;    
            if(x.Length != y.Length) return false;
            if (x.Name != y.Name) return false;
            return true;
        }

        public int GetHashCode(FileInfo obj)
        {
            throw new NotImplementedException();
        }
    }
    public class ExtentedTreeNode : TreeNode
    {
        public string PathOld { get; set; }
        public string PathNew { get; set; }
        public FileStatus Status { get; set; }

        public bool IsFolder { get; set; } = false;
        public ExtentedTreeNode(string text) : base(text)
        {
            Status = FileStatus.Ok;
        }
        public ExtentedTreeNode(string text, string pathOld, string pathNew, bool isFolder = false, FileStatus status = FileStatus.Ok) :base(text)
        {
            PathOld = pathOld;
            PathNew = pathNew;
            IsFolder = isFolder;
            Status = status;
        }
    }
    public enum FileStatus
    {
        Ok,
        DontExist,
        SizeIssue
    } 

    public class UpdateStats
    {
        public int CheckedFiles { get; set; }
        public int CheckedFolders { get; set; }
        public int FileNotExist { get; set; }
        public int FolderNotExist { get; set; }
        public int FileSizeDifferent { get; set; }
    }
    public class Stats
    { 
        public int Folders { get; set; }
        public int Files { get; set; }
        public decimal Size { get; set; }
    }
}