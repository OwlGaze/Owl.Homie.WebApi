using System;
using System.Collections.Generic;
using System.Text;
using Owl.Homie.Domain;

namespace Owl.Homie.Application
{
    public interface IBroService
    {
        Bro Get(Guid id);
        Bro GetByOpenId(string openId);
        Bro GetByKeyWord(string keyword);
    }
}
