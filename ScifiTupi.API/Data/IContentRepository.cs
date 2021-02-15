using System.Collections.Generic;
using System.Threading.Tasks;
using ScifiTupi.API.Models;

namespace ScifiTupi.API.Data
{
    public interface IContentRepository
    {
         void Add<T>(T entity) where T: class; /*Método para adicionar qualquer entidade substituindo T*/
         void Delete<T>(T entity) where T: class;

         Task<bool> SaveAll();
         Task<IEnumerable<Article>> GetContent(int page);
         Task<Article> GetArticle(int id);
         Task<Article> GetArticleToEdit(int id);
         Task<IEnumerable<Article>> GetContentToEdit(int page);

         Task<Comment> GetComment(int id);
         Task<IEnumerable<Comment>> GetContentComments(int page);         
         Task<Comment> GetCommentToEdit(int id);
         Task<IEnumerable<Comment>> GetContentCommentsToEdit(int page);
    }
}