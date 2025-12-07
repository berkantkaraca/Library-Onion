namespace Library.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
