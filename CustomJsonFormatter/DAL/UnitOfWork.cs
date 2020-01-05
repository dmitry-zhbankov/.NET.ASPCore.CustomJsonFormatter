using Microsoft.EntityFrameworkCore;
using System;

namespace CustomJsonFormatter.Controllers
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IArticleRepository articleRepository, IAuthorRepository authorRepository)
        {            
            ArticleRepository = articleRepository;
            AuthorRepository = authorRepository;
        }        

        public IArticleRepository ArticleRepository { get; }

        public IAuthorRepository AuthorRepository { get; }
        
    }
}
