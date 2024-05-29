using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_EntityFramework.BS_Layer
{
   class BL_ThanNhan
    {
        public DataTable LayThanhNhan()
        {
            QLNSEntities qlnsEntity = new QLNSEntities();
            var tns =
            from p in qlnsEntity.THANNHANs
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("MaNV");
            dt.Columns.Add("HotenTN");
            dt.Columns.Add("VaiTro");
            dt.Columns.Add("SDT");
         
            foreach (var p in tns)
            {
                dt.Rows.Add(p.MaNV, p.HotenTN, p.VaiTro, p.SDT);
            }
            return dt;
        }
        public bool ThemThanNhan(string maNV, string hoteTN, string vaiTro, string SDT)
        {
            QLNSEntities qlNS = new QLNSEntities();
            try
            {
                THANNHAN tn = new THANNHAN();
                tn.MaNV = maNV;
                tn.HotenTN = hoteTN;
                tn.VaiTro = vaiTro;
                tn.SDT = SDT;
                qlNS.THANNHANs.Add(tn);
                qlNS.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool CapNhatThanhNhan(string maNV, string hoteTN, string vaiTro, string SDT)
        {
            QLNSEntities qlNS = new QLNSEntities();
            try
            {
                var thanNhan = qlNS.THANNHANs.FirstOrDefault(tn => tn.MaNV == maNV);
                if (thanNhan == null)
                {
                    return false;
                }
                thanNhan.HotenTN = hoteTN;
                thanNhan.VaiTro = vaiTro;
                thanNhan.SDT = SDT;
                qlNS.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool XoaThanhNhan(string maNV)
        {
            try
            {
                using (var context = new QLNSEntities())
                {
                    var thanNhan = context.THANNHANs.FirstOrDefault(pc => pc.MaNV == maNV);

                    if (thanNhan != null)
                    {
                        context.THANNHANs.Remove(thanNhan);
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
                // Handle exception
                return false;
            }
        }
    }
}
