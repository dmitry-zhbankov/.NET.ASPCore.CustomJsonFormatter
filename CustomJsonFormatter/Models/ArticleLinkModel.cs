using Microsoft.AspNetCore.Routing;

namespace CustomJsonFormatter.Models
{
    public class ArticleLinkModel
    {
        public string Self { get; set; }
        public string Author { get; set; }

        public ArticleLinkModel(Article article)
        {
            Self = @$"http://localhost:50298/api/article/{article.ArticleId}";
            Author = @$"http://localhost:50298/api/profile/{article.Author.AuthorId}";
        }
    }
}