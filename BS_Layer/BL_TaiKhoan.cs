using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_LinQ.BS_Layer
{
    class BL_TaiKhoan
    {
        public System.Data.Linq.Table<DANGNHAP> LayDanhNhap()
        {
            DataSet ds = new DataSet();
            QLNSDataContext qlNS = new QLNSDataContext();
            return qlNS.DANGNHAPs;
        }
        public bool Login(string UserName, string Password)
        {
            QLNSDataContext qlNS = new QLNSDataContext();

            var user = qlNS.DANGNHAPs.FirstOrDefault(u => u.TenDN == UserName && u.MatKhau == Password);

            return user != null;
        }
        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {

            using (var qlNS = new QLNSDataContext())
            {
                var user = qlNS.DANGNHAPs.SingleOrDefault(u => u.TenDN == username && u.MatKhau == oldPassword);
                if (user != null)
                {
                    user.MatKhau = newPassword;
                    qlNS.SubmitChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
