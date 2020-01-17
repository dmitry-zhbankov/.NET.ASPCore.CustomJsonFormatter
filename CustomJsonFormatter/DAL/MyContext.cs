using System.Collections.Generic;
using CustomJsonFormatter.Models;

namespace CustomJsonFormatter.DAL
{
    public class MyContext
    {
        public IEnumerable<Article> Articles { get; set; }
        public IEnumerable<Author> Authors { get; set; }

        public MyContext()
        {
            var author1 = new Author()
            {
                AuthorId = 1,
                Name = "Author 1"
            };
            var author2 = new Author()
            {
                AuthorId = 1,
                Name = "Author 1"
            };
            Authors = new List<Author>()
            {
                author1,
                author2
            };

            Articles = new List<Article>()
            {
                new Article()
                {
                    ArticleId = 1,
                    Author = author1,
                    Description = "Description 1",
                    Title = "Title 1"
                },
                new Article()
                {
                    ArticleId = 2,
                    Author = author1,
                    Description = "Description 2",
                    Title = "Title 2"
                },
                new Article()
                {
                    ArticleId = 3,
                    Author = author2,
                    Description = "Description 3",
                    Title = "Title 3"
                },
                new Article()
                {
                    ArticleId = 4,
                    Author = author2,
                    Description = "Description ",
                    Title = "Title 4"
                },
            };

        }
    }
}
