using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Owl.Homie.Domain
{
    /// <summary>
    /// 催促
    /// </summary>
    [Table("Urge")]
    public class Urge
    {
        public Guid Id { get; set; }
        public Guid FromId { get; set; }
        public Guid ToId { get; set; }
        public DateTime UrgeTime { get; set; }
        public string Content { get; set; }
    }
}
