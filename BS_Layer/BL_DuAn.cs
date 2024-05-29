using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_LinQ
{
    class BL_DuAn
    {
        public System.Data.Linq.Table<DUAN> LayDuAn()
        {
            DataSet ds = new DataSet();
            QLNSDataContext qlNS = new QLNSDataContext();
            return qlNS.DUANs;
        }
        public bool CapNhatDuAn(string maDA, string tenDA, string diaDiem, string phong)
        {
            QLNSDataContext db = new QLNSDataContext();
            try
            {
              
                    var duAn = db.DUANs.FirstOrDefault(nv => nv.MaDA == maDA);
                    if (duAn == null)
                    {
                        return false;
                    }
                    duAn.TenDA = tenDA;
                    duAn.DiaDiem = diaDiem;
                    duAn.Phong = phong;
                    db.SubmitChanges();
                    return true;
                
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ThemDuAn(string maDA, string tenDA, string diaDiem, string phong)
        {
            QLNSDataContext qlNS = new QLNSDataContext();
            try
            {
                DUAN da = new DUAN();
                da.MaDA = maDA;
                da.TenDA = tenDA;
                da.DiaDiem = diaDiem;
                da.Phong = phong;
                qlNS.DUANs.InsertOnSubmit(da);
                qlNS.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool XoaDuAn(string maDA)
        {
            QLNSDataContext db = new QLNSDataContext();
            try
            {
                    var duAn= db.DUANs.FirstOrDefault(nv => nv.MaDA == maDA);
                    if (duAn == null)
                    {
                        return false;
                    }
                    db.DUANs.DeleteOnSubmit(duAn);
                    db.SubmitChanges();
                    return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
