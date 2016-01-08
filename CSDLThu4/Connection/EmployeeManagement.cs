using CSDLThu4.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLThu4.Object
{
    class EmployeeManagement:DBConnect
    {
        public static string UserID;
        public static int MaCT;
        //check login
        public int CheckLogin(String ID, String Pass)
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
        //load data Nhan Vien
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
        //Update data Nhan Vien
        public void UpdatedataNV(String ID,String Hoten,String SDT,String DC,String GT)
        {

            //string setthuoctinh = @"";
            DBConnect cn = new DBConnect();
            cn.conn.Open();
            //DataTable dt = new DataTable();
            String query = @"update NhanVien set Hoten=@Hoten
                             ,SDT=@SDT,DiaChi=@DiaChi,GioiTinh=@GioiTinh where ID=@ID";
            SqlCommand command = new SqlCommand(query, cn.conn);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Hoten", Hoten);
            command.Parameters.AddWithValue("@SDT", SDT);
            command.Parameters.AddWithValue("@DiaChi", DC);
            command.Parameters.AddWithValue("@GioiTinh", GT);
            command.ExecuteNonQuery();
           // SqlDataAdapter da = new SqlDataAdapter(command);
           // da.Fill(dt);
            cn.conn.Close();
            //return dt;


        }
        //Load data LichCT
        public DataTable LoadDataLich(String ID,List<LichCongTac> ListLich)
        {
            //select TenCongTac,NgayBatDau,NgayKetThuc,NoiDung from LichCongTac l ,
            //NhanVien nv,NhanVien_CongTac nvct
           //where nv.ID='nam' and nv.MaNhanVien=nvct.MaNhanVien and nvct.MaCongTac=l.MaCongTac

            //string setthuoctinh = @"";
            DBConnect cn = new DBConnect();
            cn.conn.Open();
            DataTable dt = new DataTable();
            String query = @"select TenCongTac,NgayBatDau,NgayKetThuc,DiaDiem,NoiDung 
            from LichCongTac l ,NhanVien nv,NhanVien_CongTac nvct   
             where nv.MaNhanVien=nvct.MaNhanVien and nvct.MaCongTac=l.MaCongTac and  ID=@ID";
            SqlCommand command = new SqlCommand(query, cn.conn);
            command.Parameters.AddWithValue("@ID", ID);
                 command.ExecuteNonQuery();
            //lich.
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            cn.conn.Close();
            //return dt;

            for (int i = 0; i<dt.Rows.Count; i++)
            {
            LichCongTac a = new LichCongTac(dt.Rows[i][0].ToString(), DateTime.Parse(dt.Rows[i][1].ToString()),
            DateTime.Parse(dt.Rows[i][2].ToString()), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString());
            ListLich.Add(a);
                
            }
            return dt;
        }
        //Load du lieu lich
        public DataTable LoadDataLich(String ID)
        {
            //select TenCongTac,NgayBatDau,NgayKetThuc,NoiDung from LichCongTac l ,
            //NhanVien nv,NhanVien_CongTac nvct
            //where nv.ID='nam' and nv.MaNhanVien=nvct.MaNhanVien and nvct.MaCongTac=l.MaCongTac

            //string setthuoctinh = @"";
            DBConnect cn = new DBConnect();
            cn.conn.Open();
            DataTable dt = new DataTable();
            String query = @"select TenCongTac,NgayBatDau,NgayKetThuc,DiaDiem,NoiDung 
            from LichCongTac l ,NhanVien nv,NhanVien_CongTac nvct   
             where nv.MaNhanVien=nvct.MaNhanVien and nvct.MaCongTac=l.MaCongTac and  ID=@ID";
            SqlCommand command = new SqlCommand(query, cn.conn);
            command.Parameters.AddWithValue("@ID", ID);
            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            cn.conn.Close();
            return dt;
        }
        //load du lieu lich
        public DataTable LoadDataLich()
        {
            //select TenCongTac,NgayBatDau,NgayKetThuc,NoiDung from LichCongTac l ,
            //NhanVien nv,NhanVien_CongTac nvct
            //where nv.ID='nam' and nv.MaNhanVien=nvct.MaNhanVien and nvct.MaCongTac=l.MaCongTac

            //string setthuoctinh = @"";
            DBConnect cn = new DBConnect();
            cn.conn.Open();
            DataTable dt = new DataTable();
            String query = @"select MaCongTac,TenCongTac,NgayBatDau,NgayKetThuc,DiaDiem,NoiDung 
            from LichCongTac  ";
            SqlCommand command = new SqlCommand(query, cn.conn);
           
            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            cn.conn.Close();
            return dt;
        }
        //Them CT
        public bool ThemCongTac(string TenCongTac, DateTime NgayBatDau, DateTime NgayKetThuc, string DiaDiem, string NoiDung, int MaLoaiCongTac)
        {
            try
            {
                DBConnect cn = new DBConnect();
                cn.conn.Open();

                String query = @"insert into LichCongTac(TenCongTac,NgayBatDau,NgayKetThuc,DiaDiem,NoiDung,MaLoaiCongTac)
             values(@TenCongTac,@NgayBatDau,@NgayKetThuc,@DiaDiem,@NoiDung,@MaLoaiCongTac)";
                SqlCommand command = new SqlCommand(query, cn.conn);
                command.Parameters.AddWithValue("@TenCongTac", TenCongTac);
                command.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                command.Parameters.AddWithValue("@DiaDiem", DiaDiem);
                command.Parameters.AddWithValue("@NoiDung", NoiDung);
                command.Parameters.AddWithValue("@MaLoaiCongTac", MaLoaiCongTac);
                command.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(command);

                cn.conn.Close();
                return true;
            }catch(Exception ex){
                return false;
            }
          
        }
        //Sua CT
        public bool SuaCongTac(int id ,string TenCongTac, DateTime NgayBatDau, DateTime NgayKetThuc, string DiaDiem, string NoiDung, int MaLoaiCongTac)
        {
            try
            {
                DBConnect cn = new DBConnect();
                cn.conn.Open();

                String query = @"update LichCongTac set TenCongTac=@TenCongTac,NgayBatDau=@NgayBatDau,
                 NgayKetThuc=@NgayKetThuc,DiaDiem=@DiaDiem,NoiDung=@NoiDung,MaLoaiCongTac=@MaLoaiCongTac where MaCongTac=@id ";
                SqlCommand command = new SqlCommand(query, cn.conn);
                command.Parameters.AddWithValue("@TenCongTac", TenCongTac);
                command.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                command.Parameters.AddWithValue("@DiaDiem", DiaDiem);
                command.Parameters.AddWithValue("@NoiDung", NoiDung);
                command.Parameters.AddWithValue("@MaLoaiCongTac", MaLoaiCongTac);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(command);

                cn.conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        //xoa cong tac
        public bool XoaCongTac(int id)
        {
            try
            {
                DBConnect cn = new DBConnect();
                cn.conn.Open();

                String query = @"delete LichCongTac where MaCongTac=@id ";
                SqlCommand command = new SqlCommand(query, cn.conn);
              
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(command);

                cn.conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        //insert du lieu bang thay doi
        public void ThayDoi(DateTime ngaythaydoi,string noidung,string id,string tencongtac)
        {
            
                DBConnect cn = new DBConnect();
                cn.conn.Open();

                String query = @"insert into  ThayDoi([NgayThayDoi]
                                                      ,[NoiDung]
                                                      ,[ID]
                                                      ,[TenCongTac]) 
                                  values(@NgayThayDoi, @NoiDung,@id,@TenCongTac)";
                SqlCommand command = new SqlCommand(query, cn.conn);

                command.Parameters.AddWithValue("@NgayThayDoi", ngaythaydoi);
                command.Parameters.AddWithValue("@NoiDung", noidung);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@TenCongTac", tencongtac);
                command.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(command);
                cn.conn.Close();
        }
        // load du lieu bang thay doi
        public DataTable LoadThayDoi()
        {
            DBConnect cn = new DBConnect();
            cn.conn.Open();
            DataTable dt = new DataTable();
            String query = @"select [NgayThayDoi],[NoiDung]
                                                      ,[ID]
                                                      ,[TenCongTac] 
            from ThayDoi  ";
            SqlCommand command = new SqlCommand(query, cn.conn);

            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            cn.conn.Close();
            return dt;
        }
        //load du lieu nhan vien
        public DataTable LoadNV()
        {
            DBConnect cn = new DBConnect();
            cn.conn.Open();
            DataTable dt = new DataTable();
            String query = @"select * from NhanVien  ";
            SqlCommand command = new SqlCommand(query, cn.conn);
            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            cn.conn.Close();
            return dt;
        }
        // insert NV_CT
        public bool insertNV_CT(int manhanvien,int macongtac)
        {
            try
            {
                DBConnect cn = new DBConnect();
                cn.conn.Open();
                String query = @"insert into  NhanVien_CongTac([MaNhanVien],[MaCongTac]) values(@MaNhanVien,@MaCongTac)  ";
                SqlCommand command = new SqlCommand(query, cn.conn);
                command.Parameters.AddWithValue("@MaNhanVien", manhanvien);
                command.Parameters.AddWithValue("@MaCongTac", macongtac);
                command.ExecuteNonQuery();
                cn.conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
        //
         public bool ChangePass(int manhanvien,string passCu,string passMoi )
        {
            try
            {
                DBConnect cn = new DBConnect();
                cn.conn.Open();
                string sql = "select count(*) as MaxNumber from NhanVien where Pass=@Pass and MaNhanVien=@MaNhanVien";
                SqlCommand cmd = new SqlCommand(sql, cn.conn);
                cmd.Parameters.AddWithValue("@MaNhanVien", manhanvien);
                cmd.Parameters.AddWithValue("@Pass", passCu);
                cmd.ExecuteNonQuery();
                int rows = Convert.ToInt32(cmd.ExecuteScalar());
                cn.conn.Close();
                if (rows == 1)
                {
                    cn.conn.Open();
                    sql = "update  NhanVien set Pass=@PassMoi where Pass=@Pass and MaNhanVien=@MaNhanVien";
                     cmd = new SqlCommand(sql, cn.conn);
                    cmd.Parameters.AddWithValue("@MaNhanVien", manhanvien);
                    cmd.Parameters.AddWithValue("@Pass", passCu);
                    cmd.Parameters.AddWithValue("@PassMoi", passMoi);
                    cmd.ExecuteNonQuery();
                    cn.conn.Close();
                    return true;

                }
                else
                {
                    return false;
                }
               
               
               
               
                
            }
             
            catch (Exception ex)
            {
                return false;
            }
              
            
        }
       
    }
}
