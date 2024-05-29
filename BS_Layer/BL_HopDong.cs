using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_EntityFramework.BS_Layer
{
    class BL_HopDong
    {
        public List<string> GetAllMaHD()
        {
            using (var context = new QLNSEntities())
            {
                var maHDList = context.HOPDONGs.Select(nv => nv.MaHD).ToList();
                return maHDList;
            }
        }
        public List<string> GetAllViTri() {
            using (var context = new QLNSEntities())
            {
                var viTriList = context.HOPDONGs.Select(hd => hd.ViTri).ToList();
                return viTriList;
            }
        }
        public DataTable LayHopDong()
        {
            QLNSEntities qlnsEntity = new QLNSEntities();
            var hopDongs =
                from hd in qlnsEntity.HOPDONGs
                select hd;
            DataTable dt = new DataTable();
            dt.Columns.Add("MaHD");
            dt.Columns.Add("ThoiHan");
            dt.Columns.Add("ViTri");
            dt.Columns.Add("MoTa");

            foreach (var hd in hopDongs)
            {
                dt.Rows.Add(hd.MaHD, hd.ThoiHan, hd.ViTri, hd.MoTa);
            }
            return dt;
        }

        public bool ThemHopDong(string maHD, int thoiHan, string viTri, string moTa)
        {
            QLNSEntities context = new QLNSEntities();
            try
            {
                var hopDong = new HOPDONG
                {
                    MaHD = maHD,
                    ThoiHan = thoiHan,
                    ViTri = viTri,
                    MoTa = moTa
                };

                context.HOPDONGs.Add(hopDong);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CapNhatHopDong(string maHD, int thoiHan, string viTri, string moTa)
        {
            QLNSEntities db = new QLNSEntities();
            try
            {
                var hopDong = db.HOPDONGs.FirstOrDefault(hd => hd.MaHD == maHD);
                if (hopDong == null)
                {
                    return false;
                }

                hopDong.ThoiHan = thoiHan;
                hopDong.ViTri = viTri;
                hopDong.MoTa = moTa;
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
