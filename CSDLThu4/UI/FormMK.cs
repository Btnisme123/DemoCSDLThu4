using CSDLThu4.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLThu4.UI
{
    public partial class FormMK : Form
    {
        public FormMK()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            EmployeeManagement ep = new EmployeeManagement();
            if (ep.ChangePass(Int32.Parse(txtMa.Text), txtMKcu.Text, txtMKmoi.Text))
            {
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo");
            }
        }
    }
}
