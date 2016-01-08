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
    public partial class FormNNQuanLi : Form
    {
        public FormNNQuanLi()
        {
            InitializeComponent();
        }

        private void FormNNQuanLi_Load(object sender, EventArgs e)
        {
            EmployeeManagement ey = new EmployeeManagement();
            ey.LoadCTintoCombo(comboCT);
        }
    }
}
