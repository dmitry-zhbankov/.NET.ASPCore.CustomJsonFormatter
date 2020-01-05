using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CustomJsonFormatter.Models;

namespace CustomJsonFormatter.Controllers
{
    public class AuthorRepository : IAuthorRepository
    {
        MyContext context;
        IEnumerable<Author> authors;
        public AuthorRepository(MyContext context)
        {
            this.context = context;
            authors = context.Authors;
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
            return authors.FirstOrDefault(x => x.AuthorId == id);
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
