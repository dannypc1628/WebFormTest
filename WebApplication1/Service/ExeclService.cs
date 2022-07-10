using ClosedXML.Excel;
using System.Linq;

namespace WebApplication1.Service
{
    public class ExeclService
    {
        public void SetExcel(string path)
        {
            var wb = new XLWorkbook(path);

            var ws = wb.Worksheets.First();

            ws.Cells("A1").Value = "已修改";
            ws.Cells("A2").Value = "成功";
            ws.Range("B2:D2").Row(1).Merge();
            ws.Cells("B2").Value = "測試合併有沒有成功";
            ws.Cell("B2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Cell("B2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Cell("B2").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            ws.Cell("B2").Style.Border.OutsideBorderColor = XLColor.Black;

            wb.Save();
        }

    }
}