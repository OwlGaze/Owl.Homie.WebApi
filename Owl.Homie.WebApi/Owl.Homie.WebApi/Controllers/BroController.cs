using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Owl.Homie.Application;

namespace Owl.Homie.WebApi.Controllers
{
    public class BroController : BaseController
    {
        private readonly IBroService _broService;

        public BroController(IBroService broService)
        {
            this._broService = broService;
        }
        //[HttpGet("{id:guid}")]
        //public IActionResult Get(Guid id)
        //{
        //    return Ok(_broService.Get(id));
        //}

        //[HttpGet("{openid}")]
        //public IActionResult GetByOpenId(string openId)
        //{
        //    if (string.IsNullOrEmpty(openId))
        //        return BadRequest();
        //    return Ok(_broService.GetByOpenId(openId));
        //}

        //[HttpGet("{keyword}")]
        //public IActionResult GetByKeyWord(string keyword)
        //{
        //    if (string.IsNullOrEmpty(keyword))
        //        return BadRequest();
        //    return Ok(_broService.GetByKeyWord(keyword));
        //}


    }
}