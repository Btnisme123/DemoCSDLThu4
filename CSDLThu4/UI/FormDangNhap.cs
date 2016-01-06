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

namespace CSDLThu4
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            DBConnect cn = new DBConnect();
            string txtID = txtId.Text;
            string txtPass = txtPASS.Text;
            EmployeeManagement employee = new EmployeeManagement();
            cn.conn.Open();
            if (employee.CheckLogin(txtID, txtPass) == 3)
            {
                frmNhanVien NV = new frmNhanVien();
                NV.Show();
            }
            else if (employee.CheckLogin(txtID, txtPass) == 0)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
            else
            {
                frmQuanLi QL = new frmQuanLi();
                QL.Show();
            }
            cn.conn.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
