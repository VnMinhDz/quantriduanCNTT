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
    public partial class HoaDonError : Form
    {
        public HoaDonError()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HoaDonError_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);
        }
    }
}
