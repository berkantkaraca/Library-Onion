using Library.Persistence.ContextClasses;
using Library.Domain.Entities;
using Library.Contract.RepositoryInterfaces;

namespace Library.Persistence.RepositoryConcretes
{
    public class TagRepository(MyContext context) : BaseRepository<Tag>(context), ITagRepository
    {

    }
}
