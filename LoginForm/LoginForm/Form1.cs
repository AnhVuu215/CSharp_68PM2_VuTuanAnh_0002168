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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text.Trim();
			string password = txtPassword.Text.Trim();

			// Kiểm tra bỏ trống
			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Kiểm tra tài khoản (thay bằng MSSV/email thật của bạn)
			if (username == "anhvuvan2005@gmail.com" && password == "0002168")
			{
				MessageBox.Show("Đăng nhập thành công!", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
