using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_LinQ
{
    class BL_PhanCong
    {
        public List<PHANCONG> LayPhanCong()
        {
            using (QLNSDataContext qlNS = new QLNSDataContext())
            {
                return qlNS.PHANCONGs.ToList();
            }
        }

        public bool CapNhatPhanCong(string maNV, string maDA, int thoiGian)
        {
            using (QLNSDataContext qlNS = new QLNSDataContext())
            {
                try
                {
                    var phanCong = qlNS.PHANCONGs.FirstOrDefault(pc => pc.MaNV == maNV && pc.MaDA == maDA);
                    if (phanCong == null)
                    {
                        return false;
                    }

                    phanCong.ThoiGian = thoiGian;
                    qlNS.SubmitChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool ThemPhanCong(string maNV, string maDA, int thoiGian)
        {
            using (QLNSDataContext qlNS = new QLNSDataContext())
            {
                try
                {
                    PHANCONG phanCong = new PHANCONG();
                    phanCong.MaNV = maNV;
                    phanCong.MaDA = maDA;
                    phanCong.ThoiGian = thoiGian;

                    qlNS.PHANCONGs.InsertOnSubmit(phanCong);
                    qlNS.SubmitChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool XoaPhanCong(string maNV)
        {
            using (QLNSDataContext qlNS = new QLNSDataContext())
            {
                try
                {
                    var phanCong = qlNS.PHANCONGs.FirstOrDefault(pc => pc.MaNV == maNV);
                    if (phanCong == null)
                    {
                        return false;
                    }

                    qlNS.PHANCONGs.DeleteOnSubmit(phanCong);
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
