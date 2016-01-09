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
        public static int MaNV;
        //check login
        public int CheckLogin(String ID, String Pass)
        {
            //string setthuoctinh = @"";
            DBConnect cn = new DBConnect();
            cn.conn.Open();
            DataTable dt = new DataTable();
            String query = "select ID,Pass,MaCapQuanLi,MaNhanVien from NhanVien where ID=@ID and Pass=@Pass";
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
                MaNV=Convert.ToInt32(dt.Rows[0][3].ToString());
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
        public void DeletedataNV(int MaNV)
        {
            try
            {
            //string setthuoctinh = @"";
            DBConnect cn = new DBConnect();
            cn.conn.Open();
            //DataTable dt = new DataTable();
            String query = @"delete from NhanVien  where MaNhanVien=@MaNV";
            SqlCommand command = new SqlCommand(query, cn.conn);
            command.Parameters.AddWithValue("@MaNV", MaNV); 
            command.ExecuteNonQuery();
            // SqlDataAdapter da = new SqlDataAdapter(command);
            // da.Fill(dt);
            cn.conn.Close();
            //return dt;
              MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi"+ex,"Thông báo");
            }


        }
        //insert data NV
        public void InsertdataNV(String ID,String Pass, String Hoten, String SDT, String DC, String GT,String email,int maQL,int maNQL)
        {
            try
            {
                 //string setthuoctinh = @"";
            DBConnect cn = new DBConnect();
            cn.conn.Open();
            //DataTable dt = new DataTable();
            String query = @"insert into NhanVien([HoTen]
                                          ,[SDT]
                                          ,[DiaChi]
                                          ,[GioiTinh]
                                          ,[Email]
                                          ,[MaNguoiQuanLi]
                                          ,[MaCapQuanLi]
                                          ,[ID]
                                           ,[Pass]) values (@HoTen
                                              ,@SDT
                                              ,@DiaChi
                                              ,@GioiTinh
                                              ,@Email
                                              ,@MaNguoiQuanLi
                                              ,@MaCapQuanLi
                                              ,@ID
                                              ,@Pass) ";
            SqlCommand command = new SqlCommand(query, cn.conn);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Hoten", Hoten);
            command.Parameters.AddWithValue("@SDT", SDT);
            command.Parameters.AddWithValue("@DiaChi", DC);
            command.Parameters.AddWithValue("@GioiTinh", GT);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@MaCapQuanLi", maQL);
            command.Parameters.AddWithValue("@MaNguoiQuanLi", maNQL);
            command.Parameters.AddWithValue("@Pass", Pass);
            command.ExecuteNonQuery();
            // SqlDataAdapter da = new SqlDataAdapter(command);
            // da.Fill(dt);
            cn.conn.Close();
            //return dt;
            MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi"+ex,"Thông báo");
            }
           

        }
        public void PassData(List<MaQuanLi> list)
        {
            //string setthuoctinh = @"";
            DBConnect cn = new DBConnect();
            cn.conn.Open();
            DataTable dt = new DataTable();
            String query = "select ID,MaNhanVien from NhanVien ";
            // String query1 = "select ID,Pass from NhanVien ";
            SqlCommand command = new SqlCommand(query, cn.conn);
            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
          for (int i = 0; i < dt.Rows.Count; i++)
             {
                 MaQuanLi a = new MaQuanLi(dt.Rows[i]["ID"].ToString(), Convert.ToInt32(dt.Rows[i]["MaNhanVien"].ToString()));
                 list.Add(a);
             }  
   

            cn.conn.Close();
           
                
            
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
       
        //Tham so khac
        
        public void insertNV_CT(int manhanvien, int macongtac)
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
   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại!", "Thông báo");
            }
           
        }
         
        //Doi mat khau
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
        //LoadNV
         public DataTable LoadNV(int maCT)
         {
             //aaa
             DBConnect cn = new DBConnect();
             cn.conn.Open();
             DataTable dt = new DataTable();
             String query = @"select * from NhanVien nv, LichCongTac l, NhanVien_CongTac n where 
               nv.MaNhanVien=n.MaNhanVien and n.MaCongTac=l.MaCongTac and l.MaCongTac=@maCT";
             SqlCommand command = new SqlCommand(query, cn.conn);
             command.Parameters.AddWithValue("@maCT", maCT);
             command.ExecuteNonQuery();
             SqlDataAdapter da = new SqlDataAdapter(command);
             da.Fill(dt);
             cn.conn.Close();
             return dt;
         }
        //Lay du lieu CT
         public void LoadCTintoCombo(ComboBox combo)
         {
             DBConnect cn = new DBConnect();
             cn.conn.Open();
             String query = @"select MaCongTac from LichCongTac";
             SqlCommand command = new SqlCommand(query, cn.conn);
           
             //command.ExecuteNonQuery();
             SqlDataReader sqlReader = command.ExecuteReader();
             while (sqlReader.Read())
             {
                 combo.Items.Add(sqlReader["MaCongTac"].ToString());
             }
             cn.conn.Close();
            
         }
         //Lay du lieu NV
         public void LoadNVintoCombo(ComboBox combo)
         {
             DBConnect cn = new DBConnect();
             cn.conn.Open();
             String query = @"select MaNhanVien from NhanVien where [MaCapQuanLi]<3";
             SqlCommand command = new SqlCommand(query, cn.conn);

             //command.ExecuteNonQuery();
             SqlDataReader sqlReader = command.ExecuteReader();
             while (sqlReader.Read())
             {
                 combo.Items.Add(sqlReader["MaNhanVien"].ToString());
             }
             cn.conn.Close();

         }
        //them du lieu bang phu NV_NN
         public void insertNV_NN(int manhanvien,int manhacnho)
         {
             try
             {
                 DBConnect cn = new DBConnect();
                 cn.conn.Open();
                 String query = @"insert into  NhacNho_NhanVien([MaNhanVien],[MaNhacNho]) values(@MaNhanVien,@MaNhacNho)  ";
                 SqlCommand command = new SqlCommand(query, cn.conn);
                 command.Parameters.AddWithValue("@MaNhanVien", manhanvien);
                 command.Parameters.AddWithValue("@MaNhacNho", manhacnho);
                 command.ExecuteNonQuery();
                 cn.conn.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Thất bại!"+ex, "Thông báo");
             }
         }
         public string insertNhacNho(DateTime ngaynhac, string tieude, string noidung, int macongtac)
         {
             try
             {
                 DBConnect cn = new DBConnect();
                 cn.conn.Open();
                 SqlCommand cmd =new SqlCommand();
                 cmd.Connection = cn.conn;
                 SqlDataReader rdr = null;
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.CommandText = "pro_insertNN";
                 cmd.Parameters.AddWithValue("@NgayNhac", ngaynhac);
                 cmd.Parameters.AddWithValue("@TenNhacNho", tieude);
                 cmd.Parameters.AddWithValue("@NoiDung", noidung);
                 cmd.Parameters.AddWithValue("@MaCongTac", macongtac);
                 cmd.Parameters.Add("@MaNhacNho", SqlDbType.VarChar, 100);
                 cmd.Parameters["@MaNhacNho"].Direction = ParameterDirection.Output;
                 rdr=cmd.ExecuteReader();
                 string outputValue = cmd.Parameters["@MaNhacNho"].Value.ToString();
                 cn.conn.Close();
                 return outputValue;
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Thất bại!"+ex, "Thông báo");
                 return "";
             }
         }
        //
         public DataTable LoaddataNN(String ID)
         {

             //string setthuoctinh = @"";
             DBConnect cn = new DBConnect();
             cn.conn.Open();
             DataTable dt = new DataTable();
             String query = @"select nn.MaNhacNho,NgayNhac,TenNhacNho ,NoiDung,MaCongTac,NguoiGui 
             from NhacNho nn,NhanVien nv, NhacNho_NhanVien n  
             where nv.MaNhanVien=n.MaNhanVien and n.MaNhacNho=nn.MaNhacNho and nv.ID=@ID";
             SqlCommand command = new SqlCommand(query, cn.conn);
             command.Parameters.AddWithValue("@ID", ID);
             command.ExecuteNonQuery();
             SqlDataAdapter da = new SqlDataAdapter(command);
             da.Fill(dt);
             cn.conn.Close();
             return dt;


         }
         
    }
}
