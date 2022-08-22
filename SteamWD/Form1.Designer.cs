namespace SteamWD
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pb_Animation = new System.Windows.Forms.PictureBox();
            this.Btn_Go = new System.Windows.Forms.Button();
            this.Lbl_ModName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_info = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Download = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_SteamURL = new System.Windows.Forms.TextBox();
            this.Pnl_Header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Animation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Download)).BeginInit();
            this.Pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Pb_Animation);
            this.panel1.Controls.Add(this.Btn_Go);
            this.panel1.Controls.Add(this.Lbl_ModName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Lbl_info);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Btn_Download);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Txt_SteamURL);
            this.panel1.Controls.Add(this.Pnl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 165);
            this.panel1.TabIndex = 0;
            // 
            // Pb_Animation
            // 
            this.Pb_Animation.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Animation.Image")));
            this.Pb_Animation.Location = new System.Drawing.Point(129, 107);
            this.Pb_Animation.Name = "Pb_Animation";
            this.Pb_Animation.Size = new System.Drawing.Size(100, 50);
            this.Pb_Animation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Animation.TabIndex = 6;
            this.Pb_Animation.TabStop = false;
            // 
            // Btn_Go
            // 
            this.Btn_Go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Go.Location = new System.Drawing.Point(260, 119);
            this.Btn_Go.Name = "Btn_Go";
            this.Btn_Go.Size = new System.Drawing.Size(75, 33);
            this.Btn_Go.TabIndex = 5;
            this.Btn_Go.Text = "Göster";
            this.Btn_Go.UseVisualStyleBackColor = true;
            this.Btn_Go.Click += new System.EventHandler(this.Btn_Go_Click);
            // 
            // Lbl_ModName
            // 
            this.Lbl_ModName.AutoSize = true;
            this.Lbl_ModName.Location = new System.Drawing.Point(58, 141);
            this.Lbl_ModName.Name = "Lbl_ModName";
            this.Lbl_ModName.Size = new System.Drawing.Size(10, 13);
            this.Lbl_ModName.TabIndex = 4;
            this.Lbl_ModName.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mod Adı:";
            // 
            // Lbl_info
            // 
            this.Lbl_info.AutoSize = true;
            this.Lbl_info.Location = new System.Drawing.Point(50, 119);
            this.Lbl_info.Name = "Lbl_info";
            this.Lbl_info.Size = new System.Drawing.Size(10, 13);
            this.Lbl_info.TabIndex = 4;
            this.Lbl_info.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Durum:";
            // 
            // Btn_Download
            // 
            this.Btn_Download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Download.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Download.Image")));
            this.Btn_Download.Location = new System.Drawing.Point(326, 70);
            this.Btn_Download.Name = "Btn_Download";
            this.Btn_Download.Size = new System.Drawing.Size(32, 32);
            this.Btn_Download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Btn_Download.TabIndex = 3;
            this.Btn_Download.TabStop = false;
            this.Btn_Download.Click += new System.EventHandler(this.Btn_Download_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Steam Atölye URL:";
            // 
            // Txt_SteamURL
            // 
            this.Txt_SteamURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SteamURL.Location = new System.Drawing.Point(11, 75);
            this.Txt_SteamURL.Name = "Txt_SteamURL";
            this.Txt_SteamURL.Size = new System.Drawing.Size(308, 24);
            this.Txt_SteamURL.TabIndex = 1;
            // 
            // Pnl_Header
            // 
            this.Pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.Pnl_Header.Controls.Add(this.label1);
            this.Pnl_Header.Controls.Add(this.pictureBox1);
            this.Pnl_Header.Controls.Add(this.Btn_Close);
            this.Pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Header.Name = "Pnl_Header";
            this.Pnl_Header.Size = new System.Drawing.Size(364, 38);
            this.Pnl_Header.TabIndex = 0;
            this.Pnl_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Header_MouseDown);
            this.Pnl_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnl_Header_MouseMove);
            this.Pnl_Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pnl_Header_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(41, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "SWD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(329, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(32, 32);
            this.Btn_Close.TabIndex = 0;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(366, 165);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Atölye Indirici";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Animation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Download)).EndInit();
            this.Pnl_Header.ResumeLayout(false);
            this.Pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Pnl_Header;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Btn_Download;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_SteamURL;
        private System.Windows.Forms.Label Lbl_ModName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Go;
        private System.Windows.Forms.PictureBox Pb_Animation;
    }
}

