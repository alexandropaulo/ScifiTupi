using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScifiTupi.API.Data;

namespace ScifiTupi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly DataContext _context;


        public ArticleController(DataContext context)
        {
            _context = context;

        }

        [HttpGet("{alias}")]

        public async Task<IActionResult> GetValue(string alias)
        {
            var article = await _context.Articles.FirstOrDefaultAsync(x => x.Alias == alias);
            return Ok(article);

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