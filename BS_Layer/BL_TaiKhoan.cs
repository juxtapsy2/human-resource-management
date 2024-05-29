using QLNS_ADO.NET.DB_Layer;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ADO.NET.BS_Layer
{
     class BL_TaiKhoan
    {
        DBMain db = null;
        public BL_TaiKhoan()
        {
            db = new DBMain();
        }
        public bool Login(string UserName, string Password)
        {
            bool isLogged = false;
            try
            {
                string query = "SELECT COUNT(*) FROM DANGNHAP WHERE TenDN=@UserName AND MatKhau=@Password";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@UserName", UserName),
                new SqlParameter("@Password", Password)
                };
                DataSet ds = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);
                if (ds.Tables[0].Rows.Count > 0 && Convert.ToInt32(ds.Tables[0].Rows[0][0]) > 0)
                {
                    isLogged = true;
                }
            }
            catch (Exception ex)
            {

            }
            return isLogged;
        }
        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {


            SqlParameter[] parameters =
            {
            new SqlParameter("@Username", username),
            new SqlParameter("@OldPassword", oldPassword),
            new SqlParameter("@NewPassword", newPassword)
             };

            string selectQuery = "SELECT COUNT(*) FROM [DANGNHAP] WHERE TenDN = @Username AND MatKhau = @OldPassword";
            DataSet result = db.ExecuteQueryDataSet(selectQuery, CommandType.Text, parameters);

            if (result.Tables[0].Rows[0][0].ToString() == "1")
            {
                string updateQuery = "UPDATE [DANGNHAP] SET MatKhau = @NewPassword WHERE TenDN = @Username";
                string error = "";
                bool success = db.MyExecuteNonQuery(updateQuery, CommandType.Text, ref error, null);
                return success;
            }

            return false;
        }

    }
}
