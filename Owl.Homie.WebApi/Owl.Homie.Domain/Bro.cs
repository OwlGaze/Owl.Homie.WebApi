using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Owl.Homie.Domain
{
    [Table(("Bro"))]
    public class Bro : WxUserInfo
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string NickName { get; set; }
        public int Index { get; set; }
        public bool IsNext { get; set; }
        public int BeUrged { get; set; }
        public string WxKeyWord { get; set; }
        public AccountStatus AccountStatus { get; set; }
    }

    public class WxUserInfo
    {
        public string Wx_openId { get; set; }
        public string Wx_nickName { get; set; }
        public string Wx_avatarUrl { get; set; }
        public int Wx_gender { get; set; }
        public string Wx_province { get; set; }
        public string Wx_city { get; set; }
        public string Wx_country { get; set; }
    }

    public enum AccountStatus
    {
        未加入 = 0,
        加入,
        停用
    }
}
