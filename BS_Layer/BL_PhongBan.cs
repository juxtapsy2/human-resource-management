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
    class BL_PhongBan
    {
        DBMain db = null;
        public BL_PhongBan()
        {
            db = new DBMain();
        }
        public List<string> GetAllMaPB()
        {
            string query = "SELECT MaPB FROM PHONGBAN";
            SqlParameter[] parameters = null;

            DataSet dataSet = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);
            List<string> maPBList = new List<string>();

            if (dataSet.Tables.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    maPBList.Add(row["MaPB"].ToString());
                }
            }

            return maPBList;
        }
        public DataSet LayPhongBan()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM PHONGBAN", CommandType.Text, null);
        }
        public bool ThemPhongBan(string MaPB, string TenPB, string TrPhong, DateTime NgNhanChuc, string DiaDiem)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
                new SqlParameter("@MaPB", MaPB),
                new SqlParameter("@TenPB", TenPB),
                new SqlParameter("@TrPhong", TrPhong),
                new SqlParameter("@NgNhanChuc", NgNhanChuc),
                new SqlParameter("@DiaDiem", DiaDiem),
            };
            string strSQL = "INSERT INTO PHONGBAN (MaPB, TenPB, TrPhong, NgNhanChuc, DiaDiem) " +
                                "VALUES (@MaPB, @TenPB, @TrPhong, @NgNhanChuc, @DiaDiem)";
            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }
        public bool CapNhatPhongBan(string MaPB, string TenPB, string TrPhong, DateTime NgNhanChuc, string DiaDiem)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
                new SqlParameter("@MaPB", MaPB),
                new SqlParameter("@TenPB", TenPB),
                new SqlParameter("@TrPhong", TrPhong),
                new SqlParameter("@NgNhanChuc", NgNhanChuc),
                new SqlParameter("@DiaDiem", DiaDiem),
            };

            string strSQL = "UPDATE PHONGBAN SET MaPB=@MaPB, TenPB=@TenPB, TrPhong=@TrPhong, NgNhanChuc=@NgNhanChuc, DiaDiem=@DiaDiem WHERE MaPB=@MaPB";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }
        public bool XoaPhongBan(string MaPB)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
                 new SqlParameter("@MaPB", MaPB)
            };

            string strSQL = "DELETE FROM PHONGBAN WHERE MaPB=@MaPB";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }
    }
}
