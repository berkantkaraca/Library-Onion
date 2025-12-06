using Library.Persistence.ContextClasses;
using Library.Domain.Entities;
using Library.Contract.RepositoryInterfaces;

namespace Library.Persistence.RepositoryConcretes
{
    public class CategoryRepository(MyContext context) : BaseRepository<Category>(context), ICategoryRepository
    {

    }
}
