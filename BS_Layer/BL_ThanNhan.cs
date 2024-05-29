using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_LinQ
{
    class BL_ThanNhan
    {
        public System.Data.Linq.Table<THANNHAN> LayThanNhan()
        {
            DataSet ds = new DataSet();
            QLNSDataContext qlNS = new QLNSDataContext();
            return qlNS.THANNHANs;
        }
        public bool ThemThanNhan(string maNV, string hoteTN, string vaiTro, string SDT)
        {
            QLNSDataContext qlNS = new QLNSDataContext();
            try
            {
                THANNHAN tn = new THANNHAN();
                tn.MaNV = maNV;
                tn.HotenTN = hoteTN;
                tn.VaiTro = vaiTro;
                tn.SDT = SDT;
                qlNS.THANNHANs.InsertOnSubmit(tn);
                qlNS.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CapNhatThanhNhan(string maNV, string hoteTN, string vaiTro, string SDT)
        {
            QLNSDataContext qlNS = new QLNSDataContext();
            try
            {
                    var thanNhan = qlNS.THANNHANs.FirstOrDefault(tn => tn.MaNV == maNV);
                    if (thanNhan == null)
                    {
                        return false;
                    }
                    thanNhan.HotenTN = hoteTN;
                    thanNhan.VaiTro= vaiTro;
                    thanNhan.SDT = SDT;
                    qlNS.SubmitChanges();
                    return true;
                
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool XoaThanhNhan(string maNV)
        {
            QLNSDataContext db = new QLNSDataContext();
            try
            {
                var thanNhan = db.THANNHANs.FirstOrDefault(pc => pc.MaNV == maNV);

                if (thanNhan != null)
                {
                    db.THANNHANs.DeleteOnSubmit(thanNhan);
                    db.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
