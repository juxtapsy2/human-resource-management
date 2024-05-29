using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_EntityFramework.BS_Layer
{
    class BL_TimKiem
    {
    
        public DataTable TimKiemNhanVien(string input, string propertyName)
        {
            QLNSEntities qlnsEntity = new QLNSEntities();
            IQueryable<NHANVIEN> nvs;
            if (propertyName == "Ma")
            {
                nvs = from p in qlnsEntity.NHANVIENs
                      where p.MaNV.Contains(input)
                      select p;
            }
            else
            {
                nvs = from p in qlnsEntity.NHANVIENs
                      where p.HotenNV.Contains(input)
                      select p;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("MaNV");
            dt.Columns.Add("MaHD");
            dt.Columns.Add("HotenNV");
            dt.Columns.Add("NgSinh");
            dt.Columns.Add("Dchi");
            dt.Columns.Add("Phai");
            dt.Columns.Add("MaNQL");
            dt.Columns.Add("Phong");
            dt.Columns.Add("Hinh");
            foreach (var p in nvs)
            {
                dt.Rows.Add(p.MaNV, p.MaHD, p.HotenNV, p.NgSinh, p.Dchi, p.Phai, p.MaNQL, p.Phong, p.Hinh);
            }
            return dt;
        }
        public DataTable TimKiemPhongBan(string input, string propertyName)
        {
            QLNSEntities qlnsEntity = new QLNSEntities();
 
            IQueryable<PHONGBAN> pbs;
            if (propertyName == "Ma")
            {
                pbs = from p in qlnsEntity.PHONGBANs
                      where p.MaPB.Contains(input)
                      select p;
            }
            else
            {
                pbs = from p in qlnsEntity.PHONGBANs
                      where p.TenPB.Contains(input)
                      select p;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("MaPB");
            dt.Columns.Add("TenPB");
            dt.Columns.Add("TrPhong");
            dt.Columns.Add("NgNhanChuc");
            dt.Columns.Add("Diadiem");
            foreach (var p in pbs)
            {
                dt.Rows.Add(p.MaPB, p.TenPB, p.TrPhong, p.NgNhanChuc, p.DiaDiem);
            }
            return dt;
        }
        public DataTable TimKiemDuAn(string input, string propertyName)
        {
            QLNSEntities qlnsEntity = new QLNSEntities();
            IQueryable<DUAN> das;
            if (propertyName == "Ma")
            {
                das = from p in qlnsEntity.DUANs
                      where p.MaDA.Contains(input)
                      select p;
            }
            else
            {
                das = from p in qlnsEntity.DUANs
                      where p.TenDA.Contains(input)
                      select p;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("MaDA");
            dt.Columns.Add("TenDA");
            dt.Columns.Add("DiaDiem");
            dt.Columns.Add("Phong");
            foreach (var p in das)
            {
                dt.Rows.Add(p.MaDA, p.TenDA, p.DiaDiem, p.Phong);
            }
            return dt;
        }
    }
}
