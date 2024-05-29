using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_LinQ
{
    class BL_ThoiViec
    {
        public List<THOIVIEC> LayThoiViec()
        {
            using (QLNSDataContext qlNS = new QLNSDataContext())
            {
                return qlNS.THOIVIECs
                    .AsEnumerable()
                    .Select(tv => new THOIVIEC
                    {
                        MaNVThoiViec = tv.MaNVThoiViec,
                        MaHD = tv.MaHD,
                        NgayThoiViec = tv.NgayThoiViec,
                        LyDo = tv.LyDo
                    })
                    .ToList();
            }
        }
        public bool CapNhatThoiViec(string maNVThoiViec, string maHD, DateTime ngayThoiViec, string lyDo)
        {
            using (QLNSDataContext qlNS = new QLNSDataContext())
            {
                try
                {
                    var thoiViec = qlNS.THOIVIECs.FirstOrDefault(tv => tv.MaNVThoiViec == maNVThoiViec);
                    if (thoiViec == null)
                    {
                        return false;
                    }

                    thoiViec.NgayThoiViec = ngayThoiViec;
                    thoiViec.LyDo = lyDo;

                    qlNS.SubmitChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool ThemThoiViec(string maNVThoiViec, string maHD, DateTime ngayThoiViec, string lyDo)
        {
            using (QLNSDataContext qlNS = new QLNSDataContext())
            {
                try
                {
                    THOIVIEC thoiViec = new THOIVIEC();
                    thoiViec.MaNVThoiViec = maNVThoiViec;
                    thoiViec.MaHD = maHD;
                    thoiViec.NgayThoiViec = ngayThoiViec;
                    thoiViec.LyDo = lyDo;

                    qlNS.THOIVIECs.InsertOnSubmit(thoiViec);
                    qlNS.SubmitChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool XoaThoiViec(string maNVThoiViec)
        {
            using (QLNSDataContext qlNS = new QLNSDataContext())
            {
                try
                {
                    var thoiViec = qlNS.THOIVIECs.FirstOrDefault(tv => tv.MaNVThoiViec == maNVThoiViec);
                    if (thoiViec == null)
                    {
                        return false;
                    }

                    qlNS.THOIVIECs.DeleteOnSubmit(thoiViec);
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
