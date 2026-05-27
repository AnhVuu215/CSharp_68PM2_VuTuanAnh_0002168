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
	public partial class QLLH : Form
	{
		public QLLH()
		{
			InitializeComponent();
		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void QLLH_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
		
		private void btnThem_Click(object sender, EventArgs e)
		{
			// "Thêm" button for lớp học
			string maId = txtMaID.Text.Trim();
			string maLop = txtMaLop.Text.Trim();
			string tenLop = txtTenLop.Text.Trim();
			string ghiChu = txtGhiChu.Text.Trim();

			if (string.IsNullOrEmpty(maId))
			{
				MessageBox.Show("Vui lòng nhập Mã ID.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtMaID.Focus();
				return;
			}

			if (string.IsNullOrEmpty(maLop))
			{
				MessageBox.Show("Vui lòng nhập Mã lớp.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtMaLop.Focus();
				return;
			}

			if (string.IsNullOrEmpty(tenLop))
			{
				MessageBox.Show("Vui lòng nhập Tên lớp.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtTenLop.Focus();
				return;
			}

			// Add new row to DataGridView
			dgvDanhSach.Rows.Add(maId, maLop, "-", "-", tenLop);

			// Clear inputs
			txtMaID.Clear();
			txtMaLop.Clear();
			txtTenLop.Clear();
			txtGhiChu.Clear();

			MessageBox.Show("Thêm lớp học thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
