using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;

namespace Bodhi.XYLib
{
    public interface IBookInfoAppService :
        Volo.Abp.Application.Services.ICrudAppService<BookInfoDto, long>
    {
        //string Import(Stream formFileContent);
    }
}
