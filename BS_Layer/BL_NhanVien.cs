using QLNS_ADO.NET.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace QLNS_ADO.NET.BS_Layer
{
    class BL_NhanVien
    {
        DBMain db = null;
        public BL_NhanVien()
        {
            db = new DBMain();
        }
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("SELECT MaNV, MaHD, HotenNV, NgSinh, Dchi, Phai, MaNQL, Phong FROM NHANVIEN", CommandType.Text, null);
        }
        public List<string> GetAllMaNV()
        {
            string query = "SELECT MaNV FROM NHANVIEN";
            SqlParameter[] parameters = null;

            DataSet dataSet = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);
            List<string> maNVList = new List<string>();

            if (dataSet.Tables.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    maNVList.Add(row["MaNV"].ToString());
                }
            }

            return maNVList;
        }
        public bool ThemNhanVien(string maNV, string maHD, string hoteNV, DateTime ngSinh, string dChi, string Phai,  string maNQL, string phong, string Hinh, bool Excel, string txtFilePath)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@MaHD", maHD),
                new SqlParameter("@HotenNV", hoteNV),
                new SqlParameter("@NgSinh", ngSinh),
                new SqlParameter("@Dchi", dChi),
                new SqlParameter("@Phai", Phai),
                new SqlParameter("@MaNQL", maNQL),
                new SqlParameter("@Phong", phong),
                new SqlParameter("@Hinh", Hinh)
            };
            string strSQL = "INSERT INTO NHANVIEN (MaNV, MaHD, HotenNV, NgSinh, Dchi, Phai,  MaNQL, Phong, Hinh) " +
                                "VALUES (@MaNV, @MaHD, @HotenNV, @NgSinh, @Dchi, @Phai,  @MaNQL, @Phong, @Hinh)";
            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }
        public bool CapNhatNhanVien(string maNV, string maHD, string hoteNV, DateTime ngSinh, string dChi, string Phai, string maNQL, string phong, string Hinh)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
            new SqlParameter("@MaNV", maNV),
            new SqlParameter("@MaHD", maHD),
            new SqlParameter("@HotenNV", hoteNV),
            new SqlParameter("@NgSinh", ngSinh),
            new SqlParameter("@Dchi", dChi),
            new SqlParameter("@Phai", Phai),
            new SqlParameter("@MaNQL", maNQL),
            new SqlParameter("@Phong", phong),
            new SqlParameter("@Hinh", Hinh)
            };

            string strSQL = "UPDATE NHANVIEN SET MaHD=@MaHD, HotenNV=@HotenNV, NgSinh=@NgSinh, Dchi=@Dchi, Phai=@Phai, MaNQL=@MaNQL, Phong=@Phong, Hinh=@Hinh WHERE MaNV=@MaNV";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }
        public void XoaMaNQL(string maNV)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
                new SqlParameter("@MaNV", maNV)
            };

            string strSQL1 = "UPDATE NHANVIEN SET MaNQL = NULL WHERE MaNQL = @MaNV";
            db.MyExecuteNonQuery(strSQL1, CommandType.Text, ref error, parameterValues);
        }
 
        public bool XoaNhanVien(string maNV)
        {
            string error = "";
            BL_PhanCong phancong = new BL_PhanCong();
            BL_ThanNhan thanNhan = new BL_ThanNhan();
            BL_Luong luong = new BL_Luong();
            XoaMaNQL(maNV);
            thanNhan.XoaThanhNhan(maNV);
            luong.XoaLuong(maNV);
            phancong.XoaPhanCong(maNV);
            SqlParameter[] parameterValues2 = new SqlParameter[]
            {
               new SqlParameter("@MaNV_2", maNV)

            };
            string deleteNhanVienSQL = "DELETE FROM NHANVIEN WHERE MaNV = @MaNV_2";
            return db.MyExecuteNonQuery(deleteNhanVienSQL, CommandType.Text, ref error, parameterValues2);
        }
    }
}


