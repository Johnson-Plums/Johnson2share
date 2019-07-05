using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Travel_Experts
{
    //Create a to convert gridview tables to print out as pdf or excel
    class Exportto
    {// convert to excel by in put grid view, file name and save file dialog
        public static void Excel(DataGridView dgvName, string excelFileName, SaveFileDialog sfdName)
        {
            dgvName.AllowUserToAddRows = true;
            _Application excel = new Microsoft.Office.Interop.Excel.Application(); 
            _Workbook workbook = excel.Workbooks.Add(Type.Missing); 
            _Worksheet worksheet = null; 
            try
            {
                worksheet = workbook.ActiveSheet; 
                worksheet.Name = excelFileName;
                // write header
                for (int i = 1; i < dgvName.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvName.Columns[i - 1].HeaderText;
                }
                // write row by row and column by column
                for (int rowIndex = 0; rowIndex < dgvName.Rows.Count - 1; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < dgvName.Columns.Count; colIndex++)
                    {
                        worksheet.Cells[rowIndex + 2, colIndex + 1] = dgvName.Rows[rowIndex].Cells[colIndex].Value.ToString();
                    }
                }
                // dialog handle
                if (sfdName.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfdName.FileName);
                    Process.Start("excel.exe", sfdName.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null; //make workbook object null
                excel = null;
            }
            dgvName.AllowUserToAddRows = false;
        }

        // Create a methold to convert gridview to pdf file
        public static void Pdf(DataGridView dgw, string filename, SaveFileDialog sfdName)
        {
            dgw.AllowUserToAddRows = false;
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
// add column header
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
// add row by row
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            sfdName.FileName = filename;
            // handle diaglog
            if (sfdName.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(sfdName.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                    Process.Start(sfdName.FileName);
                }
            }
            dgw.AllowUserToAddRows = true;
        }
    }   
}
