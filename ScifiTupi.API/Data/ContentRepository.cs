using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScifiTupi.API.Models;

namespace ScifiTupi.API.Data
{
    public class ContentRepository : IContentRepository
    {
        private readonly DataContext _context;
        public ContentRepository(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<Article> GetArticle(int id)
        {
            var article = await _context.Articles.Where(x => x.State == 1)
                           .Include(c => c.Comments).FirstOrDefaultAsync(x => x.Id == id);
            return article;
        }
        public async Task<IEnumerable<Article>> GetContent(int page)
        {
            if (page == 0) {page = 1;}
            int pageSize = 5; 
            //var cont =  await _context.Articles.Where(x => x.State == 1).CountAsync();
            var articles = await _context.Articles.Where(x => x.State == 1).
                           OrderByDescending(x => x.CreatedDt).Skip((page - 1) * pageSize)
                           .Take(pageSize).AsNoTracking().ToListAsync();
            return articles;
        }

        public async Task<Article> GetArticleToEdit(int id)
        {
            var article = await _context.Articles
                           .Include(c => c.Comments).FirstOrDefaultAsync(x => x.Id == id);
            return article;
        }
        public async Task<IEnumerable<Article>> GetContentToEdit(int page)
        {
            if (page == 0) {page = 1;}
            int pageSize = 5; 
            //var cont =  await _context.Articles.Where(x => x.State == 1).CountAsync();
            var articles = await _context.Articles
                           .OrderByDescending(x => x.CreatedDt).Skip((page - 1) * pageSize)
                           .Take(pageSize).AsNoTracking().ToListAsync();
            return articles;
        }

        public async Task<Comment> GetComment(int id)
        {
            var comment = await _context.Comments.Where(x => x.Published == 1)
                           .FirstOrDefaultAsync(x => x.Id == id);
            return comment;
        }
        public async Task<IEnumerable<Comment>> GetContentComments(int page)
        {
            if (page == 0) {page = 1;}
            int pageSize = 5; 
            
            var comments = await _context.Comments.Where(x => x.Published == 1).
                           OrderByDescending(x => x.CreatedDt).Skip((page - 1) * pageSize)
                           .Take(pageSize).AsNoTracking().ToListAsync();
            return comments;
        }

        
        public async Task<Comment> GetCommentToEdit(int id)
        {
            var comment = await _context.Comments
                           .FirstOrDefaultAsync(x => x.Id == id);
            return comment;
        }
        public async Task<IEnumerable<Comment>> GetContentCommentsToEdit(int page)
        {
            if (page == 0) {page = 1;}
            int pageSize = 5; 
            
            var comments = await _context.Comments.
                           OrderByDescending(x => x.CreatedDt).Skip((page - 1) * pageSize)
                           .Take(pageSize).AsNoTracking().ToListAsync();
            return comments;
        }
    }
}