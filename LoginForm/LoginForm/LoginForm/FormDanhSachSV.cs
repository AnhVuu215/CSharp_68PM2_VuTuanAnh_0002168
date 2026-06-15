using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LoginForm
{
    public class FormDanhSachSV : Form
    {
        private DataGridView dgv;
        private Button btnClose;

        public FormDanhSachSV(IEnumerable<Student> students, string title = "Danh sách sinh viên")
        {
            this.Text = title;
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterParent;

            dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false
            };

            dgv.Columns.Add("MaSV", "Mã SV");
            dgv.Columns.Add("HoTen", "H? và tên");
            dgv.Columns.Add("GioiTinh", "Gi?i tính");
            dgv.Columns.Add("NgaySinh", "Ngày sinh");
            dgv.Columns.Add("Lop", "L?p");

            var panel = new Panel { Dock = DockStyle.Bottom, Height = 50 };
            btnClose = new Button { Text = "?óng", Width = 120, Height = 30, Left = 10, Top = 10 };
            btnClose.Click += (s, e) => this.Close();
            panel.Controls.Add(btnClose);

            this.Controls.Add(dgv);
            this.Controls.Add(panel);

            LoadData(students);
        }

        private void LoadData(IEnumerable<Student> students)
        {
            dgv.Rows.Clear();
            if (students == null) return;
            foreach (var s in students)
            {
                string ngay = s.NgaySinh.HasValue ? s.NgaySinh.Value.ToString("dd/MM/yyyy") : string.Empty;
                dgv.Rows.Add(s.MaSV, s.HoTen, s.GioiTinh, ngay, s.Lop);
            }
        }
    }
}
