
namespace FileExplorer1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Folders", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Files", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.filelistView = new System.Windows.Forms.ListView();
            this.file_name_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.readonly_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.temp_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hidden_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.path_txt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonNewFolder = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fswatcher = new System.IO.FileSystemWatcher();
            this.DeleteFiles_timer = new System.Windows.Forms.Timer(this.components);
            this.ClearColor_timer = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fswatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(261, 513);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // filelistView
            // 
            this.filelistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.file_name_col,
            this.date_col,
            this.readonly_col,
            this.temp_col,
            this.hidden_col,
            this.size_col});
            this.filelistView.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "Folders";
            listViewGroup1.Name = "folder_grp";
            listViewGroup2.Header = "Files";
            listViewGroup2.Name = "files_grp";
            this.filelistView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.filelistView.HideSelection = false;
            this.filelistView.Location = new System.Drawing.Point(261, 0);
            this.filelistView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filelistView.Name = "filelistView";
            this.filelistView.Size = new System.Drawing.Size(718, 513);
            this.filelistView.SmallImageList = this.imageList1;
            this.filelistView.StateImageList = this.imageList1;
            this.filelistView.TabIndex = 1;
            this.filelistView.UseCompatibleStateImageBehavior = false;
            this.filelistView.View = System.Windows.Forms.View.Details;
            this.filelistView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.filelistView_MouseDoubleClick);
            // 
            // file_name_col
            // 
            this.file_name_col.Text = "File Name";
            this.file_name_col.Width = 200;
            // 
            // date_col
            // 
            this.date_col.Text = "Date Modified";
            this.date_col.Width = 130;
            // 
            // readonly_col
            // 
            this.readonly_col.Text = "Read Only";
            this.readonly_col.Width = 80;
            // 
            // temp_col
            // 
            this.temp_col.Text = "Temporary";
            this.temp_col.Width = 70;
            // 
            // hidden_col
            // 
            this.hidden_col.Text = "Hidden";
            // 
            // size_col
            // 
            this.size_col.Text = "Size";
            this.size_col.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.filelistView);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 513);
            this.panel1.TabIndex = 2;
            // 
            // path_txt
            // 
            this.path_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.path_txt.Location = new System.Drawing.Point(0, 30);
            this.path_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.path_txt.Name = "path_txt";
            this.path_txt.Size = new System.Drawing.Size(973, 22);
            this.path_txt.TabIndex = 3;
            this.path_txt.Text = "Computer";
            this.path_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.path_txt_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonUp);
            this.panel2.Controls.Add(this.buttonNewFolder);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.path_txt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 58);
            this.panel2.TabIndex = 4;
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(16, 0);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(41, 28);
            this.buttonUp.TabIndex = 8;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonNewFolder
            // 
            this.buttonNewFolder.Location = new System.Drawing.Point(144, 0);
            this.buttonNewFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNewFolder.Name = "buttonNewFolder";
            this.buttonNewFolder.Size = new System.Drawing.Size(100, 28);
            this.buttonNewFolder.TabIndex = 5;
            this.buttonNewFolder.Text = "New Folder";
            this.buttonNewFolder.UseVisualStyleBackColor = true;
            this.buttonNewFolder.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(65, 0);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(71, 28);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 100);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 24);
            this.toolStripMenuItem1.Text = "Text file";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 24);
            this.toolStripMenuItem2.Text = "Rich Text Format file";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(213, 24);
            this.toolStripMenuItem3.Text = "Word Document";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(213, 24);
            this.toolStripMenuItem4.Text = "Custom";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(0, 54);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(972, 12);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            // 
            // fswatcher
            // 
            this.fswatcher.EnableRaisingEvents = true;
            this.fswatcher.SynchronizingObject = this;
            // 
            // DeleteFiles_timer
            // 
            this.DeleteFiles_timer.Interval = 1000;
            this.DeleteFiles_timer.Tick += new System.EventHandler(this.DeleteFiles_timer_Tick);
            // 
            // ClearColor_timer
            // 
            this.ClearColor_timer.Interval = 1000;
            this.ClearColor_timer.Tick += new System.EventHandler(this.ClearColor_timer_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "OneDrive_Folder_Icon.svg.png");
            this.imageList1.Images.SetKeyName(1, "pngtree-document-vector-icon-png-image_3876242.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fswatcher)).EndInit();
            this.ResumeLayout(false);

        }
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>


        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView filelistView;
        private System.Windows.Forms.ColumnHeader file_name_col;
        private System.Windows.Forms.ColumnHeader date_col;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox path_txt;
        private System.Windows.Forms.ColumnHeader hidden_col;
        private System.Windows.Forms.ColumnHeader size_col;
        private System.Windows.Forms.ColumnHeader readonly_col;
        private System.Windows.Forms.ColumnHeader temp_col;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonNewFolder;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.IO.FileSystemWatcher fswatcher;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Timer DeleteFiles_timer;
        private System.Windows.Forms.Timer ClearColor_timer;
        private System.Windows.Forms.ImageList imageList1;
    }
}

