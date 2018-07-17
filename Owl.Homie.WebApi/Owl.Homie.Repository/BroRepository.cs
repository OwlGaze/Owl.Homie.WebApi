using System;
using Owl.Homie.Domain;
using System.Linq;

namespace Owl.Homie.Repository
{
    public class BroRepository: IBroRepository
    {
        private readonly HomieDbContext _db;

        public BroRepository(HomieDbContext db)
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
