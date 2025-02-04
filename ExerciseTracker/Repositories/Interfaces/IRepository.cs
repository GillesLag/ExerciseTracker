namespace ExerciseTracker.Repositories.Interfaces;

internal interface IRepository<T>
{
    public int Add(T entity);
    public IQueryable<T> GetAll();
    public int Update(T entity);
    public int Delete(T entity);
}
