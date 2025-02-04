using ExerciseTracker.Data;
using ExerciseTracker.Models;
using ExerciseTracker.Repositories.Interfaces;

namespace ExerciseTracker.Repositories;

internal class RunSessionRepository : Repository<RunSession>, IRunSessionRepository
{
    public RunSessionRepository(ExerciseContext context) : base(context)
    {
    }

    public RunSession? GetById(int id)
    {
        return _context.RunSessions.Find(id);
    }

    public bool SessionExists(int id)
    {
        return _context.RunSessions.Any(session => session.Id == id);
    }
}
