using Library.Persistence.ContextClasses;
using Library.Domain.Entities;
using Library.Contract.RepositoryInterfaces;

namespace Library.Persistence.RepositoryConcretes
{
    public class AuthorRepository(MyContext context) : BaseRepository<Author>(context), IAuthorRepository
    {

    }
}
