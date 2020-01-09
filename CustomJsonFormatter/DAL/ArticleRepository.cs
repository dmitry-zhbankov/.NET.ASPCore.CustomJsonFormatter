using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CustomJsonFormatter.DAL;
using CustomJsonFormatter.Models;

namespace CustomJsonFormatter.Controllers
{
    public class ArticleRepository : IArticleRepository
    {
        private MyContext _context;
        private IEnumerable<Article> _articles;
        public ArticleRepository(MyContext context)
        {
            _context = context;
            _articles = context.Articles;
        }

        public void Create(Article entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> Get(Expression<Func<Article, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Article GetById(int id)
        {            
            return _articles.FirstOrDefault(x=>x.ArticleId==id);            
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Article entity)
        {
            throw new NotImplementedException();
        }
    }
}
