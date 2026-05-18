namespace Quanlysinhvien
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
			this.grpThongTin = new System.Windows.Forms.GroupBox();
			this.lblMaID = new System.Windows.Forms.Label();
			this.txtMaID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMaLop = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTenLop = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtDanhsachsv = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.grpThongTin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// grpThongTin
			// 
			this.grpThongTin.Controls.Add(this.txtGhiChu);
			this.grpThongTin.Controls.Add(this.label3);
			this.grpThongTin.Controls.Add(this.txtTenLop);
			this.grpThongTin.Controls.Add(this.label2);
			this.grpThongTin.Controls.Add(this.txtMaLop);
			this.grpThongTin.Controls.Add(this.label1);
			this.grpThongTin.Controls.Add(this.txtMaID);
			this.grpThongTin.Controls.Add(this.lblMaID);
			this.grpThongTin.Location = new System.Drawing.Point(30, 23);
			this.grpThongTin.Name = "grpThongTin";
			this.grpThongTin.Size = new System.Drawing.Size(326, 364);
			this.grpThongTin.TabIndex = 1;
			this.grpThongTin.TabStop = false;
			this.grpThongTin.Text = "Thông tin lớp học";
			// 
			// lblMaID
			// 
			this.lblMaID.AutoSize = true;
			this.lblMaID.Location = new System.Drawing.Point(27, 46);
			this.lblMaID.Name = "lblMaID";
			this.lblMaID.Size = new System.Drawing.Size(45, 16);
			this.lblMaID.TabIndex = 0;
			this.lblMaID.Text = "Mã ID:";
			// 
			// txtMaID
			// 
			this.txtMaID.Location = new System.Drawing.Point(30, 65);
			this.txtMaID.Name = "txtMaID";
			this.txtMaID.Size = new System.Drawing.Size(271, 22);
			this.txtMaID.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mã lớp";
			// 
			// txtMaLop
			// 
			this.txtMaLop.Location = new System.Drawing.Point(30, 124);
			this.txtMaLop.Name = "txtMaLop";
			this.txtMaLop.Size = new System.Drawing.Size(268, 22);
			this.txtMaLop.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Tên lớp:";
			// 
			// txtTenLop
			// 
			this.txtTenLop.Location = new System.Drawing.Point(30, 179);
			this.txtTenLop.Name = "txtTenLop";
			this.txtTenLop.Size = new System.Drawing.Size(268, 22);
			this.txtTenLop.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 216);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Ghi chú";
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Location = new System.Drawing.Point(34, 236);
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(264, 22);
			this.txtGhiChu.TabIndex = 7;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(30, 405);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(161, 40);
			this.btnThem.TabIndex = 2;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(197, 405);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(159, 40);
			this.btnSua.TabIndex = 3;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(30, 451);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(161, 41);
			this.btnXoa.TabIndex = 4;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Location = new System.Drawing.Point(197, 451);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(159, 41);
			this.btnLamMoi.TabIndex = 5;
			this.btnLamMoi.Text = "Làm mới";
			this.btnLamMoi.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(405, 63);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(293, 22);
			this.textBox1.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(402, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "Tìm kiếm";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(724, 61);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 49);
			this.button1.TabIndex = 8;
			this.button1.Text = "Tìm kiếm";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dataGridView1.Location = new System.Drawing.Point(405, 128);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(628, 416);
			this.dataGridView1.TabIndex = 9;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Mã ID";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Mã lớp";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Tên lớp";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 200;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Ghi chú";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 125;
			// 
			// txtDanhsachsv
			// 
			this.txtDanhsachsv.Location = new System.Drawing.Point(30, 498);
			this.txtDanhsachsv.Name = "txtDanhsachsv";
			this.txtDanhsachsv.Size = new System.Drawing.Size(326, 46);
			this.txtDanhsachsv.TabIndex = 10;
			this.txtDanhsachsv.Text = "Xem danh sách sinh viên";
			this.txtDanhsachsv.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(405, 566);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(65, 57);
			this.button2.TabIndex = 11;
			this.button2.Text = "<<";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(476, 566);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(61, 57);
			this.button3.TabIndex = 12;
			this.button3.Text = "<";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(716, 566);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(61, 57);
			this.button4.TabIndex = 13;
			this.button4.Text = ">";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(783, 566);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(61, 57);
			this.button5.TabIndex = 14;
			this.button5.Text = ">>";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(571, 586);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(127, 16);
			this.label5.TabIndex = 15;
			this.label5.Text = "Trang 1/1 | 2 bản ghi";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1077, 673);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.txtDanhsachsv);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnLamMoi);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.grpThongTin);
			this.Name = "Form1";
			this.Text = "Form1";
			this.grpThongTin.ResumeLayout(false);
			this.grpThongTin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaID;
        private System.Windows.Forms.Label lblMaID;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button txtDanhsachsv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
    }
}

