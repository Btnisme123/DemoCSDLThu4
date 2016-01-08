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
    public partial class FormNV : Form
    {
        public FormNV()
        {
            InitializeComponent();
        }
        public String getMa;
        private void FormNV_Load(object sender, EventArgs e)
        {
            gridViewNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EmployeeManagement ey = new EmployeeManagement();
            foreach (DataGridViewRow item in gridViewNV.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    // EmployeeManagement.MaCT
                    if (ey.insertNV_CT(Int32.Parse(item.Cells[1].Value.ToString()), Int32.Parse(getMa)))
                    {
                        MessageBox.Show("Sửa  thành công !", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông báo");
                    }
                        
                }
               
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            EmployeeManagement ey = new EmployeeManagement();
            DataTable dt = ey.LoadNV();
            foreach (DataRow d in dt.Rows)
            {
                int n = gridViewNV.Rows.Add();
                gridViewNV.Rows[n].Cells[0].Value = false;
                gridViewNV.Rows[n].Cells[1].Value = d["MaNhanVien"].ToString();
                gridViewNV.Rows[n].Cells[2].Value = d["HoTen"].ToString();
                gridViewNV.Rows[n].Cells[3].Value = d["DiaChi"].ToString();
                gridViewNV.Rows[n].Cells[4].Value = d["GioiTinh"].ToString();
            }
            //label.Text = EmployeeManagement.MaCT.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
