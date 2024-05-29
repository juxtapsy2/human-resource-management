using QLNS_ADO.NET.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ADO.NET.BS_Layer
{
    class BL_DuAn
    {
        DBMain db = null;
        public BL_DuAn()
        {
            db = new DBMain();
        }
        public DataSet LayDuAn()
        {
            return db.ExecuteQueryDataSet("SELECT MaDA, TenDA, DiaDiem, Phong FROM DUAN", CommandType.Text, null);
        }
        public bool ThemDuAn(string maDA, string tenDA, string diaDiem, string phong)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
                new SqlParameter("@MaDA", maDA),
                new SqlParameter("@TenDA", tenDA),
                new SqlParameter("@DiaDiem", diaDiem),
                new SqlParameter("@Phong", phong),
            };
            string strSQL = "INSERT INTO DUAN (MaDA, TenDA, DiaDiem, Phong) " +
                                "VALUES (@MaDA, @TenDA, @DiaDiem, @Phong)";
            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }
        public bool CapNhatDuAn(string maDA, string tenDA, string diaDiem, string phong)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
            new SqlParameter("@MaDA", maDA),
            new SqlParameter("@TenDA", tenDA),
            new SqlParameter("@DiaDiem", diaDiem),
            new SqlParameter("@Phong", phong),
            };

            string strSQL = "UPDATE DUAN SET MaDA=@MaDA, TenDA=@TenDA, DiaDiem=@DiaDiem, Phong=@Phong WHERE MaDA=@MaDA";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }
        public bool XoaDuAn(string maDA)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
                 new SqlParameter("@MaDA", maDA)
            };

            string strSQL = "DELETE FROM DUAN WHERE MaDA=@MaDA";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }
    }
}
