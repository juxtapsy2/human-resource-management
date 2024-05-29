using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNS_EntityFramework.BS_Layer
{
    class BL_PhongBan
    {
        public List<string> GetAllMaPB()
        {
            using (var context = new QLNSEntities())
            {
                var maPBList = context.PHONGBANs.Select(pb => pb.MaPB).ToList();
                return maPBList;
            }
        }
        public DataTable LayPhongBan()
        {
            QLNSEntities qlnsEntity = new QLNSEntities();
            var phongBans =
                from pb in qlnsEntity.PHONGBANs
                select new
                {
                    pb.MaPB,
                    pb.TenPB,
                    pb.TrPhong,
                    pb.NgNhanChuc,
                    pb.DiaDiem
                };

            DataTable dt = new DataTable();
            dt.Columns.Add("MaPB");
            dt.Columns.Add("TenPB");
            dt.Columns.Add("TrPhong");
            dt.Columns.Add("NgNhanChuc");
            dt.Columns.Add("DiaDiem");

            foreach (var pb in phongBans)
            {
                dt.Rows.Add(pb.MaPB, pb.TenPB, pb.TrPhong, pb.NgNhanChuc, pb.DiaDiem);
            }
            return dt;
        }

        public bool ThemPhongBan(string maPB, string tenPB, string trPhong, DateTime ngNhanChuc, string diaDiem)
        {
            QLNSEntities context = new QLNSEntities();
            try
            {
                var phongBan = new PHONGBAN
                {
                    MaPB = maPB,
                    TenPB = tenPB,
                    TrPhong = trPhong,
                    NgNhanChuc = ngNhanChuc,
                    DiaDiem = diaDiem
                };

                context.PHONGBANs.Add(phongBan);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CapNhatPhongBan(string maPB, string tenPB, string trPhong, DateTime ngNhanChuc, string diaDiem)
        {
            QLNSEntities db = new QLNSEntities();
            try
            {
                var phongBan = db.PHONGBANs.FirstOrDefault(pb => pb.MaPB == maPB);
                if (phongBan == null)
                {
                    return false;
                }

                phongBan.TenPB = tenPB;
                phongBan.TrPhong = trPhong;
                phongBan.NgNhanChuc = ngNhanChuc;
                phongBan.DiaDiem = diaDiem;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaPhongBan(string maPB)
        {
            QLNSEntities db = new QLNSEntities();
            try
            {
                var phongBan = db.PHONGBANs.FirstOrDefault(pb => pb.MaPB == maPB);
                if (phongBan == null)
                {
                    return false;
                }

                db.PHONGBANs.Remove(phongBan);
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
