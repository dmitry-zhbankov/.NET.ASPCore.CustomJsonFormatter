using CustomJsonFormatter.Models;

namespace CustomJsonFormatter.Models
{
    public class ArticleExtendedModel
    {
        public ArticleModel Data { get; set; }
        public ArticleLinkModel Link { get; set; }

        public ArticleExtendedModel(Article article)
        {
            Data=new ArticleModel(article);
            Link=new ArticleLinkModel(article);
        }
    }
}