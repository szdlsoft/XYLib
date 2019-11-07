using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bodhi.XYLib.Util
{
    public static class ExcelPackageExtensions
    {
        public static string GetString(this ExcelWorksheet sheet, string addr)
        {
            return sheet.Cells[addr].Value?.ToString();
        }

        public static int GetInt(this ExcelWorksheet sheet, string addr)
        {
            var s = sheet.GetString(addr);
            if( s != null)
            {
                if( int.TryParse(s, out int r))
                {
                    return r;
                }
            }

            return 0;
        }

    }
}
