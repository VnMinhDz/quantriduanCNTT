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
    public partial class thongke : Form
    {
        Connect cnn = new Connect();
        
        public thongke()
        {
            InitializeComponent();
        }

        private void rbNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTatCa.Checked)
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedIndex = -1;
            }
            else
            {
                comboBox1.Enabled = true;
                if (rbSanPham.Checked)
                {
                    comboBox1.Items.Clear();
                    cnn.Ketnoi();
                    SqlCommand cmd = new SqlCommand("SELECT  TenSanPham  FROM SANPHAM", cnn.cnn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        comboBox1.Items.Add(dr["TenSanPham"].ToString());
                        comboBox1.DisplayMember = (dr["TenSanPham"].ToString());
                    }
                    cnn.Ngatketnoi();
                }
                else
                {
                    comboBox1.Items.Clear();
                    cnn.Ketnoi();
                    SqlCommand cmd = new SqlCommand("SELECT MaNhanVien, TenNhanVien  FROM NhanVien", cnn.cnn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        comboBox1.Items.Add(dr["TenNhanVien"].ToString());
                        comboBox1.DisplayMember = (dr["TenNhanVien"].ToString());
                        
                    }
                    cnn.Ngatketnoi();
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string sql;
            if (rbTatCa.Checked)
            {
                sql = "SELECT * FROM HOADON where NgayHoaDon >= '" + ngaydau.Value.ToString("yyyy-MM-dd") + "' AND NgayHoaDon <= '" + ngaycuoi.Value.ToString("yyyy-MM-dd") + "'";
                dataHoaDon.DataSource = cnn.XemDL(sql);

            }
            if (rbNhanVien.Checked)
            {
                sql = "SELECT MaHoaDon, NgayHoaDon, MaKhach, TongTien FROM HOADON H INNER JOIN NHANVIEN N ON H.MaNhanVien = N.MaNhanVien WHERE NgayHoaDon >= '" + ngaydau.Value.ToString("yyyy-MM-dd") + "' AND NgayHoaDon <= '" + ngaycuoi.Value.ToString("yyyy-MM-dd") + "' AND TenNhanVien = N'"+comboBox1.Text+"'";
                dataHoaDon.DataSource = cnn.XemDL(sql);
            }
            if (rbSanPham.Checked)
            {
                sql = "SELECT CHITIETHOADON.MaHoaDon, CHITIETHOADON.MaSanPham, CHITIETHOADON.SoLuong, ThanhTien from CHITIETHOADON, HOADON, SANPHAM WHERE CHITIETHOADON.MaHoaDon = HOADON.MaHoaDon AND CHITIETHOADON.MaSanPham = SANPHAM.MaSanPham AND TenSanPham = N'"+comboBox1.Text+"' AND NgayHoaDon >= '" + ngaydau.Value.ToString("yyyy-MM-dd") + "' AND NgayHoaDon <= '" + ngaycuoi.Value.ToString("yyyy-MM-dd") + "'";
                dataHoaDon.DataSource = cnn.XemDL(sql);
            }


            int n = dataHoaDon.RowCount;  //Khai báo biến n = số dòng của datagrid
            if (n == 0)  //Nếu số dòng = 0 thì tổng doanh thu = 0
            {
                txtTongDoanhThu.Text = "0 Đ";
            }
            else
            {
                double tongtien = 0; 
                if (rbTatCa.Checked)
                {
                    for (int i = 0; i < n; i++) // n lúc này đã > 0
                    {
                        tongtien = tongtien + Convert.ToDouble(dataHoaDon.Rows[i].Cells[4].Value.ToString());
                    }
                    txtTongDoanhThu.Text = Convert.ToString(tongtien) + " Đ";
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        tongtien = tongtien + Convert.ToDouble(dataHoaDon.Rows[i].Cells[3].Value.ToString());
                    }
                    txtTongDoanhThu.Text = Convert.ToString(tongtien) + " Đ";
                }
            }
            
        }

        private void thongke_Load(object sender, EventArgs e)
        {

        }

        

        

        

        

        
    }
}
