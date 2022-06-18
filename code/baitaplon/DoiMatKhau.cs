using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplon
{
    public partial class DoiMatKhau : Form
    {
        public static string MaNhanVien, MatKhau;
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        Connect cnn = new Connect();
        

        private void btnDoiMatKhau_Click_1(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == MatKhau)
            {
                string sqlDoiMatKhau = "UPDATE NHANVIEN SET MatKhau = '" + txtMatKhauMoi.Text + "' where MaNhanVien = '" + MaNhanVien + "'";
                cnn.ThucThiDl(sqlDoiMatKhau);
                Doimatkhauthanhcong ok = new Doimatkhauthanhcong();
                ok.Show();
                MatKhau = txtMatKhauMoi.Text;

            }
            else if (txtMatKhauCu.Text != MatKhau)
            {
                LoginError le = new LoginError();
                le.Show();
            }
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
