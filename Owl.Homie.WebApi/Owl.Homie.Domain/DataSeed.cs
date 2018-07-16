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
                new Bro{Name = "铭",NickName = "铭哥",Index = 1,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.加入},
                new Bro{Name = "乔",NickName = "乔大爷",Index = 1,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.加入},
                new Bro{Name = "勇",NickName = "勇哥",Index = 1,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.加入},
                new Bro{Name = "欣",NickName = "欣哥",Index = 1,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.加入},
                new Bro{Name = "玺",NickName = "玺哥",Index = 1,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.加入},
                new Bro{Name = "熹",NickName = "熹哥",Index = 1,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.加入},
                new Bro{Name = "攀",NickName = "攀哥",Index = 1,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.加入},
                new Bro{Name = "铭",NickName = "铭哥",Index = 1,IsNext = true,BeUrged = 0,AccountStatus = AccountStatus.加入},
            };
        }
    }
}
