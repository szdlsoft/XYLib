using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Bodhi.XYLib
{
    public class BookInfo : CreationAuditedEntity<long>
    {
        public Libary Libary { get; set; }
        /// <summary>
        /// 索书号
        /// </summary>
        [StringLength(100)]

        public string ISBN { get; set; }
        /// <summary>
        /// 题名
        /// </summary>
        [StringLength(200)]
        [Required]
        public string Title { get; set; }
        /// <summary>
        /// 责任者
        /// </summary>
        [StringLength(100)]
        public string Owner { get; set; }
        /// <summary>
        /// 册数 
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 出版者
        /// </summary>
        [StringLength(200)]
        public string Publisher { get; set; }
        /// <summary>
        /// 馆藏地址
        /// </summary>
        [StringLength(200)]
        public string Place { get; set; }

    }
}
