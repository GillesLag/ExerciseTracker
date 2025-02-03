using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Repositories.Interfaces;

internal interface IRepository<T>
{
    public int Add(T entity);
    public IQueryable<T> GetAll();
    public int Update(T entity);
    public int Delete(T entity);
}
