using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_LinQ
{
     class BL_NhanVien
    {
       
        public System.Data.Linq.Table<NHANVIEN> LayNhanVien()
        {
            DataSet ds = new DataSet();
            QLNSDataContext qlNS = new  QLNSDataContext();
            return qlNS.NHANVIENs;
        }
        public List<string> GetAllMaNV()
        {
            using (var context = new QLNSDataContext())
            {
                var maNVList = context.NHANVIENs.Select(nv => nv.MaNV).ToList();
                return maNVList;
            }
        }
        public bool ThemNhanVien(string maNV, string maHD, string hoteNV, DateTime ngSinh, string dChi, string Phai, string maNQL, string phong, string Hinh, bool Excel, string txtFilePath)
        {
            QLNSDataContext qlNS = new QLNSDataContext();
            try
            {
                NHANVIEN nv = new NHANVIEN();
                nv.MaNV = maNV;
                nv.MaHD = maHD;
                nv.HotenNV = hoteNV;
                nv.NgSinh = ngSinh;
                nv.Dchi = dChi;
                nv.Phai = Phai;
                nv.MaNQL = maNQL;
                nv.Phong = phong;
                nv.Hinh = Hinh;

                qlNS.NHANVIENs.InsertOnSubmit(nv);
                qlNS.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CapNhatNhanVien(string maNV, string maHD, string hoteNV, DateTime ngSinh, string dChi, string Phai, string maNQL, string phong, string Hinh)
        {
            try
            {
                using (var db = new QLNSDataContext())
                {
                    var nhanVien = db.NHANVIENs.FirstOrDefault(nv => nv.MaNV == maNV);
                    if (nhanVien == null)
                    {
                        return false;
                    }
                    nhanVien.MaHD = maHD;
                    nhanVien.HotenNV = hoteNV;
                    nhanVien.NgSinh = ngSinh;
                    nhanVien.Dchi = dChi;
                    nhanVien.Phai = Phai;
                    nhanVien.MaNQL = maNQL;
                    nhanVien.Phong = phong;
                    nhanVien.Hinh = Hinh;
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void XoaMaNQL(string maNV)
        {
            QLNSDataContext db = new QLNSDataContext();
            try
            {
                var nhanVien = db.NHANVIENs.Where(nv => nv.MaNQL == maNV);

                foreach (var nv in nhanVien)
                {
                    nv.MaNQL = null;
                }

                db.SubmitChanges();
            }
            catch (Exception)
            {
                // Handle any exceptions here
            }
        }

        public bool XoaNhanVien(string maNV)
        {
            BL_PhanCong phancong = new BL_PhanCong();
            BL_ThanNhan thanNhan = new BL_ThanNhan();
            BL_Luong luong = new BL_Luong();
            XoaMaNQL(maNV);
            thanNhan.XoaThanhNhan(maNV);
            luong.XoaLuong(maNV);
            phancong.XoaPhanCong(maNV);
            try
            {
                using (var db = new QLNSDataContext())
                {
                    var nhanVien = db.NHANVIENs.FirstOrDefault(nv => nv.MaNV == maNV);
                    if (nhanVien == null)
                    {
                        return false;
                    }
                    db.NHANVIENs.DeleteOnSubmit(nhanVien);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
