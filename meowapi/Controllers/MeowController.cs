using meowapi.Interfaces;
using meowapi.Models;
using meowapi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meowapi.Controllers
{
    [Route("meow")]
    [ApiController]
    public class MeowController : ControllerBase
    {
        private readonly IImgVideoService _imgVideoService;
        public MeowController(IImgVideoService imgVideoService)
        {
            _imgVideoService = imgVideoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<db_img_video>>> Get()
        {
            var iv = await _imgVideoService.GetAll();

            return Ok(iv);
        }

        [HttpGet("getbyid/{id}")]
        public async Task<ActionResult<db_img_video>> Get(string id)
        {
            var iv = await _imgVideoService.GetByIdAsync(id);

            return Ok(iv);
        }
    }
}
