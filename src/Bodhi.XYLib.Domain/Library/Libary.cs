using Bodhi.XYLib.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Bodhi.XYLib
{
    /// <summary>
    /// 图书馆
    /// </summary>
    public class Libary : CreationAuditedEntity<long>
    {
        /// <summary>
        /// 所属用户
        /// </summary>
        //public IdentityUser User { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [StringLength(maximumLength:100,MinimumLength =2)]        
        public virtual string LibName { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public virtual string LibAddress { get; set; }
        /// <summary>
        /// 是否共享，由admin来确定
        /// </summary>
        public virtual bool Share { get; set; }

        public ICollection<BookInfo> Books { get; set; }

    }
}
