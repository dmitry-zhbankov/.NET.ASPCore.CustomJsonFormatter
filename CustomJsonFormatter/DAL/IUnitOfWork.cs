using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomJsonFormatter.Controllers
{
    public interface IUnitOfWork
    {        
        DbContext Context { get; }

        IArticleRepository ArticleRepository { get; }

        IAuthorRepository AuthorRepository { get; }
        
        int Save();
    }
}
