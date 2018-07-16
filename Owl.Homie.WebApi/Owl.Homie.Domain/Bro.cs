using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Owl.Homie.Domain
{
    [Table(("Bro"))]
    public class Bro : WeChatProfile
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string NickName { get; set; }
        public int Index { get; set; }
        public bool IsNext { get; set; }
        public int BeUrged { get; set; }
        public AccountStatus AccountStatus { get; set; }
    }

    public class WeChatProfile
    {
        public string Wx_openId { get; set; }
        public string Wx_userinfo { get; set; }
    }

    public enum AccountStatus
    {
        未加入 = 0,
        加入,
        停用
    }
}
