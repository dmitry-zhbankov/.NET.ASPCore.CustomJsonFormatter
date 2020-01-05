using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomJsonFormatter.Controllers
{
    public interface IUnitOfWork
    {                
        IArticleRepository ArticleRepository { get; }

        IAuthorRepository AuthorRepository { get; }                
    }
}
