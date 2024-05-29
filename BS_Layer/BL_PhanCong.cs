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
     class BL_PhanCong
    {
        DBMain db = null;
        public BL_PhanCong()
        {
            db = new DBMain();
        }
        public bool XoaPhanCong(string maNV)
        {
            string error = "";

            SqlParameter[] parameterValues1 = new SqlParameter[]
            {
                 new SqlParameter("@MaNV", maNV)
            };

            string strSQL1 = "DELETE FROM PHANCONG WHERE MaNV = @MaNV";
            return db.MyExecuteNonQuery(strSQL1, CommandType.Text, ref error, parameterValues1);
        }

    }
}
