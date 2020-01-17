namespace CustomJsonFormatter.Models
{
    public class Article
    {
        public int ArticleId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Author Author { get; set; }
    }
}