using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace QLNS_LinQ
{
     class BL_Export
    {
        public BL_Export()
        {

        }
        public void ExportToExcelNhanVien(SaveFileDialog saveFileDialog)
        {
            QLNSDataContext db = new QLNSDataContext();
            var nhanvienData = from n in db.NHANVIENs
                               select n;

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("NHANVIEN");
                worksheet.Cells[1, 1].Value = "Mã NV";
                worksheet.Cells[1, 2].Value = "Họ tên";
                worksheet.Cells[1, 3].Value = "Ngày sinh";
                worksheet.Cells[1, 4].Value = "Địa chỉ";
                worksheet.Cells[1, 5].Value = "Mã NQL";
                worksheet.Cells[1, 6].Value = "Phòng";
                int row = 2;
                foreach (var nhanvien in nhanvienData)
                {
                    worksheet.Cells[row, 1].Value = nhanvien.MaNV;
                    worksheet.Cells[row, 2].Value = nhanvien.HotenNV;
                    worksheet.Cells[row, 3].Value = nhanvien.NgSinh;
                    worksheet.Cells[row, 4].Value = nhanvien.Dchi;
                    worksheet.Cells[row, 5].Value = nhanvien.MaNQL;
                    worksheet.Cells[row, 6].Value = nhanvien.Phong;
                    row++;
                }
                excelPackage.SaveAs(new FileInfo(saveFileDialog.FileName));
            }
        }
        public void ExportToExcelPhongBan(SaveFileDialog saveFileDialog)
        {
            QLNSDataContext db = new QLNSDataContext();
            var phongbanData = from n in db.PHONGBANs
                           select n;
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("PHONGBAN");
                worksheet.Cells[1, 1].Value = "Mã PB";
                worksheet.Cells[1, 2].Value = "Tên PB";
                worksheet.Cells[1, 3].Value = "Trưởng phòng";
                worksheet.Cells[1, 4].Value = "Ngày nhận chức";
                worksheet.Cells[1, 5].Value = "Địa điểm";
                int row = 2;
                foreach (var pb in phongbanData)
                {
                    worksheet.Cells[row, 1].Value = pb.MaPB;
                    worksheet.Cells[row, 2].Value = pb.TenPB;
                    worksheet.Cells[row, 3].Value = pb.TrPhong;
                    worksheet.Cells[row, 4].Value = pb.NgNhanChuc;
                    worksheet.Cells[row, 5].Value = pb.DiaDiem;
                    row++;
                }
                excelPackage.SaveAs(new FileInfo(saveFileDialog.FileName));
            }
        }

        public void ExportToExcelnDuAn(SaveFileDialog saveFileDialog)
        {
            QLNSDataContext db = new QLNSDataContext();
            var duanData = from n in db.DUANs
                           select n;
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("DUAN");
                worksheet.Cells[1, 1].Value = "Mã DA";
                worksheet.Cells[1, 2].Value = "Tên DA";
                worksheet.Cells[1, 3].Value = "Địa điểm";
                worksheet.Cells[1, 4].Value = "Phòng";
                int row = 2;
                foreach (var duan in duanData)
                {
                    worksheet.Cells[row, 1].Value = duan.MaDA;
                    worksheet.Cells[row, 2].Value = duan.TenDA;
                    worksheet.Cells[row, 3].Value = duan.DiaDiem;
                    worksheet.Cells[row, 4].Value = duan.Phong;
                    row++;
                }
                excelPackage.SaveAs(new FileInfo(saveFileDialog.FileName));
            }
        }

        public void ExportToExcelHopDong(SaveFileDialog saveFileDialog)
        {
            QLNSDataContext db = new QLNSDataContext();
            var hopDong = from n in db.HOPDONGs
                               select n;

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("HOPDONG");
                worksheet.Cells[1, 1].Value = "Mã HĐ";
                worksheet.Cells[1, 2].Value = "Thời hạn";
                worksheet.Cells[1, 3].Value = "Vị trí";
                worksheet.Cells[1, 4].Value = "Mô tả";
                int row = 2;
                foreach (var hd in hopDong)
                {
                    worksheet.Cells[row, 1].Value = hd.MaHD;
                    worksheet.Cells[row, 2].Value = hd.ThoiHan;
                    worksheet.Cells[row, 3].Value = hd.ViTri;
                    worksheet.Cells[row, 4].Value = hd.MoTa;
                    row++;
                }
                excelPackage.SaveAs(new FileInfo(saveFileDialog.FileName));
            }
        }
    }
}
