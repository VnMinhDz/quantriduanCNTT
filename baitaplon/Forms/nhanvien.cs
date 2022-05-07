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
using System.Globalization;
using System.IO;

namespace baitaplon.Forms
{
    public partial class nhanvien : Form
    {
        Connect cnn = new Connect();   //Khai báo biến cnn kiểu Connect
        
        public nhanvien()
        {
            InitializeComponent();
        }

        private void nhanvien_Load(object sender, EventArgs e)
        {

            string sql = "select MaNhanVien, TenNhanVien, convert(varchar, NgaySinh, 103) as NgaySinh, GioiTinh, TenDangNhap, MatKhau, Quyen  from NHANVIEN"; //Câu lệnh convert của ngày sinh chuyển ngày sinh về dạng dd/yy/MMMM
            bunifuCustomDataGrid1.DataSource = cnn.XemDL(sql);  //Hiển thị tất cả nhân viên xuống datagridview (cnn.xemdl sẽ trả về là 1 cái datatable)
        }
        
       
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "")  //Nếu ô mã nhân viên khác rỗng thì nút thêm mới có tác dụng
            {
                try  // Đặt trong vòng try để bắt lỗi
                {
                    string sex; //Khai báo biến sex
                    if (radioNam.Checked == true)   // Nếu ô Nam được tích thì sex = Nam
                    {
                        sex = "Nam";
                    }
                    else // Ngược lại thì sex = nữ
                    {
                        sex = "Nữ";
                    }
                    //UPDATE, INSERT, DELETE dùng hàm THUCTHIDL
                    string sqlINSERT = "insert into NHANVIEN (MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, TenDangNhap, MatKhau, Quyen)  values('" + txtMaNV.Text + "', N'" + txtTenNV.Text + "', '" + bunifuDatepicker1.Value.ToString("yyyy-MM-dd") + "', N'" + sex + "', N'" + txtTenDangNhap.Text + "', '" + txtMatKhau.Text + "', '"+comboQuyen.Text+"')";
                    cnn.ThucThiDl(sqlINSERT);
                    //HÀm select dùng hàm XEMDL
                    string sql = "select MaNhanVien, TenNhanVien, convert(varchar, NgaySinh, 103) as NgaySinh, GioiTinh, TenDangNhap, MatKhau, Quyen  from NHANVIEN";
                    bunifuCustomDataGrid1.DataSource = cnn.XemDL(sql);
                    
                }
                catch (Exception)
                {
                    NhanVienError nve = new NhanVienError(); //Nếu lỗi thì khai báo biến nve kiểu Nhanvieneror(NhanvienError là 1 cái form)
                    nve.Show();  //Hiển thị nve lên
                }
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int n;  // Khai báo biến n
            txtMaNV.Enabled = false; // Cho ô mã nhân viên = false
            n = bunifuCustomDataGrid1.CurrentRow.Index; // n = số dòng mà con trỏ chuột đang chỉ đến
            txtMaNV.Text = bunifuCustomDataGrid1.Rows[n].Cells[0].Value.ToString(); // ô mã nhân viên = cell 0 ở hàng n
            txtTenNV.Text = bunifuCustomDataGrid1.Rows[n].Cells[1].Value.ToString(); // ô tên nhân viên = cell 1 ở hàng n
            DateTime dt = DateTime.ParseExact(bunifuCustomDataGrid1.Rows[n].Cells[2].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture); // chuyển đổi cell 2 về định dạng ngày
            bunifuDatepicker1.Value = dt;
            if (bunifuCustomDataGrid1.Rows[n].Cells[3].Value.ToString() == "Nam") // nếu cell 3 là Nam thì ô Radio nam được tích
            {
                radioNam.Checked = true;
            }
            else // Ngược lại thì ô nữ được tichs
            {
                radioNu.Checked = true;
            }
            txtTenDangNhap.Text = bunifuCustomDataGrid1.Rows[n].Cells[4].Value.ToString(); //Tương tự
            txtMatKhau.Text = bunifuCustomDataGrid1.Rows[n].Cells[5].Value.ToString();
            comboQuyen.Text = bunifuCustomDataGrid1.Rows[n].Cells[6].Value.ToString();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try// Đặt trong vòng try để bắt lỗi
            {
                string sqlDELETE = "DELETE FROM NHANVIEN WHERE MaNhanVien = '" + txtMaNV.Text + "'";  //Xóa nhân viên, điều kiện là mã nhân viên = với mã nhân viên ở textbox
                cnn.ThucThiDl(sqlDELETE);  // Thực thi câu lệnh xóa
                string sql = "select MaNhanVien, TenNhanVien, convert(varchar, NgaySinh, 103) as NgaySinh, GioiTinh, TenDangNhap, MatKhau, Quyen  from NHANVIEN"; //Câu lệnh hiển thị tất cả nhất viên
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sql); // Hiển thị nhân viên xuống datagridview
                
            }
            catch (Exception)
            {
                NhanVienError nve = new NhanVienError(); //Nếu lỗi thì khai báo biến nve kiểu Nhanvieneror(NhanvienError là 1 cái form)
                nve.Show();  //Hiển thị nve lên
            }
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try// Đặt trong vòng try để bắt lỗi
            {
                string sex; //Khai báo biến sex
                if (radioNam.Checked == true)  // Nếu ô radioNam được đánh dấu thì sex = Nam
                {
                    sex = "Nam";
                }
                else // Ngược lại thì sex = Nữ
                {
                    sex = "Nữ";
                }
                string sqlUPDATE = "UPDATE NHANVIEN SET TenNhanVien = N'" + txtTenNV.Text + "', GioiTinh = N'" + sex + "', TenDangNhap = N'" + txtTenDangNhap.Text + "', MatKhau = '" + txtMatKhau.Text + "', NgaySinh = '" + bunifuDatepicker1.Value.ToString("yyyy-MM-dd") + "', Quyen = '" + comboQuyen.Text + "'  WHERE MaNhanVien = '" + txtMaNV.Text + "' "; // Câu lẹnh update điều kiện Mã nhân viên = mã nhân vieine ở ô textbox
                cnn.ThucThiDl(sqlUPDATE); // Thực thi câu lệnh
                string sql = "select MaNhanVien, TenNhanVien, convert(varchar, NgaySinh, 103) as NgaySinh, GioiTinh, TenDangNhap, MatKhau, Quyen  from NHANVIEN"; //Câu lệnh hiển thị tất cả nhân viên
                bunifuCustomDataGrid1.DataSource = cnn.XemDL(sql); // Hiển thị nhân viên xuống datagridview
                
            }
            catch (Exception)
            {
                NhanVienError nve = new NhanVienError();//Nếu lỗi thì khai báo biến nve kiểu Nhanvieneror(NhanvienError là 1 cái form)
                nve.Show(); //Hiển thị nve lên
            }
            
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = true; //Cho ô text Mã nhân = enable
            txtMaNV.Text = ""; // Cho ô text mã nhân viên = rỗng
            txtTenNV.Text = ""; // Cho ô text tên nhân viên = rỗng
            radioNam.Checked = false; //Bỏ tích ô radioNam
            radioNu.Checked = false; // Bỏ tích ô radio Nữ
            txtTenDangNhap.Text = ""; // Cho ô text tên đăng nhập = rỗng
            txtMatKhau.Text = "";// Cho ô text tên mk = rỗng
            comboQuyen.Text = "";// Cho ô text tên quyền = rỗng
        }
        
        
        
    }
}
