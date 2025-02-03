using ExerciseTracker.Data;
using ExerciseTracker.Repositories.Interfaces;

namespace ExerciseTracker.Repositories;

internal class Repository<T> : IRepository<T> where T : class
{
    protected readonly ExerciseContext _context;
    public Repository(ExerciseContext context)
    {
        _context = context;
    }

    public int Add(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity, nameof(entity));

        try
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return 0;
        }
    }

    public int Delete(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity, nameof(entity));

        try
        {
            _context.Set<T>().Remove(entity);
            return _context.SaveChanges();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return 0;
        }
    }

    public IQueryable<T> GetAll()
    {
        return _context.Set<T>();
    }

    public int Update(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity, nameof(entity));

        _context.Set<T>().Update(entity);
        return _context.SaveChanges();
    }
}
