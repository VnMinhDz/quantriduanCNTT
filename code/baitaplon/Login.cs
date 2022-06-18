using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace baitaplon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Connect cnn = new Connect();
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            txtMatKhau.isPassword = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            cnn.Ketnoi();
            string query = "SELECT MaNhanVien, TenNhanVien,TenDangNhap, MatKhau, Quyen, Avatar FROM NhanVien where TenDangNhap = '" + txtTenDangNhap.Text + "' and MatKhau = '" + txtMatKhau.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, cnn.cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                Form1.Quyen = dt.Rows[0][4].ToString();
                Form1.bt = dt.Rows[0][5].ToString();
                Form1.MaNhanVien = dt.Rows[0][0].ToString();
                Form1.TenNhanVien = dt.Rows[0][1].ToString();
                Forms.hoadon.MaNhanVien = dt.Rows[0][0].ToString();
                Forms.hoadon.TenNhanVien = dt.Rows[0][1].ToString();
                DoiMatKhau.MaNhanVien = dt.Rows[0][0].ToString();
                DoiMatKhau.MatKhau = dt.Rows[0][3].ToString();
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                LoginError le = new LoginError();
                le.Show();
            }
            cnn.Ngatketnoi();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
