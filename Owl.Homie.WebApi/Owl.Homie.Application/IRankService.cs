using System;
using System.Collections.Generic;
using System.Text;
using Owl.Homie.Domain;

namespace Owl.Homie.Application
{
    public interface IRankService
    {
        IEnumerable<Bro> GetRankList();
    }
}
