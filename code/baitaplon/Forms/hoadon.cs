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
    public partial class hoadon : Form
    {
        Connect cnn = new Connect();
        
        public static string MaNhanVien, TenNhanVien;

        public hoadon()
        {
            InitializeComponent();
        }
        
        private void comboboxload()
        {
            cnn.Ketnoi();
            SqlCommand cmd = new SqlCommand("SELECT TenSanPham, MaSanPham FROM SANPHAM", cnn.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboMaHang.Items.Add(dr["MaSanPham"].ToString());
                comboMaHang.DisplayMember = (dr["MaSanPham"].ToString());
            }
            cnn.Ngatketnoi();
        }

        private void hoadon_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = MaNhanVien;
            txtTenNhanVien.Text = TenNhanVien;
            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            comboboxload();
            
        }

        private void comboMaHang_TextChanged(object sender, EventArgs e)
        {
            cnn.Ketnoi();
            numerSoLuong.Enabled = true;
            SqlCommand cmd = new SqlCommand("select  TenSanPham, DonGia, SoLuong from SANPHAM where MaSanPham = '" + comboMaHang.Text + "'", cnn.cnn);
            SqlDataReader ka = cmd.ExecuteReader();
            while (ka.Read())
            {
                txtTenHang.Text = ka.GetValue(0).ToString();
                txtDonGia.Text = ka.GetValue(1).ToString();
                numerSoLuong.Maximum =Convert.ToInt32(ka.GetValue(2));
            }
            numerSoLuong.Value = 0;
            txtThanhTien.Text = "";
            cnn.Ngatketnoi();
        }

        private void numerSoLuong_ValueChanged(object sender, EventArgs e)
        {
            
                double sl;
                double dg;
                double tt;
                sl = Convert.ToDouble(numerSoLuong.Value);
                dg = Convert.ToDouble(txtDonGia.Text);
                tt = sl * dg;
                txtThanhTien.Text = tt.ToString();
            
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (numerSoLuong.Value != 0)
                {
                    int dem = 0;
                    for (int i = 0; i < dataCTHD.Rows.Count; i++)
                    {
                        if (dataCTHD.Rows[i].Cells[0].Value.ToString() == comboMaHang.Text)
                        {
                            int soluong;
                            soluong = Convert.ToInt32(dataCTHD.Rows[i].Cells[2].Value) + Convert.ToInt32(numerSoLuong.Value);
                            dataCTHD.Rows[i].Cells[2].Value = soluong;
                            dataCTHD.Rows[i].Cells[5].Value = Convert.ToDouble(dataCTHD.Rows[i].Cells[2].Value.ToString()) * Convert.ToDouble(txtDonGia.Text);
                            dem++;
                        }
                    }
                    if (dem == 0)
                    {
                        int n;
                        n = dataCTHD.Rows.Add();
                        dataCTHD.Rows[n].Cells[0].Value = comboMaHang.Text;
                        dataCTHD.Rows[n].Cells[1].Value = txtTenHang.Text;
                        dataCTHD.Rows[n].Cells[2].Value = numerSoLuong.Value;
                        dataCTHD.Rows[n].Cells[3].Value = label11.Text;
                        dataCTHD.Rows[n].Cells[4].Value = txtDonGia.Text;
                        dataCTHD.Rows[n].Cells[5].Value = Convert.ToDouble(txtDonGia.Text) * Convert.ToDouble(numerSoLuong.Value);
                        numerSoLuong.Maximum = numerSoLuong.Maximum - numerSoLuong.Value;
                    }
                    
                }
            }
            catch (Exception)
            {
                HoaDonError hde = new HoaDonError();
                hde.Show();
            }
            
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHoaDon.Text != "" && txtMaKhach.Text != "")
                {
                    double tongtien = 0;
                    int n = dataCTHD.Rows.Count;
                    for (int i = 0; i < n; i++)
                    {
                        tongtien = tongtien + Convert.ToDouble(dataCTHD.Rows[i].Cells[5].Value);
                    }

                    cnn.ThucThiDl("INSERT INTO KHACHHANG VALUES('" + txtMaKhach.Text + "', '" + txtTenKhach.Text + "', '" + txtSDT.Text + "')");
                    cnn.ThucThiDl("INSERT INTO HOADON VALUES('" + txtMaHoaDon.Text + "', '" + txtMaNhanVien.Text + "', '" + dateHoaDon.Value.ToString("yyyy-MM-dd") + "', '" + txtMaKhach.Text + "', '" + tongtien + "')");
                    for (int i = 0; i < n; i++)
                    {
                        cnn.ThucThiDl("INSERT INTO CHITIETHOADON VALUES('" + txtMaHoaDon.Text + "', '" + dataCTHD.Rows[i].Cells[0].Value.ToString() + "', '" + dataCTHD.Rows[i].Cells[2].Value.ToString() + "', '" + dataCTHD.Rows[i].Cells[5].Value.ToString() + "')");
                    }
                    for (int i = 0; i < n; i++)
                    {
                        int kho = Convert.ToInt32(dataCTHD.Rows[i].Cells[3].Value.ToString());
                        int soluong = Convert.ToInt32(dataCTHD.Rows[i].Cells[2].Value.ToString());
                        int soluongconlai = kho - soluong;
                        cnn.ThucThiDl("UPDATE SANPHAM SET SoLuong = '" + soluongconlai + "' WHERE MaSanPham = '" + dataCTHD.Rows[i].Cells[0].Value.ToString() + "'");
                    }
                    Hoadonok ok = new Hoadonok();
                    ok.Show();


                    
                }
                else
                {
                    MessageBox.Show("Điền thiếu thông tin");
                }
            }
            catch (Exception )
            {
                HoaDonError hde = new HoaDonError();
                hde.Show();
            }
                
        }

        private void comboMaHang_SelectedValueChanged(object sender, EventArgs e)
        {  
            label11.Text =cnn.XemDL("select SoLuong from SANPHAM where MaSanPham = '" + comboMaHang.Text + "'").Rows[0][0].ToString();
        }

        private void comboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataCTHD.CurrentRow.Index;
            comboMaHang.Text = dataCTHD.Rows[n].Cells[0].Value.ToString();
            txtTenHang.Text = dataCTHD.Rows[n].Cells[1].Value.ToString();
            numerSoLuong.Value = Convert.ToDecimal(dataCTHD.Rows[n].Cells[2].Value.ToString());
            label11.Text = dataCTHD.Rows[n].Cells[3].Value.ToString();
            txtDonGia.Text = dataCTHD.Rows[n].Cells[4].Value.ToString();
            txtThanhTien.Text = dataCTHD.Rows[n].Cells[5].Value.ToString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            int n = dataCTHD.CurrentRow.Index;
            dataCTHD.Rows.RemoveAt(n);
        }     
    }
}
