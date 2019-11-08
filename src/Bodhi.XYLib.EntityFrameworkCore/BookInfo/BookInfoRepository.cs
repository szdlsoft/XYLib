using Bodhi.XYLib.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Bodhi.XYLib
{
    public class BookInfoRepository : EfCoreRepository<XYLibDbContext, BookInfo,long>
                                     , IBookInfoRepository
    {
        public BookInfoRepository(IDbContextProvider<XYLibDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        protected override IQueryable<BookInfo> GetQueryable()
        {
            return base.GetQueryable().Include(b => b.Libary);
        }

    }
}
