using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomJsonFormatter.Models
{
    public class ArticleModel
    {
        public int ArticleId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int AuthorId { get; set; }

        public ArticleModel(Article article)
        {
            ArticleId = article.ArticleId;
            Title = article.Title;
            Description = article.Description;
            AuthorId = article.Author.AuthorId;
        }
    }
}
