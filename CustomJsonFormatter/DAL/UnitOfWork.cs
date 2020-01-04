using Microsoft.EntityFrameworkCore;
using System;

namespace CustomJsonFormatter.Controllers
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(MyContext context, IArticleRepository articleRepository, IAuthorRepository authorRepository)
        {
            Context = context;
            ArticleRepository = articleRepository;
            AuthorRepository = authorRepository;
        }
        public DbContext Context { get; }

        public IArticleRepository ArticleRepository { get; }

        public IAuthorRepository AuthorRepository { get; }

        public int Save()
        {
            throw new NotImplementedException();
        }
    }
}
