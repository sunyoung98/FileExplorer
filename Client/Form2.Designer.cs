namespace HWC
{
    partial class Form2
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.colFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFilesize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFilemodify = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.상세정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다운로드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.trvDir = new System.Windows.Forms.TreeView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.onserverbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwFiles
            // 
            this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFilename,
            this.colFilesize,
            this.colFilemodify});
            this.lvwFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.lvwFiles.LargeImageList = this.imageList1;
            this.lvwFiles.Location = new System.Drawing.Point(173, 115);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(401, 341);
            this.lvwFiles.SmallImageList = this.imageList1;
            this.lvwFiles.TabIndex = 26;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.DoubleClick += new System.EventHandler(this.lvwFiles_DoubleClick);
            // 
            // colFilename
            // 
            this.colFilename.Text = "파일이름";
            // 
            // colFilesize
            // 
            this.colFilesize.Text = "파일크기";
            // 
            // colFilemodify
            // 
            this.colFilemodify.Text = "수정날짜";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상세정보ToolStripMenuItem,
            this.다운로드ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mnuDetail,
            this.mnuList,
            this.mnuSmall,
            this.mnuLarge});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 154);
            // 
            // 상세정보ToolStripMenuItem
            // 
            this.상세정보ToolStripMenuItem.Name = "상세정보ToolStripMenuItem";
            this.상세정보ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.상세정보ToolStripMenuItem.Text = "상세정보";
            this.상세정보ToolStripMenuItem.Click += new System.EventHandler(this.상세정보ToolStripMenuItem_Click);
            // 
            // 다운로드ToolStripMenuItem
            // 
            this.다운로드ToolStripMenuItem.Name = "다운로드ToolStripMenuItem";
            this.다운로드ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.다운로드ToolStripMenuItem.Text = "다운로드";
            this.다운로드ToolStripMenuItem.Click += new System.EventHandler(this.다운로드ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // mnuDetail
            // 
            this.mnuDetail.Name = "mnuDetail";
            this.mnuDetail.Size = new System.Drawing.Size(153, 24);
            this.mnuDetail.Text = "자세히";
            this.mnuDetail.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuList
            // 
            this.mnuList.Name = "mnuList";
            this.mnuList.Size = new System.Drawing.Size(153, 24);
            this.mnuList.Text = "간단히";
            this.mnuList.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuSmall
            // 
            this.mnuSmall.Name = "mnuSmall";
            this.mnuSmall.Size = new System.Drawing.Size(153, 24);
            this.mnuSmall.Text = "작은아이콘";
            this.mnuSmall.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuLarge
            // 
            this.mnuLarge.Name = "mnuLarge";
            this.mnuLarge.Size = new System.Drawing.Size(153, 24);
            this.mnuLarge.Text = "큰아이콘";
            this.mnuLarge.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "avi.png");
            this.imageList1.Images.SetKeyName(2, "image.png");
            this.imageList1.Images.SetKeyName(3, "music.png");
            this.imageList1.Images.SetKeyName(4, "text.png");
            this.imageList1.Images.SetKeyName(5, "temp.png");
            // 
            // trvDir
            // 
            this.trvDir.ImageIndex = 0;
            this.trvDir.ImageList = this.imageList1;
            this.trvDir.Location = new System.Drawing.Point(-1, 115);
            this.trvDir.Name = "trvDir";
            this.trvDir.SelectedImageIndex = 0;
            this.trvDir.Size = new System.Drawing.Size(177, 341);
            this.trvDir.TabIndex = 25;
            this.trvDir.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvDir_BeforeExpand);
            this.trvDir.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvDir_BeforeSelect);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "폴더열기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "경로설정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // onserverbtn
            // 
            this.onserverbtn.Location = new System.Drawing.Point(67, 86);
            this.onserverbtn.Name = "onserverbtn";
            this.onserverbtn.Size = new System.Drawing.Size(75, 23);
            this.onserverbtn.TabIndex = 22;
            this.onserverbtn.Text = "서버연결";
            this.onserverbtn.UseVisualStyleBackColor = true;
            this.onserverbtn.Click += new System.EventHandler(this.onserverbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "PORT:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(408, 25);
            this.textBox3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "다운로드 경로:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "IP:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(439, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 25);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 25);
            this.textBox1.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 455);
            this.Controls.Add(this.lvwFiles);
            this.Controls.Add(this.trvDir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.onserverbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Client";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwFiles;
        private System.Windows.Forms.ColumnHeader colFilename;
        private System.Windows.Forms.ColumnHeader colFilesize;
        private System.Windows.Forms.ColumnHeader colFilemodify;
        private System.Windows.Forms.TreeView trvDir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button onserverbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 상세정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다운로드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuDetail;
        private System.Windows.Forms.ToolStripMenuItem mnuList;
        private System.Windows.Forms.ToolStripMenuItem mnuSmall;
        private System.Windows.Forms.ToolStripMenuItem mnuLarge;
    }
}

