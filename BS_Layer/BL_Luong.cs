using QLNS_ADO.NET.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ADO.NET.BS_Layer
{
   class BL_Luong
   {
        DBMain db = null;
        public BL_Luong()
        {
            db = new DBMain();
        }
        public DataSet LayLuong()
        {
            return db.ExecuteQueryDataSet("SELECT MaNV, LuongCung, NgayNghi, Phucap FROM LUONG", CommandType.Text, null);
        }
        public bool ThemLuong(string maNV, int luongCung, int ngayNghi, int phuCap, int tongluong)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
            new SqlParameter("@MaNV", maNV),
            new SqlParameter("@LuongCung", luongCung),
            new SqlParameter("@NgayNghi", ngayNghi),
            new SqlParameter("@Phucap", phuCap),
            new SqlParameter("@TongLuong", tongluong),
            };

            string strSQL = "INSERT INTO Luong (MaNV, LuongCung, NgayNghi, PhuCap, TongLuong) " +
                              "VALUES (@MaNV, @LuongCung, @NgayNghi, @Phucap, @TongLuong)";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }
        public bool CapNhatLuong(string maNV, int luongCung, int ngayNghi, int phuCap)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
            new SqlParameter("@MaNV", maNV),
            new SqlParameter("@LuongCung", luongCung),
            new SqlParameter("@NgayNghi", ngayNghi),
            new SqlParameter("@Phucap", phuCap),
            };

            string strSQL = "UPDATE LUONG SET MaNV=@MaNV, LuongCung=@LuongCung, NgayNghi=@NgayNghi, Phucap=@Phucap WHERE MaNV=@MaNV";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }
        public bool XoaLuong(string maNV)
        {
            string error = "";

            SqlParameter[] parameterValues1 = new SqlParameter[]
            {
                 new SqlParameter("@MaNV", maNV)
            };

            string strSQL1 = "DELETE FROM LUONG WHERE MaNV = @MaNV";
            return db.MyExecuteNonQuery(strSQL1, CommandType.Text, ref error, parameterValues1);
        }

    }
}
