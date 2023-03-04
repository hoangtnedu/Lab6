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
   
    public partial class frmHienThi : Form
    {
        Hang hang;
        public frmHienThi()
        {
            InitializeComponent();
        }
        public frmHienThi(Hang h)
        {
            
            InitializeComponent();
            hang = h;
        }

        private void frmHienThi_Load(object sender, EventArgs e)
        {
            txtDiaChi.Text = hang.DiaChi;
            txtTenHang.Text = hang.TenHang;
            txtTenNCC.Text = hang.TenNhaCC;
        }
    }
}
