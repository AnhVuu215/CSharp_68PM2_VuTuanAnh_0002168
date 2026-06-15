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
    public partial class UCQLSV : UserControl
    {
        // currently selected student MaSV from grid (used for updates)
        private string selectedMaSV = null;

        public UCQLSV()
        {
            InitializeComponent();
            // ensure the click handler is attached at runtime
            this.button1.Click -= this.button1_Click;
            this.button1.Click += this.button1_Click;
            // attach DataGridView cell click handler to populate fields for edit/delete
            this.dataGridView1.CellClick -= this.dataGridView1_CellClick;
            this.dataGridView1.CellClick += this.dataGridView1_CellClick;
            // attach update button
            this.button2.Click -= this.button2_Click;
            this.button2.Click += this.button2_Click;
            // Load existing students from database
            LoadStudents();
        }

        private void LoadStudents()
        {
            try
            {
                string conn = DatabaseHelper.DefaultConnectionString;
                using (var db = new DataClasses1DataContext(conn))
                {
                    dataGridView1.Rows.Clear();
                    foreach (var s in db.Students)
                    {
                        string ngay = s.NgaySinh.HasValue ? s.NgaySinh.Value.ToString("dd/MM/yyyy") : string.Empty;
                        dataGridView1.Rows.Add(s.MaSV, s.HoTen, s.GioiTinh, ngay, s.Lop);
                    }
                }
            }
            catch (Exception ex)
            {
                // Non-fatal: show message and continue
                MessageBox.Show("Không thể load dữ liệu sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Populate form fields when a row in the grid is clicked
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return; // header
                var row = dataGridView1.Rows[e.RowIndex];
                if (row == null || row.IsNewRow) return;

                // remember original MaSV for update lookup
                selectedMaSV = row.Cells[0].Value?.ToString();

                // Fill inputs from the selected row cells
                txtMaSV.Text = selectedMaSV ?? string.Empty;
                textBox2.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                comboBox1.Text = row.Cells[2].Value?.ToString() ?? string.Empty;

                // Parse date in format dd/MM/yyyy if possible
                var dateText = row.Cells[3].Value?.ToString();
                DateTime dt;
                if (!string.IsNullOrEmpty(dateText) && DateTime.TryParseExact(dateText, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dt))
                {
                    dateTimePicker1.Value = dt;
                }
                else
                {
                    // fallback: try general parse
                    if (DateTime.TryParse(dateText, out dt))
                        dateTimePicker1.Value = dt;
                }

                comboBox2.Text = row.Cells[4].Value?.ToString() ?? string.Empty;

                // Highlight the selected row
                dataGridView1.ClearSelection();
                row.Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn dòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Thêm sinh viên từ user control
            string maSv = txtMaSV.Text.Trim();
            string hoTen = textBox2.Text.Trim();
            string gioiTinh = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : comboBox1.Text.Trim();
            string lop = comboBox2.SelectedItem != null ? comboBox2.SelectedItem.ToString() : comboBox2.Text.Trim();
            string ngaySinh = dateTimePicker1.Value.ToString("dd/MM/yyyy");

            if (string.IsNullOrEmpty(maSv))
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return;
            }

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập Họ và tên.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            if (string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Giới tính.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(lop))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Lớp.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox2.Focus();
                return;
            }

            // Check duplicate Mã SV in current grid
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (r.IsNewRow) continue;
                var existing = r.Cells[0].Value?.ToString();
                if (!string.IsNullOrEmpty(existing) && string.Equals(existing, maSv, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại.", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSV.Focus();
                    return;
                }
            }

            try
            {
                // disable user-added blank row to avoid confusion
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Rows.Add(maSv, hoTen, gioiTinh, ngaySinh, lop);

                // Clear inputs
            txtMaSV.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = string.Empty;
            comboBox2.SelectedIndex = -1;
            comboBox2.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Today;
                // focus the newly added row
                if (dataGridView1.Rows.Count > 0)
                {
                    int index = dataGridView1.Rows.Count - 1;
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[index].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = index;
                }

                MessageBox.Show("Thêm sinh viên thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Save to database via LINQ-to-SQL using configured connection
                try
                {
                    string conn = DatabaseHelper.DefaultConnectionString;
                    using (var db = new DataClasses1DataContext(conn))
                    {
                        var s = new Student
                        {
                            MaSV = maSv,
                            HoTen = hoTen,
                            GioiTinh = gioiTinh,
                            NgaySinh = dateTimePicker1.Value.Date,
                            Lop = lop
                        };
                        db.Students.InsertOnSubmit(s);
                        db.SubmitChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lưu vào CSDL thất bại: " + ex.Message, "Lỗi lưu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update selected student
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa từ bảng.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSv = txtMaSV.Text.Trim();
            string hoTen = textBox2.Text.Trim();
            string gioiTinh = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : comboBox1.Text.Trim();
            string lop = comboBox2.SelectedItem != null ? comboBox2.SelectedItem.ToString() : comboBox2.Text.Trim();

            if (string.IsNullOrEmpty(maSv) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Mã SV và Họ tên không được để trống.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string conn = DatabaseHelper.DefaultConnectionString;
                using (var db = new DataClasses1DataContext(conn))
                {
                    var existing = db.Students.FirstOrDefault(x => x.MaSV == selectedMaSV);
                    if (existing == null)
                    {
                        MessageBox.Show("Không tìm thấy sinh viên trong CSDL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // update fields
                    existing.MaSV = maSv;
                    existing.HoTen = hoTen;
                    existing.GioiTinh = gioiTinh;
                    existing.NgaySinh = dateTimePicker1.Value.Date;
                    existing.Lop = lop;

                    db.SubmitChanges();
                }

                // Refresh grid
                LoadStudents();
                MessageBox.Show("Cập nhật sinh viên thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedMaSV = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
