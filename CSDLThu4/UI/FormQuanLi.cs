using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSDLThu4.Object;
using CSDLThu4.UI;
using CSDLThu4.Connection;

namespace CSDLThu4.UI
{
    public partial class frmQuanLi : Form
    {
        public frmQuanLi()
        {
            InitializeComponent();
        }

        private void frmQuanLi_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemCongTac fr = new FormThemCongTac();
            fr.Show();
        }
    }
}
