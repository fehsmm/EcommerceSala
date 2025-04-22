using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace EcommerceSala.Data

{
    public abstract class Repository<T> : IRepository<T>, IDisposable where T : class, new()
    {
        protected readonly DbContext _context;
        protected readonly DbSet<T> DbSet;
        protected Repository(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            DbSet = _context.Set<T>();
        }

        public virtual async Task<T> AddAsync(T item, CancellationToken cancellationToken = default)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            await DbSet.AddAsync(item, cancellationToken);
            return item;
        }

        public virtual async Task<bool> AddManyAsync(List<T> itemList, CancellationToken cancellationToken = default)
        {
            if (itemList == null) throw new ArgumentNullException(nameof(itemList));
            if (!itemList.Any()) return true;

            await DbSet.AddRangeAsync(itemList, cancellationToken);
            return true;
        }

        public virtual async Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await DbSet.FindAsync(new object[] { id }, cancellationToken);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await DbSet.AsNoTracking().ToListAsync(cancellationToken);
        }

        public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync(cancellationToken);
        }

        public virtual T Update(T item, CancellationToken cancellationToken = default)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            _context.Entry(item).State = EntityState.Modified;
            return item;
        }

        public virtual bool UpdateMany(IEnumerable<T> itemList, CancellationToken cancellationToken = default)
        {
            if (itemList == null) throw new ArgumentNullException(nameof(itemList));

            foreach (var item in itemList)
            {
                _context.Entry(item).State = EntityState.Modified;
            }

            return true;
        }

        public virtual void Remove(T item, CancellationToken cancellationToken = default)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            DbSet.Remove(item);
        }

        public virtual void RemoveMany(IEnumerable<T> itemList, CancellationToken cancellationToken = default)
        {
            if (itemList == null) throw new ArgumentNullException(nameof(itemList));
            if (!itemList.Any()) return;

            DbSet.RemoveRange(itemList);
        }

        public virtual async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null, CancellationToken cancellationToken = default)
        {
            if (predicate == null)
                return await DbSet.CountAsync(cancellationToken);

            return await DbSet.CountAsync(predicate, cancellationToken);
        }

        public virtual async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await DbSet.AnyAsync(predicate, cancellationToken);
        }

        public virtual async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await DbSet.FirstOrDefaultAsync(predicate, cancellationToken);
        }

        public virtual IQueryable<T> GetQueryable()
        {
            return DbSet.AsQueryable();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
            }
        }
    }

    public interface IRepository<T> where T : class, new()
    {
    }
}