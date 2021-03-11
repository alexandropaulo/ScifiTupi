using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScifiTupi.API.Data;
using ScifiTupi.API.Dtos;
using ScifiTupi.API.Models;

namespace ScifiTupi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IContentRepository _repo;

        public readonly IMapper _mapper; 

        public ArticleController(IContentRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("{alias}")]

        public async Task<IActionResult> GetValue(int alias)
        {
            //var article = await _context.Articles.FirstOrDefaultAsync(x => x.Alias == alias);
            var article = await _repo.GetArticle(alias);

            article.Hits++;
            if (!await _repo.SaveAll())
                throw new Exception ($"Updating User {alias} failed on save");
                
            var articleForReturn = _mapper.Map<ArticleForReadingDto>(article);
            return Ok(articleForReturn);

        }

                // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
  
    }
}