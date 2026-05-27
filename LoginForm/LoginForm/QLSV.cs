using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // "Thêm" button: validate inputs and add a new student row to dgvSinhVien
            string maSv = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string gioiTinh = cboGioiTinh.SelectedItem != null ? cboGioiTinh.SelectedItem.ToString() : cboGioiTinh.Text.Trim();
            string lop = cboLop.SelectedItem != null ? cboLop.SelectedItem.ToString() : cboLop.Text.Trim();
            string ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");

            if (string.IsNullOrEmpty(maSv))
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return;
            }

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập Họ và tên.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            if (string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Giới tính.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGioiTinh.Focus();
                return;
            }

            if (string.IsNullOrEmpty(lop))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Lớp.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLop.Focus();
                return;
            }

            // Add new row to DataGridView
            dgvSinhVien.Rows.Add(maSv, hoTen, gioiTinh, ngaySinh, lop);

            // Clear input fields for next entry
            txtMaSV.Clear();
            txtHoTen.Clear();
            cboGioiTinh.SelectedIndex = -1;
            cboGioiTinh.Text = string.Empty;
            cboLop.SelectedIndex = -1;
            cboLop.Text = string.Empty;
            dtpNgaySinh.Value = DateTime.Today;

            MessageBox.Show("Thêm sinh viên thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
