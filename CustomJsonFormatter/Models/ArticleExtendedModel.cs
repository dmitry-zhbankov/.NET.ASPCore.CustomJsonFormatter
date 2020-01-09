using System.Text.Json.Serialization;

namespace CustomJsonFormatter.Models
{
    public class ArticleExtendedModel
    {
        public ArticleModel Data { get; set; }
        
        [JsonPropertyName("_links")]
        public ArticleLinkModel Link { get; set; }

        public ArticleExtendedModel(Article article)
        {
            Data=new ArticleModel(article);
            Link=new ArticleLinkModel();
        }
    }
}