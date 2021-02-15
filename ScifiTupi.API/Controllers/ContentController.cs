using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScifiTupi.API.Data;

namespace Scifitupi.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        // GET api/content

        private readonly IContentRepository _repo;

        public ContentController(IContentRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var articles = await _repo.GetContent(0);
            return Ok(articles);
        }

        [HttpGet("{page}")]
        public async Task<IActionResult> GetValue(int page)
        {
            var articles = await _repo.GetContent(page);
            return Ok(articles);
        }
    }
}