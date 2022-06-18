using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.IO;

namespace baitaplon
{   
    public partial class Form1 : Form
    {
        Connect cnn = new Connect();
        public static string Quyen, TenNhanVien, MaNhanVien;
        private IconButton currentBtn;
        private Panel lefBorderBtn;
        private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
            lefBorderBtn = new Panel();
            lefBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(lefBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            
        }
        
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(0, 150, 136);
            public static Color color4 = Color.FromArgb(159, 41, 41);
            public static Color color5 = Color.FromArgb(20, 120, 218);
            public static Color color6 = Color.FromArgb(255, 102, 51);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                lefBorderBtn.BackColor = color;
                lefBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                lefBorderBtn.Visible = true;
                lefBorderBtn.BringToFront();
                
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {   //chimo1form
                currentChildForm.Close();
            }
            
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            lblTitleForm.Text = "Trang chủ";
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.sanpham());
            lblTitleForm.Text = "Sản phẩm";
            
            
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            if (Quyen == "Admin")
            {

            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Forms.nhanvien());
            lblTitleForm.Text = "Nhân viên";
            }
            else
            {
                ChuLogin cl = new ChuLogin();
                cl.Show();
            }

           
            
         
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Forms.hoadon());
            lblTitleForm.Text = "Hóa đơn";
            
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();

        }
        private void Reset()
        {
            DisableButton();
            lefBorderBtn.Visible = false;
            lblTitleForm.Text = "Trang chủ";
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox1_MouseHover(object sender, EventArgs e)
        {
            iconPictureBox1.BackColor = Color.Red;
        }

        private void iconPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox1.BackColor = Color.FromArgb(26, 25, 62);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Forms.thongke());
            lblTitleForm.Text = "Thống kê";
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Forms.khachhang());
            lblTitleForm.Text = "Khách hàng";
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);
            lbTenNhanVien.Text = TenNhanVien;
            if (bt != "")
            {
                picAvatar.Image = ByteToImg(bt);
            }
            
        }

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
            
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.Show();
            panel2.Visible = false;
        }
        string a = " ";
        public static string bt = " ";
        byte[] converImgToByte()// chuyen sang byte
        {
            FileStream fs;
            fs = new FileStream(a, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        Image ByteToImg(string byteString) // chuyen hinh anh
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private void btnDoiAvatar_Click(object sender, EventArgs e)
        {   
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            opf.Multiselect = true;
            if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                a = opf.FileName;
                bt = Convert.ToBase64String(converImgToByte());
                picAvatar.Image = ByteToImg(bt);
            }
            string sqlDoiAvatar = "UPDATE NHANVIEN SET Avatar = '" + bt + "' WHERE MaNhanVien = '"+MaNhanVien+"'";
            cnn.ThucThiDl(sqlDoiAvatar);
            panel2.Visible = false;
                }
            catch (Exception)
            {
                MessageBox.Show("Loi roi");
            }
            
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        

        

        

        
    }
}
