using Library.Persistence.ContextClasses;
using Library.Domain.Entities;
using Library.Contract.RepositoryInterfaces;

namespace Library.Persistence.RepositoryConcretes
{
    public class BookTagRepository(MyContext context) : BaseRepository<BookTag>(context), IBookTagRepository
    {

    }
}
