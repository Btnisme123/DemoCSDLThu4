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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
          
            EmployeeManagement employee = new EmployeeManagement();
            DataTable tb= employee.LoaddataNV(EmployeeManagement.UserID);

            //btnNhacNho.Text = EmployeeManagement.UserID;
          
        }

    }
}
