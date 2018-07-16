using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;

namespace Owl.Homie.Domain
{
    public static class DataSeed
    {
        public static void Init(HomieDbContext db)
        {
            if (db.Bros.Any())
                return;
            var bros = new List<Bro>
            {
                new Bro{Name = "铭",NickName = "铭哥",WxKeyWord = "悠悠", Index = 1,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.加入},
                new Bro{Name = "乔",NickName = "乔大爷",WxKeyWord = "乔",Index = 2,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.加入},
                new Bro{Name = "勇",NickName = "勇哥",WxKeyWord = "勇",Index = 3,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.加入},
                new Bro{Name = "欣",NickName = "欣欣",WxKeyWord = "欣",Index = 4,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.加入},
                new Bro{Name = "玺",NickName = "玺哥",WxKeyWord = "玺",Index = 5,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.加入},
                new Bro{Name = "熹",NickName = "熹哥",WxKeyWord = "假",Index = 6,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.加入},
                new Bro{Name = "攀",NickName = "攀攀",WxKeyWord = "攀",Index = 7,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.加入},
                new Bro{Name = "锋",NickName = "阿锋",WxKeyWord = "锋",Index = 8,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.加入},

                new Bro{Name = "毅",NickName = "毅哥",WxKeyWord = "赵",Index = 0,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.停用},
                new Bro{Name = "宇",NickName = "宇妹儿",WxKeyWord = "宇",Index = 0,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.未加入},
                new Bro{Name = "波",NickName = "波波",WxKeyWord = "余",Index = 0,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.未加入},
            };
        }
    }
}
