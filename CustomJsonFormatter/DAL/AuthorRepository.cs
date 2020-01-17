using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CustomJsonFormatter.DAL;
using CustomJsonFormatter.Models;

namespace CustomJsonFormatter.Controllers
{
    public class AuthorRepository : IAuthorRepository
    {        
        private IEnumerable<Author> _authors;

        public AuthorRepository(MyContext context)
        {
            _authors = context.Authors;
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
            return _authors.FirstOrDefault(x => x.AuthorId == id);
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
