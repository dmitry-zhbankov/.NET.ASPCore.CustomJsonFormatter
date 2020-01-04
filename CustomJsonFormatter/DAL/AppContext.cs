using Microsoft.EntityFrameworkCore;

namespace CustomJsonFormatter.Controllers
{
    public class MyContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }        

        public MyContext(DbContextOptions options) : base(options)
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
            Authors.Add(author1);
            Authors.Add(author2);
            Articles.Add(new Article()
            {
                ArticleId = 1,
                Author = author1,
                Description = "Description 1",
                Title = "Title 1"
            });
            Articles.Add(new Article()
            {
                ArticleId = 2,
                Author = author1,
                Description = "Description 2",
                Title = "Title 2"
            });
            Articles.Add(new Article()
            {
                ArticleId = 3,
                Author = author2,
                Description = "Description 3",
                Title = "Title 3"
            });
            Articles.Add(new Article()
            {
                ArticleId = 4,
                Author = author2,
                Description = "Description 4",
                Title = "Title 4"
            });
        }
    }
}
