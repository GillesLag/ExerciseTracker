using ExerciseTracker.Models;

namespace ExerciseTracker.Repositories.Interfaces;

internal interface IRunSessionRepository : IRepository<RunSession>
{
    public RunSession? GetById(int id);
    public bool SessionExists(int id);
}
