using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_EntityFramework.BS_Layer
{
     class BL_Export
    {
        public void ExportToExcelnNhanVien(SaveFileDialog saveFileDialog)
        {
                QLNSEntities db = new QLNSEntities();
                var nhanvienData = from n in db.NHANVIENs
                                   select n;
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("NHANVIEN");
                    worksheet.Cells[1, 1].Value = "MaNV";
                    worksheet.Cells[1, 2].Value = "HoTen";
                    worksheet.Cells[1, 3].Value = "NgSinh";
                    worksheet.Cells[1, 4].Value = "Dchi";
                    worksheet.Cells[1, 5].Value = "MaNQL";
                    worksheet.Cells[1, 6].Value = "Phong";
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
        public void ExportToExcelnDuAn(SaveFileDialog saveFileDialog)
        {
            QLNSEntities db = new QLNSEntities();
            var duanData = from n in db.DUANs
                               select n;
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("DUAN");
                worksheet.Cells[1, 1].Value = "MaDA";
                worksheet.Cells[1, 2].Value = "TenDA";
                worksheet.Cells[1, 3].Value = "DiaDiem";
                worksheet.Cells[1, 4].Value = "Phong";
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
            QLNSEntities db = new QLNSEntities();
            var hopDong = from n in db.HOPDONGs
                           select n;
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("HOPDONG");
                worksheet.Cells[1, 1].Value = "MaHD";
                worksheet.Cells[1, 2].Value = "ThoiHan";
                worksheet.Cells[1, 3].Value = "ViTri";
                worksheet.Cells[1, 4].Value = "MoTa";
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
        public void ExportToExcelPhongBan(SaveFileDialog saveFileDialog)
        {
            QLNSEntities db = new QLNSEntities();
            var phongBan = from n in db.PHONGBANs
                           select n;
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("PHONGBAN");
                worksheet.Cells[1, 1].Value = "MaPB";
                worksheet.Cells[1, 2].Value = "TenPB";
                worksheet.Cells[1, 3].Value = "TrPhong";
                worksheet.Cells[1, 4].Value = "NgNhanChuc";
                worksheet.Cells[1, 5].Value = "DiaDiem";
                int row = 2;
                foreach (var pb in phongBan)
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
    }
}
