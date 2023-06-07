using System.Linq.Expressions;

namespace BookStoreCoreMVC.Models.Interfaces;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetFilteredAsync(
        Expression<Func<T, bool>>[] filters,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy,
        int? skip,
        int? take,
        params Expression<Func<T, object>>[] includes
        );

    Task<IEnumerable<T>> GetAsync(
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy,
        int? skip,
        int? take,
        params Expression<Func<T, object>>[] includes
        );

    Task<T?> GetByIdAsync(
        object id,
        params Expression<Func<T, object>>[] includes
        );

    //return Id
    Task<object> Insert(T entity);

    void Delete(T entity);

    void Update(T entity);
}