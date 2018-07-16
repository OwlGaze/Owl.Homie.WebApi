using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Owl.Homie.Domain
{
    /// <summary>
    /// 活动，聚会
    /// </summary>
    [Table("Party")]
    public class Party
    {
        public Guid Id { get; set; }
        /// <summary>
        /// 发起人
        /// </summary>
        public Guid Initiator { get; set; }
        /// <summary>
        /// 预定时间
        /// </summary>
        public DateTime OrderTime { get; set; }
        /// <summary>
        /// 聚会时间
        /// </summary>
        public DateTime PartyTime { get; set; }
        /// <summary>
        /// 参与人数
        /// </summary>
        public int CountOfPartIn { get; set; }
    }

    /// <summary>
    /// 活动参与信息
    /// </summary>
    [Table("PartyItem")]
    public class PartyItem
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PartyId { get; set; }
        public Guid BroId{ get; set; }
        /// <summary>
        /// 到达时间
        /// </summary>
        public DateTime ArrivedTime { get; set; }
        /// <summary>
        /// 是否准时
        /// </summary>
        public bool IsOnTime { get; set; }
    }
}
