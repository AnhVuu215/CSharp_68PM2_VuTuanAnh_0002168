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
    public partial class UCQLLH : UserControl
    {
        public UCQLLH()
        {
            InitializeComponent();
            LoadClasses();
        }

        private void LoadClasses()
        {
            try
            {
                string conn = DatabaseHelper.DefaultConnectionString;
                using (var db = new DataClasses1DataContext(conn))
                {
                    dgvDanhSach.Rows.Clear();
                    foreach (var c in db.Classes)
                    {
                        dgvDanhSach.Rows.Add(c.MaID, c.MaLop, "-", "-", c.TenLop);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể load dữ liệu lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Thêm lớp học từ user control (sử dụng tên control rõ ràng)
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

            // Check duplicate MaID or MaLop in current grid
            foreach (DataGridViewRow r in dgvDanhSach.Rows)
            {
                if (r.IsNewRow) continue;
                var existingId = r.Cells[0].Value?.ToString();
                var existingMaLop = r.Cells[1].Value?.ToString();
                if (!string.IsNullOrEmpty(existingId) && string.Equals(existingId, maId, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã ID đã tồn tại.", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaID.Focus();
                    return;
                }
                if (!string.IsNullOrEmpty(existingMaLop) && string.Equals(existingMaLop, maLop, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã lớp đã tồn tại.", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaLop.Focus();
                    return;
                }
            }

            // Add to grid
            dgvDanhSach.Rows.Add(maId, maLop, "-", "-", tenLop);

            // Clear inputs
            txtMaID.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtGhiChu.Clear();

            MessageBox.Show("Thêm lớp học thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Save to database via LINQ-to-SQL
            try
            {
                string conn = DatabaseHelper.DefaultConnectionString;
                using (var db = new DataClasses1DataContext(conn))
                {
                    var c = new Class
                    {
                        MaID = maId,
                        MaLop = maLop,
                        TenLop = tenLop,
                        GhiChu = ghiChu
                    };
                    db.Classes.InsertOnSubmit(c);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu vào CSDL thất bại: " + ex.Message, "Lỗi lưu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
