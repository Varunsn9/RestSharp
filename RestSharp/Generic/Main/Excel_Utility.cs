using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp.Generic.Main
{
    public class Excel_Utility
    {

        public string ExcelData()
        {
            string filePath = IPathConstants.excelPath;
            Application excel = new Application();
            Workbook wb = excel.Workbooks.Open(filePath);
            Worksheet ws = wb.Worksheets["Title"];

            Range range = ws.UsedRange;

            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                    {
                        Console.WriteLine(range.Cells[i, j].Value2.ToString());
                    }
                }
            }
            return string.Empty;
        }


        public static string GetCellValue(string filePath, string sheetName, string cellAddress)
        {
            string cellValue = null;
            Application excel = new Application();
            Workbook wb = excel.Workbooks.Open(filePath);

            try
            {
                // Get the worksheet by name
                Worksheet ws = wb.Worksheets[sheetName];

                // Get the cell by address
                Range cell = ws.Range[cellAddress];

                // Get the value of the cell
                if (cell != null && cell.Value != null)
                {
                    cellValue = cell.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Close the workbook and release objects from memory
                wb.Close();
                excel.Quit();
                Marshal.ReleaseComObject(wb);
                Marshal.ReleaseComObject(excel);
            }

            return cellValue;
        }
    }
}
