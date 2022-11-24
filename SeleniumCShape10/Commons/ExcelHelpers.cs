using NPOI.SS.UserModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCShape10.Commons
{
    public class ExcelHelpers
    {
        //Html Table : 
        //try/TD/Th

        /// <summary>
        /// /workbook
        /// workshett
        /// row
        /// colum
        /// cell
        /// 
        /// </summary>
        /// <param name="rowNumber"></param>
        /// <returns></returns>

        public Dictionary<String, String> ReadExcelRowByRow(int rowNumber)
        {
            string fname = @"D:\TestAutomation\SeleniumCShape10\SeleniumCShape10\TestData\TestFile.xlsx";

            IWorkbook workbook = WorkbookFactory.Create(new FileStream(Path.GetFullPath(fname), FileMode.Open, FileAccess.Read, FileShare.ReadWrite));

            Dictionary<String, String> ReadExcelDataValue = new Dictionary<string, string>();

            ISheet worSheet = workbook.GetSheetAt(0);

            int RowCount = worSheet.LastRowNum;
            int ColumnsCount = worSheet.GetRow(0).PhysicalNumberOfCells;

            string ColumnValue = "";
            string RowValue = "";

            DataFormatter formatter = new DataFormatter();//Formatter will work fine for cell value.

            for (int ColumnIndex = 0; ColumnIndex < ColumnsCount; ColumnIndex++) //Loop the records upto filled row  
            {
                if (worSheet.GetRow(ColumnsCount) == null)  //null is when the row only contains empty cells   
                {
                    ColumnValue = worSheet.GetRow(0).GetCell(ColumnIndex).StringCellValue; //Here for sample , I just save the value in "value" field, Here you can write your custom logics...  
                    RowValue = formatter.FormatCellValue(worSheet.GetRow(rowNumber).GetCell(ColumnIndex));

                }

                ReadExcelDataValue.Add(ColumnValue, RowValue);
                // Console.WriteLine(rowNumber +  "   "+  "ColoumnValue" + " = " +   ColumnValue +   "   "+ "Row Value = " + RowValue);
                Console.WriteLine();


            }

            return ReadExcelDataValue;
        }

        [Test]
        public void ReadExlerRowbyrowTest()
        {
            ExcelHelpers readDictionary = new ExcelHelpers();
            for (int i = 1; i <= 2; i++)
            {

                Dictionary<String, String> dicValues = readDictionary.ReadExcelRowByRow(i);

                Console.WriteLine("Value of i is " + i + "= Coloumn = " + dicValues["UserName"].ToString());
                Console.WriteLine("Value of i is " + i + "= Coloumn = " + dicValues["Password"].ToString());

            }
        }
    }
}
