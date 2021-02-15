using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScifiTupi.API.Data;
using ScifiTupi.API.Dtos;

namespace Scifitupi.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        // GET api/content

        private readonly IContentRepository _repo;
        private readonly IMapper _mapper;

        public ContentController(IContentRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var articles = await _repo.GetContent(0);
            var articlesToReturn = _mapper.Map<IEnumerable<ArticleForContentDto>>(articles);
            return Ok(articlesToReturn);
        }

        [HttpGet("{page}")]
        public async Task<IActionResult> GetValue(int page)
        {
            var articles = await _repo.GetContent(page);
            var articlesToReturn = _mapper.Map<IEnumerable<ArticleForContentDto>>(articles);
            return Ok(articlesToReturn);
        }
    }
}