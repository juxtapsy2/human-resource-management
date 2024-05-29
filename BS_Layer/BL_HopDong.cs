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
     class BL_HopDong
    {
        DBMain db = null;
        public BL_HopDong()
        {
            db = new DBMain();
        }
        public DataSet LayHopDong()
        {
            return db.ExecuteQueryDataSet("SELECT MaHD, ThoiHan, ViTri, MoTa FROM HOPDONG", CommandType.Text, null);
        }
        public List<string> GetAllMaHD()
        {
            string query = "SELECT MaHD FROM HOPDONG";
            SqlParameter[] parameters = null;

            DataSet dataSet = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);
            List<string> maHDList = new List<string>();

            if (dataSet.Tables.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    maHDList.Add(row["MaHD"].ToString());
                }
            }

            return maHDList;
        }
        public List<string> GetAllViTri()
        {
            string query = "SELECT ViTri FROM HOPDONG";
            SqlParameter[] parameters = null;

            DataSet dataSet = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);
            List<string> listViTri = new List<string>();

            if (dataSet.Tables.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    listViTri.Add(row["ViTri"].ToString());
                }
            }

            return listViTri;
        }
        public bool CapNhatHopDong(string maHD, int thoiHan, string viTri, string moTa)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
            new SqlParameter("@MaHD", maHD),
            new SqlParameter("@ThoiHan", thoiHan),
            new SqlParameter("@ViTri", viTri),
            new SqlParameter("@MoTa", moTa),
            };

            string strSQL = "UPDATE HOPDONG SET MaHD=@MaHD, ThoiHan=@ThoiHan, ViTri=@ViTri, MoTa=@MoTa WHERE MaHD=@MaHD";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }
    }
}
