using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Owl.Homie.Application;

namespace Owl.Homie.WebApi.Controllers
{
    public class RankController : BaseController
    {
        private readonly IRankService _rankService;

        public RankController(IRankService rankService)
        {
            this._rankService = rankService;
        }

        public IActionResult GetRankList()
        {
            return Ok(_rankService.GetRankList());
        }
    }
}