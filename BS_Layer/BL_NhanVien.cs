using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_EntityFramework.BS_Layer
{
    class BL_NhanVien
    {
        public List<string> GetAllMaNV()
        {
            using (var context = new QLNSEntities())
            {
                var maNVList = context.NHANVIENs.Select(nv => nv.MaNV).ToList();
                return maNVList;
            }
        }
        public DataTable LayNhanVien()
        {
            QLNSEntities qlnsEntity = new QLNSEntities();
            var nvs =
            from p in qlnsEntity.NHANVIENs
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("MaNV");
            dt.Columns.Add("MaHD");
            dt.Columns.Add("HotenNV");
            dt.Columns.Add("NgSinh");
            dt.Columns.Add("Dchi");
            dt.Columns.Add("Phai");
            dt.Columns.Add("MaNQL");
            dt.Columns.Add("Phong");
            foreach (var p in nvs)
            {
                dt.Rows.Add(p.MaNV, p.MaHD, p.HotenNV, p.NgSinh, p.Dchi, p.Phai, p.MaNQL, p.Phong);
            }
            return dt;
        }
        public bool ThemNhanVien(string maNV, string maHD, string hoteNV, DateTime ngSinh, string dChi, string Phai,  string maNQL, string phong, string Hinh, bool Excel, string txtFilePath)
        {
            try
            {
                using (var context = new QLNSEntities())
                {
                    var nhanVien = new NHANVIEN
                    {
                        MaNV = maNV,
                        MaHD = maHD,
                        HotenNV = hoteNV,
                        NgSinh = ngSinh,
                        Dchi = dChi,
                        Phai = Phai,
                        MaNQL = maNQL,
                        Phong = phong,
                        Hinh = Hinh
                    };

                    context.NHANVIENs.Add(nhanVien);
                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool CapNhatNhanVien(string maNV, string maHD, string hoteNV, DateTime ngSinh, string dChi, string Phai,  string maNQL, string phong, string Hinh)
        {
            try
            {
                using (var dbContext = new QLNSEntities())
                {
                    var nhanvien = dbContext.NHANVIENs.FirstOrDefault(nv => nv.MaNV == maNV);
                    if (nhanvien == null)
                    {
                        return false;
                    }

                    nhanvien.MaHD = maHD;
                    nhanvien.HotenNV = hoteNV;
                    nhanvien.NgSinh = ngSinh;
                    nhanvien.Dchi = dChi;
                    nhanvien.Phai = Phai;
                    nhanvien.MaNQL = maNQL;
                    nhanvien.Phong = phong;
                    nhanvien.Hinh = Hinh;

                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void XoaMaNQL(string maNV)
        {
            QLNSEntities db = new QLNSEntities();
                try
                {
                    var nhanVien = db.NHANVIENs.Where(nv => nv.MaNQL == maNV);

                    foreach (var nv in nhanVien)
                    {
                        nv.MaNQL = null;
                    }

                    db.SaveChanges();
                }
                catch (Exception ex)
                {

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
                using (var context = new QLNSEntities())
                {
                    var nhanVien = context.NHANVIENs.FirstOrDefault(nv => nv.MaNV == maNV);

                    if (nhanVien != null)
                    {
                        context.NHANVIENs.Remove(nhanVien);
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
                // Handle any exception that might occur while deleting the record
                return false;
            }
        }

    }
}
