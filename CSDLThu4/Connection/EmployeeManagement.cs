using CSDLThu4.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLThu4.Object
{
    class EmployeeManagement:DBConnect
    {
        public static string UserID;
        public DataTable LoaddataNV(String ID)
        {
            
                //string setthuoctinh = @"";
            DBConnect cn = new DBConnect();
            cn.conn.Open();
                DataTable dt = new DataTable();
                String query = "select Hoten,SDT,DiaChi,GioiTinh from NhanVien where ID=@ID";
                SqlCommand command = new SqlCommand(query, cn.conn);
                command.Parameters.AddWithValue("@ID", ID);
                command.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                cn.conn.Close();
                return dt;
            
            
        }

        public int Check(String ID, String Pass)
        {
             //string setthuoctinh = @"";
            DBConnect cn = new DBConnect();
            cn.conn.Open();
                DataTable dt = new DataTable();
                String query = "select ID,Pass,MaCapQuanLi from NhanVien where ID=@ID and Pass=@Pass";
               // String query1 = "select ID,Pass from NhanVien ";
                SqlCommand command = new SqlCommand(query, cn.conn);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Pass", Pass);
                command.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                cn.conn.Close();
                if (dt.Rows.Count == 0)
                {
                    return 0;
                }
                else
                {

                    UserID = dt.Rows[0][1].ToString();
                    return Int32.Parse(dt.Rows[0][2].ToString());
                }

               
               
               
        }
        
    }
}
