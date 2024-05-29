using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_EntityFramework.BS_Layer
{
    class BL_TaiKhoan
    {
        public bool Login(string UserName, string Password)
        {

            using (var dbContext = new QLNSEntities())
            {
                // Check if the user exists in the database and if the password is correct
                var user = dbContext.DANGNHAPs.FirstOrDefault(u => u.TenDN == UserName && u.MatKhau == Password);

                if (user == null)
                {
                    return false;
                }

                // Login successful
                return true;
            }
        }
        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            using (var db = new QLNSEntities())
            {
                var user = db.DANGNHAPs.FirstOrDefault(u => u.TenDN == username && u.MatKhau == oldPassword);
                if (user != null)
                {
                    user.MatKhau = newPassword;
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }
}
