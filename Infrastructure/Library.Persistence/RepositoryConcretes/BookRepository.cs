using Library.Persistence.ContextClasses;
using Library.Domain.Entities;
using Library.Contract.RepositoryInterfaces;

namespace Library.Persistence.RepositoryConcretes
{
    public class BookRepository(MyContext context) : BaseRepository<Book>(context), IBookRepository
    {

    }
}
