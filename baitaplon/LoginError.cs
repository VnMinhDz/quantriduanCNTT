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
    public partial class LoginError : Form
    {
        public LoginError()
        {
            InitializeComponent();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoginError_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);
        }
    }
}
