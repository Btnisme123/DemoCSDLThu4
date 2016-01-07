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
    public partial class FormThemCongTac : Form
    {
        public FormThemCongTac()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            
            if (dateTimeNgayBD.Value.CompareTo(dateTimeNgayKT.Value)>0)
            {
                MessageBox.Show("Thời gian bị sai!", "Thông báo");
            }
            else if (txtTenCT.Text.CompareTo("") == 0 || txtNoiDung.Text.CompareTo("") == 0 || txtDiaDiem.Text.CompareTo("") == 0 || comboLoaiCT.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Thiếu dữ liệu!", "Thông báo");
            }
            else
            {
                EmployeeManagement em = new EmployeeManagement();
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
                if (em.ThemCongTac(a.TenCongTac, a.Ngaybatdau, a.Ngayketthuc, a.DiaDiem, a.NoiDung, a.LoaiCT))
                {
                    MessageBox.Show("Thêm  thành công !", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công !", "Thông báo");
                };
            }
          
         
        }

        private void FormThemCongTac_Load(object sender, EventArgs e)
        {

        }
    }
}
