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
     class BL_ThanNhan
    {
        DBMain db = null;
        public BL_ThanNhan() 
        {
            db = new DBMain();
        }
        public DataSet LayThanhNhan()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM THANNHAN", CommandType.Text, null);
        }
        public bool ThemThanNhan(string maNV, string hoteTN, string vaiTro, string SDT)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@HotenTN", hoteTN),
                new SqlParameter("@VaiTro", vaiTro),
                new SqlParameter("@SDT", SDT)
            };
            string strSQL = "INSERT INTO THANNHAN (MaNV, HotenTN, VaiTro, SDT) " +
                                "VALUES (@MaNV, @HotenTN, @VaiTro, @SDT)";
            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }
        public bool CapNhatThanhNhan(string maNV, string hoteTN, string vaiTro, string SDT)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
              new SqlParameter("@MaNV", maNV),
              new SqlParameter("@HotenTN", hoteTN),
              new SqlParameter("@VaiTro", vaiTro),
              new SqlParameter("@SDT", SDT)
            };

            string strSQL = "UPDATE THANNHAN SET HotenTN=@HotenTN, VaiTro=@VaiTro, SDT=@SDT WHERE MaNV=@MaNV";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }
        public bool XoaThanhNhan(string maNV)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
        new SqlParameter("@MaNV", maNV)
            };

            string strSQL1 = "DELETE FROM THANNHAN WHERE MaNV = @MaNV";
            return db.MyExecuteNonQuery(strSQL1, CommandType.Text, ref error, parameterValues);
        }
    }
}
