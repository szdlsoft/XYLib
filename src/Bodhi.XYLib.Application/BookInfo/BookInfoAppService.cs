using Bodhi.XYLib.Util;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace Bodhi.XYLib
{
    public class BookInfoAppService : Volo.Abp.Application.Services.CrudAppService<BookInfo, BookInfoDto, long>
                                    , IBookInfoAppService
    {
        IRepository<Libary, long> _libRepository;
        public BookInfoAppService(IRepository<BookInfo, long> repository
                                 ,IRepository<Libary, long> libRepository) : base(repository)
        {
            _libRepository = libRepository;
        }

        public string Import(Stream formFileContent)
        {
            try
            {
                using(var package = new ExcelPackage(formFileContent))
                {
                    var ws = package.Workbook.Worksheets[0];

                    Libary lib = new Libary()
                    {
                        LibName = ws.GetString("B1"),
                        LibAddress = ws.GetString("B2")
                    };

                    lib.Books = new List<BookInfo>();
                    for(int row = 4; row < 10 * 1024; row++) // 最多10000册
                    {
                        if (ws.GetString($"C{row}") == null) break; //空行结束
                        lib.Books.Add(new BookInfo()
                        {
                            ISBN = ws.GetString($"B{row}"),
                            Title = ws.GetString($"C{row}"),
                            Owner = ws.GetString($"D{row}"),
                            Publisher = ws.GetString($"E{row}"),
                            Count = ws.GetInt($"F{row}"),
                            Place = ws.GetString($"G{row}"),
                        });                     
                    }

                    int number = BatchSave(lib);
                    return $"成功导入{number}条记录";
                }
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }

        private int BatchSave( Libary lib )
        {
            using( var uow = UnitOfWorkManager.Begin())
            {
                _libRepository.Insert(lib);
                uow.SaveChanges();
            }
            return lib.Books.Count;
        }

        protected override IQueryable<BookInfo> CreateFilteredQuery(PagedAndSortedResultRequestDto input)
        {
            var q = base.CreateFilteredQuery(input);

            return q;

        }

    }
}
