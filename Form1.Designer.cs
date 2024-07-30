namespace FolderCompare
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mainButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb1FileSizeLabel = new System.Windows.Forms.Label();
            this.gb1FoldersLabel = new System.Windows.Forms.Label();
            this.gb1FilesLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gb2FileSizeIssueLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gb2FolderNotExistLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb2FileNotExistLabel = new System.Windows.Forms.Label();
            this.gb2FoldersLabel = new System.Windows.Forms.Label();
            this.gb2FilesLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(-1, 189);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(550, 1060);
            this.treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // treeView2
            // 
            this.treeView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView2.ImageIndex = 0;
            this.treeView2.ImageList = this.imageList1;
            this.treeView2.Location = new System.Drawing.Point(789, 189);
            this.treeView2.Name = "treeView2";
            this.treeView2.SelectedImageIndex = 0;
            this.treeView2.Size = new System.Drawing.Size(537, 1057);
            this.treeView2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(550, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(789, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(537, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Select Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(-1, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(550, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(789, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(537, 26);
            this.textBox2.TabIndex = 5;
            // 
            // mainButton
            // 
            this.mainButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mainButton.Location = new System.Drawing.Point(575, 1189);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(192, 47);
            this.mainButton.TabIndex = 6;
            this.mainButton.Text = "Start";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(-1, 1252);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1327, 38);
            this.progressBar1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gb1FileSizeLabel);
            this.groupBox1.Controls.Add(this.gb1FoldersLabel);
            this.groupBox1.Controls.Add(this.gb1FilesLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 96);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original Folder";
            // 
            // gb1FileSizeLabel
            // 
            this.gb1FileSizeLabel.AutoSize = true;
            this.gb1FileSizeLabel.Location = new System.Drawing.Point(399, 66);
            this.gb1FileSizeLabel.Name = "gb1FileSizeLabel";
            this.gb1FileSizeLabel.Size = new System.Drawing.Size(18, 20);
            this.gb1FileSizeLabel.TabIndex = 5;
            this.gb1FileSizeLabel.Text = "0";
            // 
            // gb1FoldersLabel
            // 
            this.gb1FoldersLabel.AutoSize = true;
            this.gb1FoldersLabel.Location = new System.Drawing.Point(213, 66);
            this.gb1FoldersLabel.Name = "gb1FoldersLabel";
            this.gb1FoldersLabel.Size = new System.Drawing.Size(18, 20);
            this.gb1FoldersLabel.TabIndex = 4;
            this.gb1FoldersLabel.Text = "0";
            // 
            // gb1FilesLabel
            // 
            this.gb1FilesLabel.AutoSize = true;
            this.gb1FilesLabel.Location = new System.Drawing.Point(6, 66);
            this.gb1FilesLabel.Name = "gb1FilesLabel";
            this.gb1FilesLabel.Size = new System.Drawing.Size(18, 20);
            this.gb1FilesLabel.TabIndex = 3;
            this.gb1FilesLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Folders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Files";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gb2FileSizeIssueLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.gb2FolderNotExistLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.gb2FileNotExistLabel);
            this.groupBox2.Controls.Add(this.gb2FoldersLabel);
            this.groupBox2.Controls.Add(this.gb2FilesLabel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(789, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 96);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Folder";
            // 
            // gb2FileSizeIssueLabel
            // 
            this.gb2FileSizeIssueLabel.AutoSize = true;
            this.gb2FileSizeIssueLabel.Location = new System.Drawing.Point(364, 66);
            this.gb2FileSizeIssueLabel.Name = "gb2FileSizeIssueLabel";
            this.gb2FileSizeIssueLabel.Size = new System.Drawing.Size(18, 20);
            this.gb2FileSizeIssueLabel.TabIndex = 9;
            this.gb2FileSizeIssueLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "FileSizeIssue";
            // 
            // gb2FolderNotExistLabel
            // 
            this.gb2FolderNotExistLabel.AutoSize = true;
            this.gb2FolderNotExistLabel.Location = new System.Drawing.Point(245, 66);
            this.gb2FolderNotExistLabel.Name = "gb2FolderNotExistLabel";
            this.gb2FolderNotExistLabel.Size = new System.Drawing.Size(18, 20);
            this.gb2FolderNotExistLabel.TabIndex = 7;
            this.gb2FolderNotExistLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "FolderNotExist";
            // 
            // gb2FileNotExistLabel
            // 
            this.gb2FileNotExistLabel.AutoSize = true;
            this.gb2FileNotExistLabel.Location = new System.Drawing.Point(146, 66);
            this.gb2FileNotExistLabel.Name = "gb2FileNotExistLabel";
            this.gb2FileNotExistLabel.Size = new System.Drawing.Size(18, 20);
            this.gb2FileNotExistLabel.TabIndex = 5;
            this.gb2FileNotExistLabel.Text = "0";
            // 
            // gb2FoldersLabel
            // 
            this.gb2FoldersLabel.AutoSize = true;
            this.gb2FoldersLabel.Location = new System.Drawing.Point(78, 66);
            this.gb2FoldersLabel.Name = "gb2FoldersLabel";
            this.gb2FoldersLabel.Size = new System.Drawing.Size(18, 20);
            this.gb2FoldersLabel.TabIndex = 4;
            this.gb2FoldersLabel.Text = "0";
            // 
            // gb2FilesLabel
            // 
            this.gb2FilesLabel.AutoSize = true;
            this.gb2FilesLabel.Location = new System.Drawing.Point(6, 66);
            this.gb2FilesLabel.Name = "gb2FilesLabel";
            this.gb2FilesLabel.Size = new System.Drawing.Size(18, 20);
            this.gb2FilesLabel.TabIndex = 3;
            this.gb2FilesLabel.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(146, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "FileNotExist";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Folders";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Files";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(600, 189);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Create Folders";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(600, 219);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 24);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Fix Files";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(600, 249);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(108, 24);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Copy Files";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 1287);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TreeView treeView1;

        #endregion

        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label gb1FileSizeLabel;
        private System.Windows.Forms.Label gb1FoldersLabel;
        private System.Windows.Forms.Label gb1FilesLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label gb2FileNotExistLabel;
        private System.Windows.Forms.Label gb2FoldersLabel;
        private System.Windows.Forms.Label gb2FilesLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label gb2FileSizeIssueLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label gb2FolderNotExistLabel;
        private System.Windows.Forms.Label label5;
    }
}