using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bodhi.XYLib
{
    public class LibaryDto : Volo.Abp.Application.Dtos.AuditedEntityDto<long>
    {
        public virtual string LibName { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public virtual string LibAddress { get; set; }
    }
}
