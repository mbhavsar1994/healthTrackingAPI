namespace lifeHealth.DataService;

public interface IGenericRepositoy<T> where T : class
{
    // Get all entities
    Task<IEnumerable<T>> All();

    Task<bool> Add(T entity);
    
    // Get Specific entity by Id 
    Task<T> GetById(Guid id);

    Task<bool> Delete(Guid id, string userId);

    // Update entity or add if not exist
    Task<bool> Upsert(T entity);
}
