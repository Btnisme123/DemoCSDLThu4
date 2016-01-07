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
    public partial class FormThayDoi : Form
    {
        public FormThayDoi()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        EmployeeManagement ep = new EmployeeManagement();
        private void dataCongTac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void FormThayDoi_Load(object sender, EventArgs e)
        {
            dataCongTac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataCongTac.DataSource = ep.LoadThayDoi();
        }
    }
}
