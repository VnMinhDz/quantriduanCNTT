namespace baitaplon.Forms
{
    partial class thongke
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thongke));
            this.dataHoaDon = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ngaydau = new Bunifu.Framework.UI.BunifuDatepicker();
            this.ngaycuoi = new Bunifu.Framework.UI.BunifuDatepicker();
            this.rbTatCa = new System.Windows.Forms.RadioButton();
            this.rbSanPham = new System.Windows.Forms.RadioButton();
            this.rbNhanVien = new System.Windows.Forms.RadioButton();
            this.btnThongKe = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongDoanhThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHoaDon
            // 
            this.dataHoaDon.AllowUserToAddRows = false;
            this.dataHoaDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dataHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataHoaDon.ColumnHeadersHeight = 50;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataHoaDon.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataHoaDon.DoubleBuffered = true;
            this.dataHoaDon.EnableHeadersVisualStyles = false;
            this.dataHoaDon.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.dataHoaDon.HeaderForeColor = System.Drawing.Color.White;
            this.dataHoaDon.Location = new System.Drawing.Point(61, 182);
            this.dataHoaDon.Name = "dataHoaDon";
            this.dataHoaDon.ReadOnly = true;
            this.dataHoaDon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataHoaDon.RowHeadersVisible = false;
            this.dataHoaDon.RowTemplate.DividerHeight = 1;
            this.dataHoaDon.RowTemplate.Height = 40;
            this.dataHoaDon.RowTemplate.ReadOnly = true;
            this.dataHoaDon.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHoaDon.Size = new System.Drawing.Size(939, 300);
            this.dataHoaDon.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(371, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 86;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(721, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 87;
            this.label2.Text = "Tới ngày";
            // 
            // ngaydau
            // 
            this.ngaydau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.ngaydau.BorderRadius = 0;
            this.ngaydau.ForeColor = System.Drawing.Color.White;
            this.ngaydau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaydau.FormatCustom = "dd/MM/yyyy";
            this.ngaydau.Location = new System.Drawing.Point(483, 43);
            this.ngaydau.Name = "ngaydau";
            this.ngaydau.Size = new System.Drawing.Size(191, 36);
            this.ngaydau.TabIndex = 88;
            this.ngaydau.Value = new System.DateTime(2021, 6, 10, 23, 18, 34, 928);
            // 
            // ngaycuoi
            // 
            this.ngaycuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.ngaycuoi.BorderRadius = 0;
            this.ngaycuoi.ForeColor = System.Drawing.Color.White;
            this.ngaycuoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaycuoi.FormatCustom = "dd/MM/yyyy";
            this.ngaycuoi.Location = new System.Drawing.Point(827, 43);
            this.ngaycuoi.Name = "ngaycuoi";
            this.ngaycuoi.Size = new System.Drawing.Size(173, 36);
            this.ngaycuoi.TabIndex = 89;
            this.ngaycuoi.Value = new System.DateTime(2021, 6, 10, 23, 18, 34, 928);
            // 
            // rbTatCa
            // 
            this.rbTatCa.AutoSize = true;
            this.rbTatCa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTatCa.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbTatCa.Location = new System.Drawing.Point(401, 126);
            this.rbTatCa.Margin = new System.Windows.Forms.Padding(2);
            this.rbTatCa.Name = "rbTatCa";
            this.rbTatCa.Size = new System.Drawing.Size(68, 25);
            this.rbTatCa.TabIndex = 90;
            this.rbTatCa.TabStop = true;
            this.rbTatCa.Text = "Tất cả";
            this.rbTatCa.UseVisualStyleBackColor = true;
            this.rbTatCa.CheckedChanged += new System.EventHandler(this.rbNhanVien_CheckedChanged);
            // 
            // rbSanPham
            // 
            this.rbSanPham.AutoSize = true;
            this.rbSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSanPham.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbSanPham.Location = new System.Drawing.Point(483, 126);
            this.rbSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.rbSanPham.Name = "rbSanPham";
            this.rbSanPham.Size = new System.Drawing.Size(98, 25);
            this.rbSanPham.TabIndex = 91;
            this.rbSanPham.TabStop = true;
            this.rbSanPham.Text = "Sản phẩm";
            this.rbSanPham.UseVisualStyleBackColor = true;
            this.rbSanPham.CheckedChanged += new System.EventHandler(this.rbNhanVien_CheckedChanged);
            // 
            // rbNhanVien
            // 
            this.rbNhanVien.AutoSize = true;
            this.rbNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNhanVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbNhanVien.Location = new System.Drawing.Point(585, 126);
            this.rbNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.rbNhanVien.Name = "rbNhanVien";
            this.rbNhanVien.Size = new System.Drawing.Size(99, 25);
            this.rbNhanVien.TabIndex = 92;
            this.rbNhanVien.TabStop = true;
            this.rbNhanVien.Text = "Nhân viên";
            this.rbNhanVien.UseVisualStyleBackColor = true;
            this.rbNhanVien.CheckedChanged += new System.EventHandler(this.rbNhanVien_CheckedChanged);
            // 
            // btnThongKe
            // 
            this.btnThongKe.ActiveBorderThickness = 1;
            this.btnThongKe.ActiveCornerRadius = 20;
            this.btnThongKe.ActiveFillColor = System.Drawing.Color.White;
            this.btnThongKe.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnThongKe.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnThongKe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThongKe.BackgroundImage")));
            this.btnThongKe.ButtonText = "Thống kê";
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThongKe.IdleBorderThickness = 1;
            this.btnThongKe.IdleCornerRadius = 20;
            this.btnThongKe.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.btnThongKe.IdleForecolor = System.Drawing.Color.White;
            this.btnThongKe.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.btnThongKe.Location = new System.Drawing.Point(893, 110);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(5);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(107, 41);
            this.btnThongKe.TabIndex = 94;
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(725, 126);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(760, 532);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 97;
            this.label3.Text = "Tổng danh thu: ";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.AutoSize = true;
            this.txtTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongDoanhThu.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTongDoanhThu.Location = new System.Drawing.Point(882, 532);
            this.txtTongDoanhThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(0, 21);
            this.txtTongDoanhThu.TabIndex = 98;
            // 
            // thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1111, 593);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.rbNhanVien);
            this.Controls.Add(this.rbSanPham);
            this.Controls.Add(this.rbTatCa);
            this.Controls.Add(this.ngaycuoi);
            this.Controls.Add(this.ngaydau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataHoaDon);
            this.Name = "thongke";
            this.Text = "thongke";
            this.Load += new System.EventHandler(this.thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker ngaydau;
        private Bunifu.Framework.UI.BunifuDatepicker ngaycuoi;
        private System.Windows.Forms.RadioButton rbTatCa;
        private System.Windows.Forms.RadioButton rbSanPham;
        private System.Windows.Forms.RadioButton rbNhanVien;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThongKe;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTongDoanhThu;

    }
}