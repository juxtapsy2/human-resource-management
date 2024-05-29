using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS_ADO.NET.DB_Layer;

namespace QLNS_ADO.NET.BS_Layer
{
     class BL_ThoiViec
    {
        DBMain db = null;
        public BL_ThoiViec()
        {
            db = new DBMain();
        }
        public DataSet LayThoiViec()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM THOIVIEC", CommandType.Text, null);
        }
        public bool ThemThoiViec(string maNV, string maHD, DateTime NgayThoiViec, string lyDo)
        {
            string error = "";

            SqlParameter[] parameterValues3 = new SqlParameter[]
            {
                new SqlParameter("@MaNVThoiViec", maNV),
                new SqlParameter("@MaHD", maHD),
                new SqlParameter("@NgayThoiViec", NgayThoiViec),
                new SqlParameter("@LyDo", lyDo)
            };
            string strSQL = "INSERT INTO THOIVIEC (MaNVThoiViec, MaHD, NgayThoiViec, LyDo) " +
                                "VALUES (@MaNVThoiViec, @MaHD, @NgayThoiViec, @LyDo)";
            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues3);
        }
        public bool XoaThoiViec(string maNV)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
        new SqlParameter("@MaNVThoiViec", maNV)
            };

            string strSQL1 = "DELETE FROM THOIVIEC WHERE MaNVThoiViec = @MaNVThoiViec";
            return db.MyExecuteNonQuery(strSQL1, CommandType.Text, ref error, parameterValues);
        }
    }
}
