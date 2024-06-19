namespace WindowsFormsApplication1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbKhung = new System.Windows.Forms.GroupBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.btnChoiLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblBuocDi = new System.Windows.Forms.Label();
            this.lblThoiGianDem = new System.Windows.Forms.Label();
            this.tmrThoiGianDem = new System.Windows.Forms.Timer(this.components);
            this.btnTamDung = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnGiaiToiUu = new System.Windows.Forms.Button();
            this.lblTimeGiai = new System.Windows.Forms.Label();
            this.lblBuocDuyet = new System.Windows.Forms.Label();
            this.gbAnhGoc = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbKhung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKhung
            // 
            this.gbKhung.Controls.Add(this.pbx1);
            this.gbKhung.Controls.Add(this.pbx2);
            this.gbKhung.Controls.Add(this.pbx3);
            this.gbKhung.Controls.Add(this.pbx4);
            this.gbKhung.Controls.Add(this.pbx5);
            this.gbKhung.Controls.Add(this.pbx6);
            this.gbKhung.Controls.Add(this.pbx7);
            this.gbKhung.Controls.Add(this.pbx8);
            this.gbKhung.Controls.Add(this.pbx9);
            this.gbKhung.Location = new System.Drawing.Point(33, 4);
            this.gbKhung.Name = "gbKhung";
            this.gbKhung.Size = new System.Drawing.Size(427, 433);
            this.gbKhung.TabIndex = 0;
            this.gbKhung.TabStop = false;
            this.gbKhung.Text = "Khung";
            // 
            // pbx1
            // 
            this.pbx1.Image = global::WindowsFormsApplication1.Properties.Resources._1;
            this.pbx1.Location = new System.Drawing.Point(17, 23);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(130, 130);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx2
            // 
            this.pbx2.Image = global::WindowsFormsApplication1.Properties.Resources._2;
            this.pbx2.Location = new System.Drawing.Point(149, 23);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(130, 130);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 0;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx3
            // 
            this.pbx3.Image = global::WindowsFormsApplication1.Properties.Resources._3;
            this.pbx3.Location = new System.Drawing.Point(281, 23);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(130, 130);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 0;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx4
            // 
            this.pbx4.Image = global::WindowsFormsApplication1.Properties.Resources._4;
            this.pbx4.Location = new System.Drawing.Point(17, 155);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(130, 130);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 0;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx5
            // 
            this.pbx5.Image = global::WindowsFormsApplication1.Properties.Resources._5;
            this.pbx5.Location = new System.Drawing.Point(149, 155);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(130, 130);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 0;
            this.pbx5.TabStop = false;
            this.pbx5.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx6
            // 
            this.pbx6.Image = global::WindowsFormsApplication1.Properties.Resources._6;
            this.pbx6.Location = new System.Drawing.Point(281, 155);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(130, 130);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 0;
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx7
            // 
            this.pbx7.Image = global::WindowsFormsApplication1.Properties.Resources._7;
            this.pbx7.Location = new System.Drawing.Point(17, 287);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(130, 130);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 0;
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx8
            // 
            this.pbx8.Image = global::WindowsFormsApplication1.Properties.Resources._8;
            this.pbx8.Location = new System.Drawing.Point(149, 287);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(130, 130);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 0;
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx9
            // 
            this.pbx9.Image = global::WindowsFormsApplication1.Properties.Resources._null;
            this.pbx9.Location = new System.Drawing.Point(281, 287);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(130, 130);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 0;
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.BackColor = System.Drawing.Color.LightCoral;
            this.btnChoiLai.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChoiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiLai.Location = new System.Drawing.Point(492, 184);
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.Size = new System.Drawing.Size(59, 42);
            this.btnChoiLai.TabIndex = 1;
            this.btnChoiLai.Text = "Chơi Lại";
            this.btnChoiLai.UseVisualStyleBackColor = false;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gray;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Location = new System.Drawing.Point(492, 334);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(59, 42);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblBuocDi
            // 
            this.lblBuocDi.AutoSize = true;
            this.lblBuocDi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuocDi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBuocDi.Location = new System.Drawing.Point(631, 445);
            this.lblBuocDi.Name = "lblBuocDi";
            this.lblBuocDi.Size = new System.Drawing.Size(108, 19);
            this.lblBuocDi.TabIndex = 2;
            this.lblBuocDi.Text = "Số Bước Đi: ";
            // 
            // lblThoiGianDem
            // 
            this.lblThoiGianDem.AutoSize = true;
            this.lblThoiGianDem.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianDem.ForeColor = System.Drawing.Color.Red;
            this.lblThoiGianDem.Location = new System.Drawing.Point(690, 340);
            this.lblThoiGianDem.Name = "lblThoiGianDem";
            this.lblThoiGianDem.Size = new System.Drawing.Size(201, 60);
            this.lblThoiGianDem.TabIndex = 3;
            this.lblThoiGianDem.Text = "00:00:00";
            // 
            // tmrThoiGianDem
            // 
            this.tmrThoiGianDem.Enabled = true;
            this.tmrThoiGianDem.Interval = 900;
            this.tmrThoiGianDem.Tick += new System.EventHandler(this.TinhThoiGian);
            // 
            // btnTamDung
            // 
            this.btnTamDung.BackColor = System.Drawing.Color.LightCoral;
            this.btnTamDung.Enabled = false;
            this.btnTamDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamDung.Location = new System.Drawing.Point(492, 232);
            this.btnTamDung.Name = "btnTamDung";
            this.btnTamDung.Size = new System.Drawing.Size(59, 42);
            this.btnTamDung.TabIndex = 4;
            this.btnTamDung.Text = "Tạm Dừng";
            this.btnTamDung.UseVisualStyleBackColor = false;
            this.btnTamDung.Click += new System.EventHandler(this.PauseOrResume);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(483, 106);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(79, 33);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "<< Đi Lui";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnDiLui_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Cyan;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(483, 145);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(79, 33);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Đi Tới >>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnDiToi_Click);
            // 
            // btnGiaiToiUu
            // 
            this.btnGiaiToiUu.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnGiaiToiUu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGiaiToiUu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiToiUu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGiaiToiUu.Location = new System.Drawing.Point(492, 280);
            this.btnGiaiToiUu.Name = "btnGiaiToiUu";
            this.btnGiaiToiUu.Size = new System.Drawing.Size(59, 42);
            this.btnGiaiToiUu.TabIndex = 7;
            this.btnGiaiToiUu.Text = "Giải game";
            this.btnGiaiToiUu.UseVisualStyleBackColor = false;
            this.btnGiaiToiUu.Click += new System.EventHandler(this.btnGiaiToiUu_Click);
            // 
            // lblTimeGiai
            // 
            this.lblTimeGiai.AutoSize = true;
            this.lblTimeGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeGiai.ForeColor = System.Drawing.Color.Green;
            this.lblTimeGiai.Location = new System.Drawing.Point(631, 405);
            this.lblTimeGiai.Name = "lblTimeGiai";
            this.lblTimeGiai.Size = new System.Drawing.Size(191, 20);
            this.lblTimeGiai.TabIndex = 8;
            this.lblTimeGiai.Text = "Thời Gian Giải : 0.0 ms";
            this.lblTimeGiai.Click += new System.EventHandler(this.lblTimeGiai_Click);
            // 
            // lblBuocDuyet
            // 
            this.lblBuocDuyet.AutoSize = true;
            this.lblBuocDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuocDuyet.ForeColor = System.Drawing.Color.Teal;
            this.lblBuocDuyet.Location = new System.Drawing.Point(631, 425);
            this.lblBuocDuyet.Name = "lblBuocDuyet";
            this.lblBuocDuyet.Size = new System.Drawing.Size(149, 20);
            this.lblBuocDuyet.TabIndex = 9;
            this.lblBuocDuyet.Text = "Số Bước Duyệt: 0";
            this.lblBuocDuyet.Click += new System.EventHandler(this.lblBuocDuyet_Click);
            // 
            // gbAnhGoc
            // 
            this.gbAnhGoc.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.original;
            this.gbAnhGoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbAnhGoc.ForeColor = System.Drawing.Color.White;
            this.gbAnhGoc.Location = new System.Drawing.Point(587, 4);
            this.gbAnhGoc.Name = "gbAnhGoc";
            this.gbAnhGoc.Size = new System.Drawing.Size(286, 333);
            this.gbAnhGoc.TabIndex = 0;
            this.gbAnhGoc.TabStop = false;
            this.gbAnhGoc.Text = "Hình Gốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(575, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thời gian chơi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBuocDuyet);
            this.Controls.Add(this.lblTimeGiai);
            this.Controls.Add(this.btnGiaiToiUu);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnTamDung);
            this.Controls.Add(this.lblThoiGianDem);
            this.Controls.Add(this.lblBuocDi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChoiLai);
            this.Controls.Add(this.gbAnhGoc);
            this.Controls.Add(this.gbKhung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Ghép Hình";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KiemTraThoatChuongTrinh);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbKhung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKhung;
        private System.Windows.Forms.GroupBox gbAnhGoc;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.Button btnChoiLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblBuocDi;
        private System.Windows.Forms.Label lblThoiGianDem;
        private System.Windows.Forms.Timer tmrThoiGianDem;
        private System.Windows.Forms.Button btnTamDung;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnGiaiToiUu;
		private System.Windows.Forms.Label lblTimeGiai;
		private System.Windows.Forms.Label lblBuocDuyet;
        private System.Windows.Forms.Label label1;
    }
}

