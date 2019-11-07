using AutoMapper;

namespace Bodhi.XYLib
{
    public class XYLibApplicationAutoMapperProfile : Profile
    {
        public XYLibApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<BookInfo, BookInfoDto>();
            CreateMap<BookInfoDto, BookInfo>();

            CreateMap<Libary, LibaryDto>();
            CreateMap<LibaryDto, Libary>();
        }
    }
}
