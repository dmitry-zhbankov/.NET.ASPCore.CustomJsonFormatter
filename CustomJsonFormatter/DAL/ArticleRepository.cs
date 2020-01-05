using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CustomJsonFormatter.Models;

namespace CustomJsonFormatter.Controllers
{
    public class ArticleRepository : IArticleRepository
    {
        MyContext context;
        IEnumerable<Article> articles;
        public ArticleRepository(MyContext context)
        {
            this.context = context;
            articles = context.Articles;
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
            return articles.FirstOrDefault(x=>x.ArticleId==id);            
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
