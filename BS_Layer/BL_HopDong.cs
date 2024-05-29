using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_LinQ
{
    class BL_HopDong
    {
        public List<string> GetAllMaHD()
        {
            using (var context = new QLNSDataContext())
            {
                var maHDList = context.HOPDONGs.Select(hd => hd.MaHD).ToList();
                return maHDList;
            }
        }
        public List<string> GetAllViTri()
        {
            using (var context = new QLNSDataContext())
            {
                var viTriList = context.HOPDONGs.Select(hd => hd.ViTri).ToList();
                return viTriList;
            }
        }
        public System.Data.Linq.Table<HOPDONG> LayHopDong()
        {
            DataSet ds = new DataSet();
            QLNSDataContext qlNS = new QLNSDataContext();
            return qlNS.HOPDONGs;
        }
        public bool CapNhatHopDong(string maHD, int thoiHan, string viTri, string moTa)
        {
            QLNSDataContext db = new QLNSDataContext();
            try
            {

                var hopDong = db.HOPDONGs.FirstOrDefault(nv => nv.MaHD == maHD);
                if (hopDong == null)
                {
                    return false;
                }
                hopDong.ThoiHan = thoiHan;
                hopDong.ViTri = viTri;
                hopDong.MoTa = moTa;
                db.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ThemHopDong(string maHD, int thoiHan, string viTri, string moTa)
        {
            QLNSDataContext qlNS = new QLNSDataContext();
            try
            {
                HOPDONG hd = new HOPDONG();
                hd.MaHD = maHD;
                hd.ThoiHan = thoiHan;
                hd.ViTri = viTri;
                hd.MoTa = moTa;
                qlNS.HOPDONGs.InsertOnSubmit(hd);
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
