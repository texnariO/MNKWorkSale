using MNKWorkSale.Utiliteses;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNKWorkSale.Fragments.EMEX.CreateFileOptima
{
    internal class CoreCreateFileOptimaClientEmex
    {
        public static List<Position> positionsFromFile = new List<Position>();
        private double sumaryPricePosition=0.0;
        private int sumaryPositions = 0;
        private int sumaryCounts = 0;
        private string ErrorLabel = "";

        public string CreateFileOptimaClientEmex(string priceText, string positionText, string countsText, string FileName)
        {
            positionsFromFile.Clear();
            sumaryPricePosition = 0.0;
            sumaryPositions = 0;
            sumaryCounts = 0;
            ErrorLabel = "";
            FileInfo fileInfo = new FileInfo(FileName);
            using(ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                for(int row = 2; row <= worksheet.Dimension.Rows; row++)
                {
                    double tempPricePosition;
                    int tempCount;
                    double.TryParse(worksheet.Cells[row,10].Value.ToString(), out tempPricePosition);
                    int.TryParse(worksheet.Cells[row,11].Value.ToString(), out tempCount);
                    sumaryPricePosition += tempPricePosition*tempCount;
                    sumaryCounts += tempCount;
                    sumaryPositions++;
                    positionsFromFile.Add(new Position(worksheet.Cells[row, 5].Value.ToString(), worksheet.Cells[row, 7].Value.ToString(), tempPricePosition, tempCount));
                }
            }
            priceText = priceText.Replace(".", ",");
            double tempCheckPrice;
            double.TryParse(priceText,out tempCheckPrice);
            int tempCheckPositions;
            int.TryParse(positionText,out tempCheckPositions);
            int tempCheckCounts;
            int.TryParse(countsText,out tempCheckCounts);
            if(tempCheckPrice.Equals(sumaryPricePosition))
            {
                Console.WriteLine(sumaryPricePosition);
                Console.WriteLine(tempCheckPrice);
                Console.WriteLine(sumaryPricePosition - tempCheckPrice);
                ErrorLabel += "Сума не сходится " + tempCheckPrice + " - " + sumaryPricePosition;
            }
            if(tempCheckPositions!= sumaryPositions ) {
                ErrorLabel += "| Кількість позицій не сходиться " + tempCheckPositions + " - " + sumaryPositions;
            }
            if(tempCheckCounts!= sumaryCounts )
            {
                ErrorLabel += "| Кількість не сходится " + tempCheckCounts + sumaryCounts;
            }
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            using(StreamWriter sw = new StreamWriter(startupPath+"/Wynik/DWC/dwcOp.csv"))
            {
                sw.WriteLine(";Ilo;Cen");
                foreach(var item in positionsFromFile)
                {
                    sw.WriteLine(item.Kod + ";" + item.quantity + ";" + item.price);
                }
            }
            return ErrorLabel==""?"OK": ErrorLabel;
        }
    }
}
