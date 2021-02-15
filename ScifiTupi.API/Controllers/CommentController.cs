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
    public class CommentController : ControllerBase
    {
        private readonly DataContext _context;


        public CommentController(DataContext context)
        {
            _context = context;

        }

        [HttpGet("{cid}")]

        public async Task<IActionResult> GetValue(int cid)
        {
            var comment = await _context.Comments.FirstOrDefaultAsync(x => x.Cid == cid);
            return Ok(comment);

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