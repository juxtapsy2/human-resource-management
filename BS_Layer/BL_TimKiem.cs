using Microsoft.Office.Interop.Excel;
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
     class BL_TimKiem
    {

        DBMain db = null;
        public BL_TimKiem()
        {
            db = new DBMain();
        }
        public DataSet TimKiem(string input, string propertyName, string tableName)
        {
            string sql = "SELECT * FROM " + tableName + " WHERE " + propertyName + " LIKE @input";
            SqlParameter[] parameters = {
        new SqlParameter("@input", "%" + input + "%")
        };
            return db.ExecuteQueryDataSet(sql, CommandType.Text, parameters);
        }
    }
}
