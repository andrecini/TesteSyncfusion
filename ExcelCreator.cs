using Syncfusion.XlsIO;
using System.Drawing;

namespace TesteSyncFusion
{
    class ExcelCreator
    {
        #region Singleton
        private static ExcelCreator _instance;

        public static ExcelCreator GetInstance()
        {
            if (_instance == null)
                _instance = new ExcelCreator();

            return _instance;
        }
        #endregion

        /// <summary>
        /// Cria o arquivo ".xlsx"
        /// </summary>
        /// <param name="namesPath">Endereço do arquivo com os nomes</param>
        /// <param name="statesPath">Endereço do arquivo com os Estados</param>
        public static void CreateExcel(string namesPath, string statesPath)
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;

                application.DefaultVersion = ExcelVersion.Excel2010;

                IWorkbook workbook = application.Workbooks.Create(1);

                IWorksheet worksheet = workbook.Worksheets[0];

                CompleteWorkSheet(worksheet, namesPath, statesPath);
                FormatCells(workbook, worksheet);

                workbook.SaveAs("PlanilhaDePessoas.xlsx");
                
            }
        }

        /// <summary>
        /// Formata as células do excel 
        /// </summary>
        /// <param name="workbook">Representa um MS Excel workbook</param>
        /// <param name="worksheet">Representa uma Planilha no workbook</param>
        private static void FormatCells(IWorkbook workbook, IWorksheet worksheet)
        {
            IStyle headerStyle = workbook.Styles.Add("HeaderStyle");
            headerStyle.BeginUpdate();
            headerStyle.Color = Color.FromArgb(255, 174, 33);
            headerStyle.Font.Bold = true;
            headerStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
            headerStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
            headerStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
            headerStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
            headerStyle.EndUpdate();

            //Add custom colors to the palette
            workbook.SetPaletteColor(9, Color.FromArgb(239, 243, 247));

            //Defining body style
            IStyle bodyStyle = workbook.Styles.Add("BodyStyle");
            bodyStyle.BeginUpdate();
            bodyStyle.Color = Color.FromArgb(239, 243, 247);
            bodyStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
            bodyStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
            bodyStyle.EndUpdate();

            //Apply Header style
            worksheet.Rows[0].CellStyle = headerStyle;
            //Apply Body Style
            worksheet.Range["A2:D101"].CellStyle = bodyStyle;
            //Auto-fit the columns
            worksheet.UsedRange.AutofitColumns();
        }

        /// <summary>
        /// Preenche as células da planilha no Excel
        /// </summary>
        /// <param name="worksheet">Representa uma Planilha no workbook</param>
        /// <param name="namesPath">Endereço do arquivo com os nomes</param>
        /// <param name="statesPath">Endereço do arquivo com os Estados</param>
        private static void CompleteWorkSheet(IWorksheet worksheet, string namesPath, string statesPath)
        {
            DataCreator dc = new DataCreator(namesPath, statesPath);

            worksheet.Range["A1"].Text = "ID";
            worksheet.Range["B1"].Text = "Nome";
            worksheet.Range["C1"].Text = "Idade";
            worksheet.Range["D1"].Text = "Estado";

            for (int i = 0; i < 100; i++)
            {
                worksheet.Range["A" + (i + 2).ToString()].Text = (i+1).ToString();
                worksheet.Range["B" + (i + 2).ToString()].Text = dc.names[i];
                worksheet.Range["C" + (i + 2).ToString()].Text = dc.ages[i].ToString();
                worksheet.Range["D" + (i + 2).ToString()].Text = dc.states[i];
            }
            
        }
    }
}
