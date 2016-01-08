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
    public partial class frmLichCongTac : Form
    {
        public frmLichCongTac()
        {
            InitializeComponent();
        }
        List<LichCongTac> list = new List<LichCongTac>();
        EmployeeManagement emloy = new EmployeeManagement();
        private void frmLichCongTac_Load(object sender, EventArgs e)
        {
            gridViewLich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewLich.DataSource = emloy.LoadDataLich(EmployeeManagement.UserID, list);
            //label1.Text = DateTime.Now.ToString();
        }
     

        private void btnIn_Click(object sender, EventArgs e)
        {
            //LichCongTac lich = new LichCongTac();
            FormInLich fr = new FormInLich();
            fr.Show();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
        private void comboLich_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string choice = (string)cb.SelectedItem;
        DateTime localDate = DateTime.Now;
        DataTable table = new DataTable();
            switch(choice){
                           case "Lịch hiện tại": 
                    
                            table.Columns.Add("Tên công tác");
                            table.Columns.Add("Ngày bắt đầu");
                            table.Columns.Add("Ngày kết thúc");
                            table.Columns.Add("Địa điểm");
                            table.Columns.Add("Nội dung");
                            table = emloy.LoadDataLich(EmployeeManagement.UserID, list);
                            for (int i = 0; i < list.Count; i++)
                            {
                                int check = 1;
                                if (list[i].TenCongTac.CompareTo(table.Rows[0][i].ToString()) == 0)
                                {
                                    check = 0;
                                }
                                if (check == 1 && list[i].TenCongTac.CompareTo(table.Rows[0][i].ToString()) != 0 && list[i].Ngayketthuc.CompareTo(localDate) > 0)
                                {
                                    table.Rows.Add(list[i].TenCongTac, list[i].Ngaybatdau, list[i].Ngayketthuc, list[i].DiaDiem, list[i].NoiDung);
                                    //label1.Text = a.Ngaybatdau.ToString();
                                }
                            }
                            gridViewLich.DataSource = table;
                
                     
                   break;
                    case "Tất cả":
                            table.Columns.Add("Tên công tác");
                            table.Columns.Add("Ngày bắt đầu");
                            table.Columns.Add("Ngày kết thúc");
                            table.Columns.Add("Địa điểm");
                            table.Columns.Add("Nội dung");
                            table = emloy.LoadDataLich(EmployeeManagement.UserID, list);
                            gridViewLich.DataSource = table;
                    break;


            }
        }
    */
        
    }
}
