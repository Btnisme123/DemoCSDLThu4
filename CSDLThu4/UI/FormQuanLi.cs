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
    public partial class frmQuanLi : Form
    {
        public frmQuanLi()
        {
            InitializeComponent();
        }
        EmployeeManagement em = new EmployeeManagement();
        DateTime localDate = DateTime.Now;
        private void frmQuanLi_Load(object sender, EventArgs e)
        {
            //dataCongTac.SelectAll = true;
            dataCongTac.Update();
            dataCongTac.Refresh();
            dataCongTac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataCongTac.DataSource = em.LoadDataLich();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //FormThemCongTac fr = new FormThemCongTac();
            //fr.Show();
            if (dateTimeNgayBD.Value.CompareTo(dateTimeNgayKT.Value) > 0)
            {
                MessageBox.Show("Thời gian bị sai!", "Thông báo");
            }
            else if (txtTenCT.Text.CompareTo("") == 0 || txtNoiDung.Text.CompareTo("") == 0 || txtDiaDiem.Text.CompareTo("") == 0 || comboLoaiCT.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Thiếu dữ liệu!", "Thông báo");
            }
            else
            {
                
                LichCongTac a = new LichCongTac(txtTenCT.Text, dateTimeNgayBD.Value, dateTimeNgayKT.Value, txtDiaDiem.Text, txtNoiDung.Text);
                switch (comboLoaiCT.Text)
                {
                    case "Công tác mức 1":
                        a.LoaiCT = 1;
                        break;
                    case "Công tác mức 2":
                        a.LoaiCT = 2;
                        break;
                    case "Công tác mức 3":
                        a.LoaiCT = 3;
                        break;
                }
                //Công tác mức 1
                //Công tác mức 2
                //Công tác mức 3
              
                DialogResult dialogResult = MessageBox.Show("Hãy xác nhận là bạn muốn thêm", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                    if (em.ThemCongTac(a.TenCongTac, a.Ngaybatdau, a.Ngayketthuc, a.DiaDiem, a.NoiDung, a.LoaiCT))
                    {
                        
                        MessageBox.Show("Thêm  thành công !", "Thông báo");
                        em.ThayDoi(localDate, "Thêm mới Thông tin", EmployeeManagement.UserID, a.TenCongTac);
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công !", "Thông báo");
                    };
                }
                dataCongTac.DataSource = em.LoadDataLich();
                dataCongTac.Update();
                dataCongTac.Refresh();
              
            }
        }

        private void dataCongTac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenCT.Text=dataCongTac.CurrentRow.Cells["TenCongTac"].Value.ToString();
            txtDiaDiem.Text = dataCongTac.CurrentRow.Cells["DiaDiem"].Value.ToString();
            txtNoiDung.Text = dataCongTac.CurrentRow.Cells["NoiDung"].Value.ToString();
            EmployeeManagement.MaCT = Convert.ToInt32(dataCongTac.CurrentRow.Cells["MaCongTac"].Value.ToString());
            labelSelect.Text = dataCongTac.CurrentRow.Cells["MaCongTac"].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataCongTac.CurrentRow.Cells["MaCongTac"].Value.ToString());
            LichCongTac a = new LichCongTac(txtTenCT.Text, dateTimeNgayBD.Value, dateTimeNgayKT.Value, txtDiaDiem.Text, txtNoiDung.Text);
            DialogResult dialogResult = MessageBox.Show("Hãy xác nhận là bạn muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (em.SuaCongTac(id, a.TenCongTac, a.Ngaybatdau, a.Ngayketthuc, a.DiaDiem, a.NoiDung, a.LoaiCT))
                {

                    MessageBox.Show("Sửa  thành công !", "Thông báo");
                    em.ThayDoi(localDate, "Cập nhật Thông tin", EmployeeManagement.UserID, a.TenCongTac);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công !", "Thông báo");
                };
            }
            dataCongTac.DataSource = em.LoadDataLich();
                  dataCongTac.Update();
                    dataCongTac.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
                 int id = Convert.ToInt32(dataCongTac.CurrentRow.Cells["MaCongTac"].Value.ToString());
            LichCongTac a = new LichCongTac(txtTenCT.Text, dateTimeNgayBD.Value, dateTimeNgayKT.Value, txtDiaDiem.Text, txtNoiDung.Text);
            DialogResult dialogResult = MessageBox.Show("Hãy xác nhận là bạn muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (em.XoaCongTac(id))
                {

                    MessageBox.Show("Xóa  thành công !", "Thông báo");
                    em.ThayDoi(localDate, "Xóa Thông tin", EmployeeManagement.UserID, a.TenCongTac);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công !", "Thông báo");
                };
            }
            dataCongTac.DataSource = em.LoadDataLich();
                  dataCongTac.Update();
                    dataCongTac.Refresh();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            FormThayDoi fr = new FormThayDoi();
            fr.ShowDialog();
        }
        /*
        private void btnNhacNho_Click(object sender, EventArgs e)
        {
            FormNNQuanLi fr = new FormNNQuanLi();
            fr.show();
        }
        */
        private void btnThemNVvaoCT_Click(object sender, EventArgs e)
        {
            
            FormNV nv = new FormNV();
            nv.getMa = labelSelect.Text;
            nv.ShowDialog();
        }

        private void btnHienThiNV_Click(object sender, EventArgs e)
        {
            dataNV.Update();
            dataNV.Refresh();
            dataNV.DataSource=em.LoadNV(Convert.ToInt32(labelSelect.Text));
            
        }

        private void btnNN_Click(object sender, EventArgs e)
        {
            FormNNQuanLi fr = new FormNNQuanLi();
            fr.ShowDialog();
        }
    }
}
