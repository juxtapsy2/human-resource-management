using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_EntityFramework.BS_Layer
{
    class BL_DuAn
    {
        public DataTable LayDuAn()
        {
            QLNSEntities qlnsEntity = new QLNSEntities();
            var das =
            from p in qlnsEntity.DUANs
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("MaDA");
            dt.Columns.Add("TenDA");
            dt.Columns.Add("DiaDiem");
            dt.Columns.Add("Phong");

            foreach (var p in das)
            {
                dt.Rows.Add(p.MaDA, p.TenDA, p.DiaDiem, p.Phong);
            }
            return dt;
        }
        public bool ThemDuAn(string maDA, string tenDA, string diaDiem, string phong)
        {
            QLNSEntities context = new QLNSEntities();
            try
            {
                
                    var duAn = new DUAN
                    {
                       MaDA = maDA,
                       TenDA = tenDA,
                       DiaDiem = diaDiem,
                       Phong = phong
                    };

                    context.DUANs.Add(duAn);
                    context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool CapNhatDuAn(string maDA, string tenDA, string diaDiem, string phong)
        {
            QLNSEntities db = new QLNSEntities();
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
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool XoaDuAn(string maDA)
        {
            QLNSEntities db = new QLNSEntities();
            try
            {
                var duAn = db.DUANs.FirstOrDefault(nv => nv.MaDA == maDA);
                if (duAn == null)
                {
                    return false;
                }
                db.DUANs.Remove(duAn);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
