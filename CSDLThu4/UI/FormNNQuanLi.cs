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
        int MaNN=0;
        string getMaNN;
        private void FormNNQuanLi_Load(object sender, EventArgs e)
        {
            gridViewNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewNN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ey.LoadCTintoCombo(comboCT);
            showDuLieuNV();
            showDuLieuNN();
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
        public void showDuLieuNN()
        {
            gridViewNN.Rows.Clear();

            DataTable dt = ey.LoaddataNN(EmployeeManagement.UserID);
            foreach (DataRow d in dt.Rows)
            {
                int n = gridViewNN.Rows.Add();
                gridViewNN.Rows[n].Cells[0].Value = d["MaNhacNho"].ToString();
                gridViewNN.Rows[n].Cells[1].Value = d["NgayNhac"].ToString();
                gridViewNN.Rows[n].Cells[2].Value = d["TenNhacNho"].ToString();
                gridViewNN.Rows[n].Cells[3].Value = d["NoiDung"].ToString();
                gridViewNN.Rows[n].Cells[4].Value = d["MaCongTac"].ToString();
                gridViewNN.Rows[n].Cells[5].Value = d["NguoiGui"].ToString();

            }
            gridViewNN.Refresh();
           // labelTest.Text = EmployeeManagement.UserID;
        }
        private void btnGui_Click(object sender, EventArgs e)
        {
            try
            {
                getMaNN = ey.insertNhacNho(localDate, txtTieuDe.Text, txtNoiDung.Text, Convert.ToInt32(comboCT.Text));
                MaNN = Convert.ToInt32(getMaNN);
                foreach (DataGridViewRow item in gridViewNV.Rows)
                {
                    if (bool.Parse(item.Cells[0].Value.ToString()))
                    {

                        ey.insertNV_NN(Int32.Parse(item.Cells[1].Value.ToString()), MaNN);

                    }

                }
            }catch(Exception ex){
                MessageBox.Show("Dữ liệu bị lỗi , hãy nhập lại","Thông báo");
            }
           
        }
        private void gridViewNN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridViewNN.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString()!=null)
            {
                MaNN = Convert.ToInt32(gridViewNN.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString());
                //label4.Text = EmployeeManagement.MaNV.ToString() + "   " + gridViewNN.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Chưa click vào h", "Thông báo");
            }
           


        }

        private void btnPhanHoi_Click(object sender, EventArgs e)
        { if(txtPH.Text.CompareTo("")==0){
                MessageBox.Show("Bạn chưa nhập nội dung phản hồi","Thông báo");
            }
            else
            {
                ey.GuiPhanHoi(MaNN,txtPH.Text);
               showDuLieuNN();
                //label4.Text = EmployeeManagement.MaNV.ToString() + "   " + gridViewNN.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                //gridViewNN.Rows.Clear();
            }
            
        }

      

        private void gridViewNN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNhacNhoNhieuLan_Click(object sender, EventArgs e)
        {
            FormCapPhanHoi fr = new FormCapPhanHoi();
            fr.ShowDialog();
        }

        
    }
}
