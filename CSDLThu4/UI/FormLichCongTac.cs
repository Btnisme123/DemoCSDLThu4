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
    public partial class FormLichCongTac : Form
    {
        public FormLichCongTac()
        {
            InitializeComponent();
        }

        private void btnLichCu_Click(object sender, EventArgs e)
        {

        }

        private void btnLichHienTai_Click(object sender, EventArgs e)
        {
            LichCongTac lich = new LichCongTac();
        }

        private void btnLichSapToi_Click(object sender, EventArgs e)
        {

        }
    }
}
