namespace LoginForm
{
    partial class QLSV
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cboLop = new System.Windows.Forms.ComboBox();
			this.cboGioiTinh = new System.Windows.Forms.ComboBox();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMaSV = new System.Windows.Forms.TextBox();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.dgvSinhVien = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.btnTrangDau = new System.Windows.Forms.Button();
			this.btnTrangTruoc = new System.Windows.Forms.Button();
			this.btnTrangSau = new System.Windows.Forms.Button();
			this.btnTrangCuoi = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cboLop);
			this.groupBox1.Controls.Add(this.cboGioiTinh);
			this.groupBox1.Controls.Add(this.dtpNgaySinh);
			this.groupBox1.Controls.Add(this.txtHoTen);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtMaSV);
			this.groupBox1.Location = new System.Drawing.Point(12, 75);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(454, 511);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin sinh viên";
			// 
			// cboLop
			// 
			this.cboLop.FormattingEnabled = true;
			this.cboLop.Items.AddRange(new object[] {
            "68PM1 - Lớp 68PM1"});
			this.cboLop.Location = new System.Drawing.Point(19, 363);
			this.cboLop.Name = "cboLop";
			this.cboLop.Size = new System.Drawing.Size(410, 24);
			this.cboLop.TabIndex = 10;
			// 
			// cboGioiTinh
			// 
			this.cboGioiTinh.FormattingEnabled = true;
			this.cboGioiTinh.Location = new System.Drawing.Point(19, 281);
			this.cboGioiTinh.Name = "cboGioiTinh";
			this.cboGioiTinh.Size = new System.Drawing.Size(410, 24);
			this.cboGioiTinh.TabIndex = 9;
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.Location = new System.Drawing.Point(19, 202);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(410, 22);
			this.dtpNgaySinh.TabIndex = 8;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(19, 122);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(410, 22);
			this.txtHoTen.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 335);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "Lớp";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 262);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Giới tính";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 174);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ngày sinh";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mã sinh viên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Họ và tên";
			// 
			// txtMaSV
			// 
			this.txtMaSV.Location = new System.Drawing.Point(19, 61);
			this.txtMaSV.Name = "txtMaSV";
			this.txtMaSV.Size = new System.Drawing.Size(410, 22);
			this.txtMaSV.TabIndex = 0;
			this.txtMaSV.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(491, 102);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(516, 22);
			this.txtTimKiem.TabIndex = 1;
			this.txtTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// dgvSinhVien
			// 
			this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dgvSinhVien.Location = new System.Drawing.Point(491, 153);
			this.dgvSinhVien.Name = "dgvSinhVien";
			this.dgvSinhVien.RowHeadersWidth = 51;
			this.dgvSinhVien.RowTemplate.Height = 24;
			this.dgvSinhVien.Size = new System.Drawing.Size(1058, 574);
			this.dgvSinhVien.TabIndex = 2;
			this.dgvSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnThem.ForeColor = System.Drawing.Color.White;
			this.btnThem.Location = new System.Drawing.Point(12, 603);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(220, 37);
			this.btnThem.TabIndex = 11;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.Green;
			this.btnSua.ForeColor = System.Drawing.Color.White;
			this.btnSua.Location = new System.Drawing.Point(251, 603);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(215, 37);
			this.btnSua.TabIndex = 12;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.Red;
			this.btnXoa.ForeColor = System.Drawing.Color.White;
			this.btnXoa.Location = new System.Drawing.Point(12, 655);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(220, 37);
			this.btnXoa.TabIndex = 13;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
			this.btnLamMoi.ForeColor = System.Drawing.Color.White;
			this.btnLamMoi.Location = new System.Drawing.Point(251, 655);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(215, 37);
			this.btnLamMoi.TabIndex = 14;
			this.btnLamMoi.Text = "Làm mới";
			this.btnLamMoi.UseVisualStyleBackColor = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.Control;
			this.label6.Location = new System.Drawing.Point(488, 83);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(186, 16);
			this.label6.TabIndex = 15;
			this.label6.Text = "Tìm kiếm ( Tên/ Mã SV / Lớp ):";
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.BackColor = System.Drawing.Color.SlateGray;
			this.btnTimKiem.ForeColor = System.Drawing.Color.White;
			this.btnTimKiem.Location = new System.Drawing.Point(1022, 102);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(111, 45);
			this.btnTimKiem.TabIndex = 16;
			this.btnTimKiem.Text = "Tìm";
			this.btnTimKiem.UseVisualStyleBackColor = false;
			// 
			// btnTrangDau
			// 
			this.btnTrangDau.Location = new System.Drawing.Point(491, 750);
			this.btnTrangDau.Name = "btnTrangDau";
			this.btnTrangDau.Size = new System.Drawing.Size(60, 51);
			this.btnTrangDau.TabIndex = 17;
			this.btnTrangDau.Text = "<<";
			this.btnTrangDau.UseVisualStyleBackColor = true;
			// 
			// btnTrangTruoc
			// 
			this.btnTrangTruoc.Location = new System.Drawing.Point(548, 750);
			this.btnTrangTruoc.Name = "btnTrangTruoc";
			this.btnTrangTruoc.Size = new System.Drawing.Size(60, 51);
			this.btnTrangTruoc.TabIndex = 18;
			this.btnTrangTruoc.Text = "<";
			this.btnTrangTruoc.UseVisualStyleBackColor = true;
			// 
			// btnTrangSau
			// 
			this.btnTrangSau.Location = new System.Drawing.Point(966, 750);
			this.btnTrangSau.Name = "btnTrangSau";
			this.btnTrangSau.Size = new System.Drawing.Size(60, 51);
			this.btnTrangSau.TabIndex = 19;
			this.btnTrangSau.Text = ">";
			this.btnTrangSau.UseVisualStyleBackColor = true;
			// 
			// btnTrangCuoi
			// 
			this.btnTrangCuoi.Location = new System.Drawing.Point(1022, 750);
			this.btnTrangCuoi.Name = "btnTrangCuoi";
			this.btnTrangCuoi.Size = new System.Drawing.Size(60, 51);
			this.btnTrangCuoi.TabIndex = 20;
			this.btnTrangCuoi.Text = ">>";
			this.btnTrangCuoi.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(741, 767);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(130, 16);
			this.label7.TabIndex = 21;
			this.label7.Text = "Trang 1/1 |  1 bản ghi";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(159, 20);
			this.label8.TabIndex = 22;
			this.label8.Text = "Quản lý Sinh Viên";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(174, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(106, 16);
			this.label9.TabIndex = 23;
			this.label9.Text = "Quản lý Lớp Học";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label10.Location = new System.Drawing.Point(308, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(66, 16);
			this.label10.TabIndex = 24;
			this.label10.Text = "Đăng xuất";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// QLSV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1604, 827);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
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
			this.Controls.Add(this.dgvSinhVien);
			this.Controls.Add(this.txtTimKiem);
			this.Controls.Add(this.groupBox1);
			this.Name = "QLSV";
			this.Text = "QLSV";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTrangDau;
        private System.Windows.Forms.Button btnTrangTruoc;
        private System.Windows.Forms.Button btnTrangSau;
        private System.Windows.Forms.Button btnTrangCuoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}