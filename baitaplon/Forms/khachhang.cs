using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplon.Forms
{
    public partial class khachhang : Form
    {
        Connect cnn = new Connect();
        public khachhang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
               
                string sqlUPDATE = "UPDATE KHACHHANG SET TenKhach = N'" + txtTenKH.Text + "', SoDienThoai = '"+txtSDT.Text+"' WHERE MaKhach = '"+txtMaKH.Text+"'";
                cnn.ThucThiDl(sqlUPDATE);
                string sql = "select * from KHACHHANG";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sql);

           
        }

        private void khachhang_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM KHACHHANG";
            bunifuCustomDataGrid1.DataSource = cnn.XemDL(sql);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string sql;
            if (comboBox1.Text == "Tên khách hàng")
            {
                sql = "SELECT * FROM KHACHHANG WHERE TenKhach like '%" + txtTimKiem.Text + "%' ";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sql);
            }
            if (comboBox1.Text == "Mã khách hàng")
            {
                sql = "SELECT * FROM KHACHHANG WHERE MaKhach like '%" + txtTimKiem.Text + "%' ";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sql);
            }
            if (comboBox1.Text == "Số điện thoại")
            {
                sql = "SELECT * FROM KHACHHANG WHERE SoDienThoai like '%" + txtTimKiem.Text + "%' ";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sql);
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = bunifuCustomDataGrid1.CurrentRow.Index;
            txtMaKH.Enabled = false;
            txtMaKH.Text = bunifuCustomDataGrid1.Rows[n].Cells[0].Value.ToString();
            txtTenKH.Text = bunifuCustomDataGrid1.Rows[n].Cells[1].Value.ToString();
            txtSDT.Text = bunifuCustomDataGrid1.Rows[n].Cells[2].Value.ToString();

        }
    }
}
