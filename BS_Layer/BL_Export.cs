using QLNS_ADO.NET.DB_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLNS_ADO.NET.BS_Layer
{
     class BL_Export
    {
        DBMain db = null;
      
        public BL_Export()
        {
          db = new DBMain();
        }
        public void ExportToExcel(string tableName, SaveFileDialog saveFileDialog)
        {
            string sql = $"SELECT * FROM {tableName}";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text, null);
            var excelApp = new Microsoft.Office.Interop.Excel.Application();

            var workbook = excelApp.Workbooks.Add();
            var worksheet = workbook.Sheets[1];

            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = ds.Tables[0].Columns[i].ColumnName;
            }

            int row = 2;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    worksheet.Cells[row, i + 1] = dr[i].ToString();
                }
                row++;
            }

            workbook.SaveAs(saveFileDialog.FileName);
            workbook.Close();
            excelApp.Quit();

        }
    }
}
