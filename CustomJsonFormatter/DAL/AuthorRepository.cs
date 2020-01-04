using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CustomJsonFormatter.Controllers
{
    public class AuthorRepository : IAuthorRepository
    {
        MyContext context;
        DbSet<Author> authors;
        public AuthorRepository(MyContext context)
        {
            this.context = context;
            authors = context.Set<Author>();
        }

        public void Create(Author entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> Get(Expression<Func<Author, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Author GetById(int id)
        {
            return authors.Find(id);
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
