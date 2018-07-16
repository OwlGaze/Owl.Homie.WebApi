using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Owl.Homie.Domain;

namespace Owl.Homie.Application
{
    public class BroService : IBroService
    {
        private readonly HomieDbContext _db;

        public BroService(HomieDbContext db)
        {
            this._db = db;
        }
        public Bro Get(Guid id)
        {
            return _db.Bros.Find(id);
        }

        public Bro GetByOpenId(string openId)
        {
            return _db.Bros.Single(d => d.Wx_openId == openId);
        }

        public Bro GetByKeyWord(string keyword)
        {
            return _db.Bros.Single(d => d.WxKeyWord == keyword);
        }
    }
}
