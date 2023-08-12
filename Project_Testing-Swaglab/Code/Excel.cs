using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Text;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace Final_Project
{
    public class Excel
    {

        Application excel = new Application();

        Workbook wb;
        Worksheet wh;

        public void OpenExcel(string path, int sheet)
        {
            //Open the file Excel with Path 
            wb = excel.Workbooks.Open(path);

            //Choose  a sheet form Workbook
            wh = wb.Worksheets[sheet];

        }
        //Read Cell from WorkBooks
        public string ReadExcel(int c, int r)
        {

            return wh.Cells[c][r].value;

        }

        
        public void WriteExcel(int c, int r, string data)
        {

            wh.Cells[c][r].Value2 = data;

            Range cell = wh.Range["A1:A1"];
            cell.Value = data;

            wb.Save();


        }
        public void Save()
        {
            wb.Save();
        }
         public void SaveAs()
        {
            wb.SaveAs(@"C:\Users\DELL\Downloads\Documents\Tahaluf Training\QA-tools\Excel\Google1.xlsx",1);
        }
        //Close a Excel workbook 
        public void CloseExcel()
        {

            excel.Workbooks.Close();
        }
    }
}
