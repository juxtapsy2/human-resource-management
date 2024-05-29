using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_LinQ
{
     class BL_PhongBan
    {
        public List<string> GetAllMaPB()
        {
            using (var context = new QLNSDataContext())
            {
                var maPBList = context.PHONGBANs.Select(pb => pb.MaPB).ToList();
                return maPBList;
            }
        }
        public List<PHONGBAN> LayPhongBan()
        {
            using (QLNSDataContext qlNS = new QLNSDataContext())
            {
                return qlNS.PHONGBANs.ToList();
            }
        }

        public bool CapNhatPhongBan(string maPB, string tenPB, string trPhong, DateTime ngNhanChuc, string diaDiem)
        {
            using (QLNSDataContext qlNS = new QLNSDataContext())
            {
                try
                {
                    var phongBan = qlNS.PHONGBANs.FirstOrDefault(pb => pb.MaPB == maPB);
                    if (phongBan == null)
                    {
                        return false;
                    }

                    phongBan.TenPB = tenPB;
                    phongBan.TrPhong = trPhong;
                    phongBan.NgNhanChuc = ngNhanChuc;
                    phongBan.DiaDiem = diaDiem;

                    qlNS.SubmitChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool ThemPhongBan(string maPB, string tenPB, string trPhong, DateTime ngNhanChuc, string diaDiem)
        {
            using (QLNSDataContext qlNS = new QLNSDataContext())
            {
                try
                {
                    PHONGBAN phongBan = new PHONGBAN();
                    phongBan.MaPB = maPB;
                    phongBan.TenPB = tenPB;
                    phongBan.TrPhong = trPhong;
                    phongBan.NgNhanChuc = ngNhanChuc;
                    phongBan.DiaDiem = diaDiem;

                    qlNS.PHONGBANs.InsertOnSubmit(phongBan);
                    qlNS.SubmitChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool XoaPhongBan(string maPB)
        {
            using (QLNSDataContext qlNS = new QLNSDataContext())
            {
                try
                {
                    var phongBan = qlNS.PHONGBANs.FirstOrDefault(pb => pb.MaPB == maPB);
                    if (phongBan == null)
                    {
                        return false;
                    }

                    qlNS.PHONGBANs.DeleteOnSubmit(phongBan);
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
