namespace SportSln.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
