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
        private string selectedMaID = null;

        public UCQLLH()
        {
            InitializeComponent();
            // attach handlers
            this.dgvDanhSach.CellClick -= this.dgvDanhSach_CellClick;
            this.dgvDanhSach.CellClick += this.dgvDanhSach_CellClick;

            this.btnSua.Click -= this.btnSua_Click;
            this.btnSua.Click += this.btnSua_Click;

            this.btnXoa.Click -= this.btnXoa_Click;
            this.btnXoa.Click += this.btnXoa_Click;

            this.btnLamMoi.Click -= this.btnLamMoi_Click;
            this.btnLamMoi.Click += this.btnLamMoi_Click;

            this.btnTimKiem.Click -= this.btnTimKiem_Click;
            this.btnTimKiem.Click += this.btnTimKiem_Click;

            this.btnXemDanhSachSV.Click -= this.btnXemDanhSachSV_Click;
            this.btnXemDanhSachSV.Click += this.btnXemDanhSachSV_Click;

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

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                var row = dgvDanhSach.Rows[e.RowIndex];
                if (row == null || row.IsNewRow) return;

                selectedMaID = row.Cells[0].Value?.ToString();
                txtMaID.Text = selectedMaID ?? string.Empty;
                txtMaLop.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                txtTenLop.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
                // ghi chu is not displayed in grid (placeholder), try to load from DB
                try
                {
                    string conn = DatabaseHelper.DefaultConnectionString;
                    using (var db = new DataClasses1DataContext(conn))
                    {
                        var c = db.Classes.FirstOrDefault(x => x.MaID == selectedMaID);
                        if (c != null) txtGhiChu.Text = c.GhiChu ?? string.Empty;
                        else txtGhiChu.Text = string.Empty;
                    }
                }
                catch { txtGhiChu.Text = string.Empty; }

                dgvDanhSach.ClearSelection();
                row.Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaID))
            {
                MessageBox.Show("Vui lòng chọn lớp cần sửa từ bảng.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maId = txtMaID.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();
            string ghiChu = txtGhiChu.Text.Trim();

            if (string.IsNullOrEmpty(maId) || string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Mã ID, Mã lớp và Tên lớp không được để trống.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string conn = DatabaseHelper.DefaultConnectionString;
                using (var db = new DataClasses1DataContext(conn))
                {
                    var existing = db.Classes.FirstOrDefault(x => x.MaID == selectedMaID);
                    if (existing == null)
                    {
                        MessageBox.Show("Không tìm thấy lớp trong CSDL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    existing.MaID = maId;
                    existing.MaLop = maLop;
                    existing.TenLop = tenLop;
                    existing.GhiChu = ghiChu;

                    db.SubmitChanges();
                }

                LoadClasses();
                MessageBox.Show("Cập nhật lớp học thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedMaID = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaID))
            {
                MessageBox.Show("Vui lòng chọn lớp cần xóa từ bảng.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa lớp '{selectedMaID}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                string conn = DatabaseHelper.DefaultConnectionString;
                using (var db = new DataClasses1DataContext(conn))
                {
                    var existing = db.Classes.FirstOrDefault(x => x.MaID == selectedMaID);
                    if (existing == null)
                    {
                        MessageBox.Show("Không tìm thấy lớp trong CSDL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    db.Classes.DeleteOnSubmit(existing);
                    db.SubmitChanges();
                }

                LoadClasses();
                txtMaID.Clear();
                txtMaLop.Clear();
                txtTenLop.Clear();
                txtGhiChu.Clear();
                selectedMaID = null;
                MessageBox.Show("Xóa lớp học thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaID.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtGhiChu.Clear();
            selectedMaID = null;
            LoadClasses();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string t = txtTimKiem.Text.Trim();
                string conn = DatabaseHelper.DefaultConnectionString;
                using (var db = new DataClasses1DataContext(conn))
                {
                    var q = db.Classes.AsQueryable();
                    if (!string.IsNullOrEmpty(t))
                    {
                        q = q.Where(x => x.MaID.Contains(t) || x.MaLop.Contains(t) || x.TenLop.Contains(t));
                    }
                    dgvDanhSach.Rows.Clear();
                    foreach (var c in q)
                    {
                        dgvDanhSach.Rows.Add(c.MaID, c.MaLop, "-", "-", c.TenLop);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXemDanhSachSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaID))
            {
                MessageBox.Show("Vui lòng chọn lớp để xem danh sách sinh viên.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string conn = DatabaseHelper.DefaultConnectionString;
                using (var db = new DataClasses1DataContext(conn))
                {
                    var cls = db.Classes.FirstOrDefault(x => x.MaID == selectedMaID);
                    if (cls == null)
                    {
                        MessageBox.Show("Không tìm thấy lớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var students = db.Students.Where(s => s.Lop == cls.MaLop).ToList();
                    using (var frm = new FormDanhSachSV(students, $"Danh sách sinh viên - {cls.TenLop} ({cls.MaLop})"))
                    {
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
