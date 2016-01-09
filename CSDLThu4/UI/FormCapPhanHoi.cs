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
    public partial class FormCapPhanHoi : Form
    {
        public FormCapPhanHoi()
        {
            InitializeComponent();
        }
        EmployeeManagement ey = new EmployeeManagement();
        int MaNV, CapDoPH,MaNQL;
        private void FormCapPhanHoi_Load(object sender, EventArgs e)
        {
            gridViewNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                showDuLieuNV();
        }

        public void showDuLieuNV()
        {
            gridViewNV.Rows.Clear();

            DataTable dt = ey.LoadNVCanPH();
            foreach (DataRow d in dt.Rows)
            {
                int n = gridViewNV.Rows.Add();
                gridViewNV.Rows[n].Cells[0].Value = false;
                gridViewNV.Rows[n].Cells[1].Value = d["MaNhanVien"].ToString();
                gridViewNV.Rows[n].Cells[2].Value = d["ID"].ToString();
                gridViewNV.Rows[n].Cells[3].Value = d["MaCapQuanLi"].ToString();
                gridViewNV.Rows[n].Cells[4].Value = d["MaNguoiQuanLi"].ToString();
                gridViewNV.Rows[n].Cells[5].Value = d["CapDoNhac"].ToString();

            }
            gridViewNV.Refresh();

        }
        private void gridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaNV = Convert.ToInt32(gridViewNV.CurrentRow.Cells["Column2"].Value.ToString());
           

            // show();
        }
        private void btnNhacLan1_Click(object sender, EventArgs e)
        {
            /*
            foreach (DataGridViewRow item in gridViewNV.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {

                }
            }
             * */

            ey.UpdateNVCanPH(MaNV);
            if (CapDoPH ==2)
            {
                string getMa = ey.ThongbaoNVCanPH(MaNV);
                int Ma = Convert.ToInt32(getMa);
                ey.insertNV_NN(MaNQL, Ma);
            }
            else if (CapDoPH>2)
            {
                string getMa = ey.ThongbaoNVCanPH(MaNV);
                int Ma = Convert.ToInt32(getMa);
                ey.insertNV_NN(2, Ma);
            }
            
            showDuLieuNV();
            
        }

        private void gridViewNV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MaNV = Convert.ToInt32(gridViewNV.CurrentRow.Cells["Column2"].Value.ToString());
            CapDoPH = Convert.ToInt32(gridViewNV.CurrentRow.Cells["Column3"].Value.ToString());
            MaNQL=Convert.ToInt32(gridViewNV.CurrentRow.Cells["Column7"].Value.ToString());
            //labelHang.Text = "Ma la : " + MaNV.ToString() + "Cap do la:" + CapDoPH.ToString()+"MaQL : "+MaNQL.ToString();
            //labelHang.Text = "Hàng : "+ MaNV.ToString();
        }
    }
}
