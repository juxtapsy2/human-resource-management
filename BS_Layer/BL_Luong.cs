using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_LinQ
{
    class BL_Luong
    {
        public List<LUONG> LayLuong()
        {
            using (QLNSDataContext qlNS = new QLNSDataContext())
            {
                var luongQuery = from l in qlNS.LUONGs
                                 select new
                                 {
                                     l.MaNV,
                                     l.LuongCung,
                                     l.NgayNghi,
                                     l.Phucap
                                 };

                return luongQuery.AsEnumerable().Select(l => new LUONG
                {
                    MaNV = l.MaNV,
                    LuongCung = l.LuongCung,
                    NgayNghi = l.NgayNghi,
                    Phucap = l.Phucap
                }).ToList();
            }
        }

        public bool CapNhatLuong(string maNV, int luongCung, int ngayNghi, int phuCap)
        {
            using (QLNSDataContext qlNS = new QLNSDataContext())
            {
                try
                {
                    var luong = qlNS.LUONGs.FirstOrDefault(l => l.MaNV == maNV);
                    if (luong == null)
                    {
                        return false;
                    }

                    luong.LuongCung = luongCung;
                    luong.NgayNghi = ngayNghi;
                    luong.Phucap = phuCap;

                    qlNS.SubmitChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool ThemLuong(string maNV, int luongCung, int ngayNghi, int phuCap)
        {
            using (QLNSDataContext qlNS = new QLNSDataContext())
            {
                try
                {
                    LUONG luong = new LUONG();
                    luong.MaNV = maNV;
                    luong.LuongCung = luongCung;
                    luong.NgayNghi = ngayNghi;
                    luong.Phucap = phuCap;
                    luong.TongLuong = null;
                    qlNS.LUONGs.InsertOnSubmit(luong);
                    qlNS.SubmitChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool XoaLuong(string maNV)
        {
            using (QLNSDataContext qlNS = new QLNSDataContext())
            {
                try
                {
                    var luong = qlNS.LUONGs.FirstOrDefault(l => l.MaNV == maNV);
                    if (luong == null)
                    {
                        return false;
                    }

                    qlNS.LUONGs.DeleteOnSubmit(luong);
                    qlNS.SubmitChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
