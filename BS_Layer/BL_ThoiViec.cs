using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace QLNS_EntityFramework.BS_Layer
{
   class BL_ThoiViec
    {
        public DataTable LayThoiViec()
        {
            QLNSEntities qlnsEntity = new QLNSEntities();
            var thoiViecs =
                from tv in qlnsEntity.THOIVIECs
                select new
                {
                    tv.MaNVThoiViec,
                    tv.MaHD,
                    tv.NgayThoiViec,
                    tv.LyDo
                };

            DataTable dt = new DataTable();
            dt.Columns.Add("MaNVThoiViec");
            dt.Columns.Add("MaHD");
            dt.Columns.Add("NgayThoiViec");
            dt.Columns.Add("LyDo");

            foreach (var tv in thoiViecs)
            {
                dt.Rows.Add(tv.MaNVThoiViec, tv.MaHD, tv.NgayThoiViec, tv.LyDo);
            }
            return dt;
        }

        public bool ThemThoiViec(string maNVThoiViec, string maHD, DateTime ngayThoiViec, string lyDo)
        {
            QLNSEntities context = new QLNSEntities();
            try
            {
                var thoiViec = new THOIVIEC
                {
                    MaNVThoiViec = maNVThoiViec,
                    MaHD = maHD,
                    NgayThoiViec = ngayThoiViec,
                    LyDo = lyDo
                };

                context.THOIVIECs.Add(thoiViec);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CapNhatThoiViec(string maNVThoiViec, string maHD, DateTime ngayThoiViec, string lyDo)
        {
            QLNSEntities db = new QLNSEntities();
            try
            {
                var thoiViec = db.THOIVIECs.FirstOrDefault(tv => tv.MaNVThoiViec == maNVThoiViec);
                if (thoiViec == null)
                {
                    return false;
                }

                thoiViec.NgayThoiViec = ngayThoiViec;
                thoiViec.LyDo = lyDo;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaThoiViec(string maNVThoiViec)
        {
            QLNSEntities db = new QLNSEntities();
            try
            {
                var thoiViec = db.THOIVIECs.FirstOrDefault(tv => tv.MaNVThoiViec == maNVThoiViec);
                if (thoiViec == null)
                {
                    return false;
                }

                db.THOIVIECs.Remove(thoiViec);
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
