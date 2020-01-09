namespace CustomJsonFormatter.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IArticleRepository articleRepository, IAuthorRepository authorRepository)
        {            
            ArticleRepository = articleRepository;
            AuthorRepository = authorRepository;
        }        

        public IArticleRepository ArticleRepository { get; }

        public IAuthorRepository AuthorRepository { get; }
    }
}
