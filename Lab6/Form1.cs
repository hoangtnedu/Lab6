using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Hang h = new Hang(txtTenHang.Text,txtTenNCC.Text,txtDiaChi.Text);
            frmHienThi frm = new frmHienThi(h);
        }
    }
}
