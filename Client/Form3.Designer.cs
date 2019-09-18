namespace HWC
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.location = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.make = new System.Windows.Forms.Label();
            this.modify = new System.Windows.Forms.Label();
            this.access = new System.Windows.Forms.Label();
            this.kind = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PB = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(159, 203);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(45, 15);
            this.location.TabIndex = 29;
            this.location.Text = "label7";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(159, 232);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(45, 15);
            this.size.TabIndex = 28;
            this.size.Text = "label8";
            // 
            // make
            // 
            this.make.AutoSize = true;
            this.make.Location = new System.Drawing.Point(159, 307);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(45, 15);
            this.make.TabIndex = 27;
            this.make.Text = "label9";
            // 
            // modify
            // 
            this.modify.AutoSize = true;
            this.modify.Location = new System.Drawing.Point(159, 335);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(53, 15);
            this.modify.TabIndex = 26;
            this.modify.Text = "label10";
            // 
            // access
            // 
            this.access.AutoSize = true;
            this.access.Location = new System.Drawing.Point(159, 362);
            this.access.Name = "access";
            this.access.Size = new System.Drawing.Size(53, 15);
            this.access.TabIndex = 25;
            this.access.Text = "label11";
            // 
            // kind
            // 
            this.kind.AutoSize = true;
            this.kind.Location = new System.Drawing.Point(159, 172);
            this.kind.Name = "kind";
            this.kind.Size = new System.Drawing.Size(53, 15);
            this.kind.TabIndex = 24;
            this.kind.Text = "label12";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "위치:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "크기:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "만든 날짜:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "수정한 날짜:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "액세스한 날짜";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "파일 형식:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(268, 25);
            this.textBox1.TabIndex = 17;
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(29, 21);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(118, 129);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB.TabIndex = 16;
            this.PB.TabStop = false;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.location);
            this.Controls.Add(this.size);
            this.Controls.Add(this.make);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.access);
            this.Controls.Add(this.kind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PB);
            this.Name = "Form3";
            this.Text = "상세정보";
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label make;
        private System.Windows.Forms.Label modify;
        private System.Windows.Forms.Label access;
        private System.Windows.Forms.Label kind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.ImageList imageList1;
    }
}