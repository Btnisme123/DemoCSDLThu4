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
        EmployeeManagement ey = new EmployeeManagement();
        DateTime localDate = DateTime.Now;
        int MaNN;
        string getMaNN;
        private void FormNNQuanLi_Load(object sender, EventArgs e)
        {
            gridViewNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ey.LoadCTintoCombo(comboCT);
            showDuLieuNV();
        }
        public void showDuLieuNV()
        {
            gridViewNV.Rows.Clear();

            DataTable dt = ey.LoadNV();
            foreach (DataRow d in dt.Rows)
            {
                int n = gridViewNV.Rows.Add();
                gridViewNV.Rows[n].Cells[0].Value = false;
                gridViewNV.Rows[n].Cells[1].Value = d["MaNhanVien"].ToString();
                gridViewNV.Rows[n].Cells[2].Value = d["HoTen"].ToString();
                gridViewNV.Rows[n].Cells[3].Value = d["ID"].ToString();
                gridViewNV.Rows[n].Cells[4].Value = d["GioiTinh"].ToString();
                gridViewNV.Rows[n].Cells[5].Value = d["MaCapQuanLi"].ToString();
                gridViewNV.Rows[n].Cells[6].Value = d["MaNguoiQuanLi"].ToString();

            }
            gridViewNV.Refresh();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            getMaNN = ey.insertNhacNho(localDate, txtTieuDe.Text, txtNoiDung.Text, Convert.ToInt32(comboCT.Text));
            MaNN = Convert.ToInt32(getMaNN);
        }

        
    }
}
