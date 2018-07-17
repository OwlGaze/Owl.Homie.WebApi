using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Owl.Homie.Domain;
using Owl.Homie.Repository;

namespace Owl.Homie.Application
{
    public class BroService : IBroService
    {
        private readonly IBroRepository _broRepository;

        public BroService(IBroRepository broRepository)
        {
            this._broRepository = broRepository;
        }
       
    }
}
