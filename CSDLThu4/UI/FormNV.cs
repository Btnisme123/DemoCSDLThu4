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
        EmployeeManagement ey = new EmployeeManagement();
        private void FormNV_Load(object sender, EventArgs e)
        {
            gridViewNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ey.LoadNVintoCombo(comboMaQl);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //int n=0, count=0;
           
            foreach (DataGridViewRow item in gridViewNV.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    // EmployeeManagement.MaCT
                    ey.insertNV_CT(Int32.Parse(item.Cells[1].Value.ToString()), Int32.Parse(getMa));
        
                }
               //aa
            }/*
            foreach (DataGridViewRow item in gridViewNV.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    count++;
                }

            }
             if (n==count)
                    {
                        MessageBox.Show("Thêm vào thành công !", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông báo");
                    }
                 labelTest1.Text = n.ToString();
             labelTest2.Text = count.ToString();
              */

        }
        public void show()
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
        private void btnShow_Click(object sender, EventArgs e)
        {
            show();
          
            //label.Text = EmployeeManagement.MaCT.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {/*
           
            */
           
            List<MaQuanLi> listNQL = new List<MaQuanLi>();
            ey.PassData(listNQL);
            string getMaQL, getMaNQL;
            int MaQL=0, MaNQL=0;

            getMaQL= comboMaQl.Text.ToString();
           getMaNQL= comboCapQL.Text.ToString();
            /*
           for (int i = 0; i < listNQL.Count; i++)
           {
               if (listNQL[i].tenQL.CompareTo(getMaNQL) == 0)
               {
                   MaNQL =listNQL[i].maQL;
               }
           }
           */
            
             switch(getMaQL){
                       case "Cấp 1":
                     MaQL = 1;
                           break;
                       case "Cấp 2":
                           MaQL = 2;
                           break;
                      case "Cấp 3":
                           MaQL = 3;
                          break;

             }
         
             ey.InsertdataNV(txtId.Text.ToString(), txtPASS.Text.ToString(),
                       txtHoTen.Text.ToString(), txtSDT.Text.ToString(),
                          txtDiaChi.Text.ToString(), comboGT.Text.ToString(), txtEmail.Text.ToString(),
                          Int32.Parse(comboMaQl.Text), MaNQL);
            show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           // ey.DeletedataNV(Convert.ToInt32(labelSelect.Text));
        }

        private void gridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //labelSelect.Text = gridViewNV.CurrentRow.Cells["Column2"].Value.ToString();
            //show();
        }
        /*
        private void gridViewNV_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (gridViewNV.IsCurrentCellDirty)
            {
                gridViewNV.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void gridViewNV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int num=0;
            bool isChecked = Convert.ToBoolean(gridViewNV.Rows[gridViewNV.CurrentCell.RowIndex].Cells[0].Value.ToString());

            if (isChecked)
            {
                num += 1;
            }
            else
            {
                num -= 1;
            }

            labelTest1.Text = "Selected Items: " + num;
        }
         */
       
    }
}
