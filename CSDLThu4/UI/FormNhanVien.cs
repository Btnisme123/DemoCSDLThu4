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
using System.Text.RegularExpressions;

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
            txtDiaChi.Visible = false;
            txtHoTen.Visible = false;
            txtSDT.Visible = false;
            btnXacNhan.Visible = false;
            comboGT.Visible = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Hoten,SDT,DiaChi,GioiTinh 
            EmployeeManagement employee = new EmployeeManagement();
            DataTable tb= employee.LoaddataNV(EmployeeManagement.UserID);

            //btnNhacNho.Text = EmployeeManagement.UserID;
          
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            txtDiaChi.Visible = true;
            txtHoTen.Visible = true;
            txtSDT.Visible = true;
            btnXacNhan.Visible = true;
            comboGT.Visible = true;

         

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string[] getTT = new string[4];
                getTT[0] = txtHoTen.Text;
               getTT[1] = txtDiaChi.Text;      
               getTT[2] = txtSDT.Text;
                getTT[3] = comboGT.Text;
                int check = 1;
                if (Regex.Matches(getTT[2], @"[a-zA-Z]").Count == 1)
                {
                    MessageBox.Show("Số điện thoại không có chữ cái");
                    check = 0;
                   
                }

                if (Regex.Matches(getTT[0], @"[0-9]+").Count == 1)
                {
                    MessageBox.Show("Tên không có kí tự số");
                    check = 0;
                }
            for (int i = 0; i < 4; i++)
            {
                if (getTT[i].Equals("") == true)
                {
                    MessageBox.Show("Không được để trống");
                    check = 0;
                    break;
                }
                if(check==1){
                    EmployeeManagement employ = new EmployeeManagement();

                    employ.UpdatedataNV(EmployeeManagement.UserID, getTT[0], getTT[1], getTT[2], getTT[3]);
                    MessageBox.Show("Cập nhật thành công");
                    break;

                }
                //UpdatedataNV
               
            }

        }

        private void btnCongTac_Click(object sender, EventArgs e)
        {
            frmLichCongTac lich = new frmLichCongTac();
            lich.ShowDialog(); 
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            FormMK mk = new FormMK();
            mk.ShowDialog();
        }

        private void btnNhacNho_Click(object sender, EventArgs e)
        {
            FormNNQuanLi fr = new FormNNQuanLi();
            fr.ShowDialog();
        }

    }
}
