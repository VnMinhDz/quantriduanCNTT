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

namespace baitaplon.Forms
{
    public partial class sanpham : Form
    {
        Connect cnn = new Connect(); //Khai báo biến cnn kiểu Connect

        public sanpham()
        {
            InitializeComponent();
        }
        
        private void sanpham_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM SANPHAM";
            bunifuCustomDataGrid1.DataSource = cnn.XemDL(sql);
            
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n;
            maSP.Enabled = false;
            n = bunifuCustomDataGrid1.CurrentRow.Index;
            maSP.Text = bunifuCustomDataGrid1.Rows[n].Cells[0].Value.ToString();
            tenSP.Text = bunifuCustomDataGrid1.Rows[n].Cells[1].Value.ToString();
            giaSP.Text = bunifuCustomDataGrid1.Rows[n].Cells[2].Value.ToString();
            danhmucSP.Text = bunifuCustomDataGrid1.Rows[n].Cells[3].Value.ToString();
            NSX.Text = bunifuCustomDataGrid1.Rows[n].Cells[4].Value.ToString();
            soLuong.Value =Convert.ToDecimal(bunifuCustomDataGrid1.Rows[n].Cells[5].Value.ToString());
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            maSP.Enabled = true;
            maSP.Text = "";
            tenSP.Text = "";
            giaSP.Text = "";
            danhmucSP.Text = "";
            NSX.Text = "";
            soLuong.Value = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (maSP.Text != "")
            {
                try
                {
                    string sqlINSERT = "INSERT INTO SANPHAM VALUES('" + maSP.Text + "', N'" + tenSP.Text + "', '" + Convert.ToInt32(giaSP.Text) + "', N'" + danhmucSP.Text + "', N'" + NSX.Text + "', '" + Convert.ToInt32(soLuong.Value.ToString()) + "')";
                    cnn.ThucThiDl(sqlINSERT);
                    string sql = "SELECT * FROM SANPHAM";
                    bunifuCustomDataGrid1.DataSource = cnn.XemDL(sql);
                    
                }
                catch (Exception)
                {
                    SanPhamError spe = new SanPhamError();
                    spe.Show();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
           
                string sqlDELETE = "DELETE FROM SANPHAM WHERE MaSanPham = '" + maSP.Text + "'";
                cnn.ThucThiDl(sqlDELETE);
                string sql = "SELECT * FROM SANPHAM";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sql);
                
            }
            catch (Exception)
            {
                SanPhamError spe = new SanPhamError();
                spe.Show();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlUPDATE = "UPDATE SANPHAM SET TenSanPham = N'" + tenSP.Text + "', DonGia = '" + Convert.ToInt32(giaSP.Text) + "', DanhMuc = N'" + danhmucSP.Text + "', NhaSanXuat = N'" + NSX.Text + "', SoLuong = '" + soLuong.Value + "'  WHERE MaSanPham = '" + maSP.Text + "' ";
                cnn.ThucThiDl(sqlUPDATE);
                string sql = "SELECT * FROM SANPHAM";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sql);
                
            }
            catch (Exception)
            {
                SanPhamError spe = new SanPhamError();
                spe.Show();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {   string sqlTimKiem = "";
            if (danhmucSPTimKiem.Text == "" && txtTimKiem.Text != "")
            {
                sqlTimKiem = "SELECT * FROM SANPHAM WHERE TenSanPham like '%"+txtTimKiem.Text+"%'";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sqlTimKiem);
            }
            if (danhmucSPTimKiem.Text == "Tất cả" && txtTimKiem.Text != "")
            {
                sqlTimKiem = "SELECT * FROM SANPHAM WHERE TenSanPham like '%" + txtTimKiem.Text + "%'";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sqlTimKiem);
            }
            if (danhmucSPTimKiem.Text == "CPU" && txtTimKiem.Text != "")
            {
                sqlTimKiem = "SELECT * FROM SANPHAM WHERE TenSanPham like '%" + txtTimKiem.Text + "%' AND DanhMuc = '"+danhmucSPTimKiem.Text+"'";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sqlTimKiem);
            }
            if (danhmucSPTimKiem.Text == "Mainboard" && txtTimKiem.Text != "")
            {
                sqlTimKiem = "SELECT * FROM SANPHAM WHERE TenSanPham like '%" + txtTimKiem.Text + "%' AND DanhMuc = '" + danhmucSPTimKiem.Text + "'";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sqlTimKiem);
            }
            if (danhmucSPTimKiem.Text == "RAM" && txtTimKiem.Text != "")
            {
                sqlTimKiem = "SELECT * FROM SANPHAM WHERE TenSanPham like '%" + txtTimKiem.Text + "%' AND DanhMuc = '" + danhmucSPTimKiem.Text + "'";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sqlTimKiem);
            }
            if (danhmucSPTimKiem.Text == "VGA" && txtTimKiem.Text != "")
            {
                sqlTimKiem = "SELECT * FROM SANPHAM WHERE TenSanPham like '%" + txtTimKiem.Text + "%' AND DanhMuc = '" + danhmucSPTimKiem.Text + "'";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sqlTimKiem);
            }
            if (danhmucSPTimKiem.Text == "HDD" && txtTimKiem.Text != "")
            {
                sqlTimKiem = "SELECT * FROM SANPHAM WHERE TenSanPham like '%" + txtTimKiem.Text + "%' AND DanhMuc = '" + danhmucSPTimKiem.Text + "'";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sqlTimKiem);
            }
            if (danhmucSPTimKiem.Text == "SSD " && txtTimKiem.Text != "")
            {
                sqlTimKiem = "SELECT * FROM SANPHAM WHERE TenSanPham like '%" + txtTimKiem.Text + "%' AND DanhMuc = '" + danhmucSPTimKiem.Text + "'";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sqlTimKiem);
            }
            if (danhmucSPTimKiem.Text == "Chuột " && txtTimKiem.Text != "")
            {
                sqlTimKiem = "SELECT * FROM SANPHAM WHERE TenSanPham like '%" + txtTimKiem.Text + "%' AND DanhMuc = '" + danhmucSPTimKiem.Text + "'";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sqlTimKiem);
            }
            if (danhmucSPTimKiem.Text == "Bàn phím" && txtTimKiem.Text != "")
            {
                sqlTimKiem = "SELECT * FROM SANPHAM WHERE TenSanPham like '%" + txtTimKiem.Text + "%' AND DanhMuc = '" + danhmucSPTimKiem.Text + "'";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sqlTimKiem);
            }
            if (danhmucSPTimKiem.Text == "Màn hình" && txtTimKiem.Text != "")
            {
                sqlTimKiem = "SELECT * FROM SANPHAM WHERE TenSanPham like '%" + txtTimKiem.Text + "%' AND DanhMuc = '" + danhmucSPTimKiem.Text + "'";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sqlTimKiem);
            }
            if (danhmucSPTimKiem.Text != "" && txtTimKiem.Text == "")
            {
                sqlTimKiem = "SELECT * FROM SANPHAM WHERE DanhMuc = '" + danhmucSPTimKiem.Text + "'";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sqlTimKiem);
                
            }
            if (danhmucSPTimKiem.Text == "Tất cả" && txtTimKiem.Text == "")
            {
                sqlTimKiem = "SELECT * FROM SANPHAM ";
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sqlTimKiem);
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
    }
}
