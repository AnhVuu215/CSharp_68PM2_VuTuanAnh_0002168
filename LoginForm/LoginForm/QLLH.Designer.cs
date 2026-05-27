namespace LoginForm
{
    partial class QLLH
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
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnTrangCuoi = new System.Windows.Forms.Button();
			this.btnTrangSau = new System.Windows.Forms.Button();
			this.btnTrangTruoc = new System.Windows.Forms.Button();
			this.btnTrangDau = new System.Windows.Forms.Button();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.dgvDanhSach = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.txtTenLop = new System.Windows.Forms.TextBox();
			this.txtMaLop = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMaID = new System.Windows.Forms.TextBox();
			this.btnXemDanhSachSV = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label10.Location = new System.Drawing.Point(351, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(93, 20);
			this.label10.TabIndex = 27;
			this.label10.Text = "Đăng xuất";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(174, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(150, 20);
			this.label9.TabIndex = 26;
			this.label9.Text = "Quản lý Lớp Học";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(22, 11);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(123, 18);
			this.label8.TabIndex = 25;
			this.label8.Text = "Quản lý Sinh Viên";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(754, 751);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(130, 16);
			this.label7.TabIndex = 41;
			this.label7.Text = "Trang 1/1 |  1 bản ghi";
			// 
			// btnTrangCuoi
			// 
			this.btnTrangCuoi.Location = new System.Drawing.Point(1035, 734);
			this.btnTrangCuoi.Name = "btnTrangCuoi";
			this.btnTrangCuoi.Size = new System.Drawing.Size(60, 51);
			this.btnTrangCuoi.TabIndex = 40;
			this.btnTrangCuoi.Text = ">>";
			this.btnTrangCuoi.UseVisualStyleBackColor = true;
			// 
			// btnTrangSau
			// 
			this.btnTrangSau.Location = new System.Drawing.Point(979, 734);
			this.btnTrangSau.Name = "btnTrangSau";
			this.btnTrangSau.Size = new System.Drawing.Size(60, 51);
			this.btnTrangSau.TabIndex = 39;
			this.btnTrangSau.Text = ">";
			this.btnTrangSau.UseVisualStyleBackColor = true;
			// 
			// btnTrangTruoc
			// 
			this.btnTrangTruoc.Location = new System.Drawing.Point(561, 734);
			this.btnTrangTruoc.Name = "btnTrangTruoc";
			this.btnTrangTruoc.Size = new System.Drawing.Size(60, 51);
			this.btnTrangTruoc.TabIndex = 38;
			this.btnTrangTruoc.Text = "<";
			this.btnTrangTruoc.UseVisualStyleBackColor = true;
			// 
			// btnTrangDau
			// 
			this.btnTrangDau.Location = new System.Drawing.Point(504, 734);
			this.btnTrangDau.Name = "btnTrangDau";
			this.btnTrangDau.Size = new System.Drawing.Size(60, 51);
			this.btnTrangDau.TabIndex = 37;
			this.btnTrangDau.Text = "<<";
			this.btnTrangDau.UseVisualStyleBackColor = true;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.BackColor = System.Drawing.Color.SlateGray;
			this.btnTimKiem.ForeColor = System.Drawing.Color.White;
			this.btnTimKiem.Location = new System.Drawing.Point(1035, 86);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(111, 45);
			this.btnTimKiem.TabIndex = 36;
			this.btnTimKiem.Text = "Tìm";
			this.btnTimKiem.UseVisualStyleBackColor = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.Control;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(501, 67);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(270, 20);
			this.label6.TabIndex = 35;
			this.label6.Text = "Tìm kiếm ( Tên/ Mã SV / Lớp ):";
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
			this.btnLamMoi.ForeColor = System.Drawing.Color.White;
			this.btnLamMoi.Location = new System.Drawing.Point(264, 639);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(215, 37);
			this.btnLamMoi.TabIndex = 34;
			this.btnLamMoi.Text = "Làm mới";
			this.btnLamMoi.UseVisualStyleBackColor = false;
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.Red;
			this.btnXoa.ForeColor = System.Drawing.Color.White;
			this.btnXoa.Location = new System.Drawing.Point(25, 639);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(220, 37);
			this.btnXoa.TabIndex = 33;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.Green;
			this.btnSua.ForeColor = System.Drawing.Color.White;
			this.btnSua.Location = new System.Drawing.Point(264, 587);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(215, 37);
			this.btnSua.TabIndex = 32;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnThem.ForeColor = System.Drawing.Color.White;
			this.btnThem.Location = new System.Drawing.Point(25, 587);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(220, 37);
			this.btnThem.TabIndex = 31;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			// 
			// dgvDanhSach
			// 
			this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dgvDanhSach.Location = new System.Drawing.Point(504, 150);
			this.dgvDanhSach.Name = "dgvDanhSach";
			this.dgvDanhSach.RowHeadersWidth = 51;
			this.dgvDanhSach.RowTemplate.Height = 24;
			this.dgvDanhSach.Size = new System.Drawing.Size(1031, 578);
			this.dgvDanhSach.TabIndex = 30;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Mã SV";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Họ và Tên";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 300;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Giới tính";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Ngày sinh";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 150;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Lớp";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.Width = 125;
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(504, 86);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(516, 22);
			this.txtTimKiem.TabIndex = 29;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtGhiChu);
			this.groupBox1.Controls.Add(this.txtTenLop);
			this.groupBox1.Controls.Add(this.txtMaLop);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtMaID);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(25, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(454, 511);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin lớp học";
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Location = new System.Drawing.Point(19, 301);
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(410, 26);
			this.txtGhiChu.TabIndex = 12;
			// 
			// txtTenLop
			// 
			this.txtTenLop.Location = new System.Drawing.Point(20, 213);
			this.txtTenLop.Name = "txtTenLop";
			this.txtTenLop.Size = new System.Drawing.Size(410, 26);
			this.txtTenLop.TabIndex = 11;
			// 
			// txtMaLop
			// 
			this.txtMaLop.Location = new System.Drawing.Point(21, 135);
			this.txtMaLop.Name = "txtMaLop";
			this.txtMaLop.Size = new System.Drawing.Size(410, 26);
			this.txtMaLop.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 273);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Ghi chú";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tên lớp";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mã ID";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mã lớp";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtMaID
			// 
			this.txtMaID.Location = new System.Drawing.Point(19, 61);
			this.txtMaID.Name = "txtMaID";
			this.txtMaID.Size = new System.Drawing.Size(410, 26);
			this.txtMaID.TabIndex = 0;
			// 
			// btnXemDanhSachSV
			// 
			this.btnXemDanhSachSV.Location = new System.Drawing.Point(25, 693);
			this.btnXemDanhSachSV.Name = "btnXemDanhSachSV";
			this.btnXemDanhSachSV.Size = new System.Drawing.Size(454, 57);
			this.btnXemDanhSachSV.TabIndex = 42;
			this.btnXemDanhSachSV.Text = "Xem danh sách sinh viên";
			this.btnXemDanhSachSV.UseVisualStyleBackColor = true;
			// 
			// QLLH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1620, 901);
			this.Controls.Add(this.btnXemDanhSachSV);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnTrangCuoi);
			this.Controls.Add(this.btnTrangSau);
			this.Controls.Add(this.btnTrangTruoc);
			this.Controls.Add(this.btnTrangDau);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnLamMoi);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.dgvDanhSach);
			this.Controls.Add(this.txtTimKiem);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Name = "QLLH";
			this.Text = "QLLH";
			this.Load += new System.EventHandler(this.QLLH_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTrangCuoi;
        private System.Windows.Forms.Button btnTrangSau;
        private System.Windows.Forms.Button btnTrangTruoc;
        private System.Windows.Forms.Button btnTrangDau;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaID;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Button btnXemDanhSachSV;
    }
}