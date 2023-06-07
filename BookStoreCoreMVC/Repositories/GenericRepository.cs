using BookStoreCoreMVC.Models.Interfaces;
using BookStoreCoreMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using BookStoreCoreMVC.Data;


namespace BookStoreCoreMVC.Repositories;
public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    protected readonly ApplicationDBContext _context;
    protected readonly DbSet<T> _dbSet;
    protected readonly ILogger _logger;
    public GenericRepository(ApplicationDBContext context, ILogger logger)
    {
        _context = context;
        _dbSet = this._context.Set<T>();
        _logger = logger;
    }

    public virtual async Task<IEnumerable<T>> GetAsync(
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy,
        int? skip,
        int? take,
        params Expression<Func<T, object>>[] includes
        )
    {
        IQueryable<T> query = _dbSet;

        foreach (Expression<Func<T, object>> include in includes)
            query = query.Include(include);

        if (orderBy != null)
        {
            query = orderBy(query);
        }

        if (skip != null)
        {
            query = query.Skip(skip.Value);
        }

        if (take != null)
        {
            query = query.Take(take.Value);
        }



        return await query.ToListAsync();
    }

    public virtual async Task<T?> GetByIdAsync(
        object id,
        params Expression<Func<T, object>>[] includes
        )
    {
        IQueryable<T> query = _dbSet;

        query = query.Where(p => p.Id.Equals(id.ToString())).AsNoTracking();

        //TODO : how to solve tracking problem
        foreach (Expression<Func<T, object>> include in includes)
            query = query.Include(include).AsNoTracking();

        return await query.SingleOrDefaultAsync();
    }

    public virtual async Task<IEnumerable<T>> GetFilteredAsync(
        Expression<Func<T, bool>>[] filters,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy,
        int? skip,
        int? take,
        params Expression<Func<T, object>>[] includes)
    {
        IQueryable<T> query = _dbSet;

        foreach (var filter in filters)
            query = query.Where(filter);

        foreach (var include in includes)
            query = query.Include(include);


        if (orderBy != null)
        {
            query = orderBy(query);
        }

        if (skip != null)
        {
            query = query.Skip(skip.Value);
        }

        if (take != null)
        {
            query = query.Skip(take.Value);
        }


        return await query.ToListAsync();
    }


    //return Id
    public virtual async Task<object> Insert(T entity)
    {
        await _dbSet.AddAsync(entity);
        return entity.Id;
    }

    public virtual void Delete(T entity)
    {
        if (_dbSet.Entry(entity).State == EntityState.Detached)
        {
            _dbSet.Attach(entity);
        }
        _dbSet.Remove(entity);

    }

    public virtual void Update(T entity)
    {
        _dbSet.AsNoTrackingWithIdentityResolution();
        _dbSet.Attach(entity);

        _dbSet.Entry(entity).State = EntityState.Modified;


    }
}
