namespace CustomJsonFormatter.DAL
{
    public interface IUnitOfWork
    {                
        IArticleRepository ArticleRepository { get; }

        IAuthorRepository AuthorRepository { get; }                
    }
}
