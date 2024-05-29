using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNS_EntityFramework.BS_Layer
{
    class BL_Luong
    {
        public DataTable LayLuong()
        {
            QLNSEntities qlnsEntity = new QLNSEntities();
            var luongs =
                from l in qlnsEntity.LUONGs
                select new
                {
                    l.MaNV,
                    l.LuongCung,
                    l.NgayNghi,
                    l.Phucap
                };

            DataTable dt = new DataTable();
            dt.Columns.Add("MaNV");
            dt.Columns.Add("LuongCung");
            dt.Columns.Add("NgayNghi");
            dt.Columns.Add("Phucap");

            foreach (var l in luongs)
            {
                dt.Rows.Add(l.MaNV, l.LuongCung, l.NgayNghi, l.Phucap);
            }
            return dt;
        }

        public bool ThemLuong(string maNV, int luongCung, int ngayNghi, int phuCap, int tongLuong)
        {
            QLNSEntities context = new QLNSEntities();
            try
            {
                var luong = new LUONG
                {
                    MaNV = maNV,
                    LuongCung = luongCung,
                    NgayNghi = ngayNghi,
                    Phucap = phuCap,
                    TongLuong = tongLuong
                };

                context.LUONGs.Add(luong);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CapNhatLuong(string maNV, int luongCung, int ngayNghi, int phuCap)
        {
            QLNSEntities db = new QLNSEntities();
            try
            {
                var luong = db.LUONGs.FirstOrDefault(l => l.MaNV == maNV);
                if (luong == null)
                {
                    return false;
                }

                luong.LuongCung = luongCung;
                luong.NgayNghi = ngayNghi;
                luong.Phucap = phuCap;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaLuong(string maNV)
        {
            QLNSEntities db = new QLNSEntities();
            try
            {
                var luong = db.LUONGs.FirstOrDefault(l => l.MaNV == maNV);
                if (luong == null)
                {
                    return false;
                }

                db.LUONGs.Remove(luong);
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
