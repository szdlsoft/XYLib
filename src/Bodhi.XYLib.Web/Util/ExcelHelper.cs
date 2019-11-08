using Bodhi.XYLib.Util;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Bodhi.XYLib.Web.Util
{
    public static class ExcelHelper
    {
        public static int GetIntFromString(this IExcelDataReader reader, int col )
        {
            var s = reader.GetString(col);
            if( int.TryParse(s, out int r))
            {
                return r;
            }
            return 0;
        }
        internal static Libary Import(byte[] formFileContent)
        {
            using (var ms = new MemoryStream(formFileContent))
            using (var reader = ExcelReaderFactory.CreateReader(ms))
            {
                Libary lib = new Libary();
                lib.Books = new List<BookInfo>();
                int row = 1;
                while (reader.Read())
                {
                    if(row == 1)
                    {
                        lib.LibName =  reader.GetString(1);
                    }
                    if (row == 2)
                    {
                        lib.LibAddress = reader.GetString(1);
                    }
                    if( row >= 4)
                    {
                        lib.Books.Add(new BookInfo()
                        {
                            ISBN = reader.GetString(1),
                            Title = reader.GetString(2),
                            Owner = reader.GetString(3),
                            Publisher = reader.GetString(4),
                            Count = reader.GetIntFromString(5),
                            Place = reader.GetString(6),
                        });
                    }
                    row++;
                }               

                return lib;
            }
        }
    }
}
