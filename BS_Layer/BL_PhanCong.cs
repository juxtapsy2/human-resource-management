using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNS_EntityFramework.BS_Layer
{
     class BL_PhanCong
    {
        public DataTable LayPhanCong()
        {
            QLNSEntities qlnsEntity = new QLNSEntities();
            var phanCongs =
                from pc in qlnsEntity.PHANCONGs
                select new
                {
                    pc.MaNV,
                    pc.MaDA,
                    pc.ThoiGian
                };

            DataTable dt = new DataTable();
            dt.Columns.Add("MaNV");
            dt.Columns.Add("MaDA");
            dt.Columns.Add("ThoiGian");

            foreach (var pc in phanCongs)
            {
                dt.Rows.Add(pc.MaNV, pc.MaDA, pc.ThoiGian);
            }
            return dt;
        }

        public bool ThemPhanCong(string maNV, string maDA, int thoiGian)
        {
            QLNSEntities context = new QLNSEntities();
            try
            {
                var phanCong = new PHANCONG
                {
                    MaNV = maNV,
                    MaDA = maDA,
                    ThoiGian = thoiGian
                };

                context.PHANCONGs.Add(phanCong);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CapNhatPhanCong(string maNV, string maDA, int thoiGian)
        {
            QLNSEntities db = new QLNSEntities();
            try
            {
                var phanCong = db.PHANCONGs.FirstOrDefault(pc => pc.MaNV == maNV);
                if (phanCong == null)
                {
                    return false;
                }

                phanCong.ThoiGian = thoiGian;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool XoaPhanCong(string maNV)
        {
            try
            {
                using (var context = new QLNSEntities())
                {
                    var phanCong = context.PHANCONGs.FirstOrDefault(pc => pc.MaNV == maNV);

                    if (phanCong != null)
                    {
                        context.PHANCONGs.Remove(phanCong);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                return false;
            }
        }
    }
}
