using Bodhi.XYLib.Util;
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
        public BookInfoAppService(IBookInfoRepository repository
                                 ,IRepository<Libary, long> libRepository) : base(repository)
        {
            _libRepository = libRepository;
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

        protected override BookInfoDto MapToGetListOutputDto(BookInfo entity)
        {
            var dto = base.MapToGetListOutputDto(entity);
            dto.LibName = entity.Libary?.LibName;
            dto.LibAddress = entity.Libary?.LibAddress;
            return dto;
        }

        protected override IQueryable<BookInfo> CreateFilteredQuery(PagedAndSortedResultRequestDto input)
        {
            var q = base.CreateFilteredQuery(input);

            return q;

        }

    }
}
