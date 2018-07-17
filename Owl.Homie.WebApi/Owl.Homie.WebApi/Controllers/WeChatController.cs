using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Owl.Homie.WebApi.Controllers
{
    public class WeChatController : BaseController
    {
        [HttpGet("[action]/{code}")]
        public IActionResult GetOpenId(string code)
        {
            return View();
        }
    }
}