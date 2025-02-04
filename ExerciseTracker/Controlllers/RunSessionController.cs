using ExerciseTracker.Models;
using ExerciseTracker.Repositories;

namespace ExerciseTracker.Controlllers;

internal class RunSessionController
{
    private readonly RunSessionRepository _repository;
    public RunSessionController(RunSessionRepository repository)
    {
        _repository = repository;
    }

    public void AddRunSession(RunSession session)
    {
        if (_repository.Add(session) == 0)
        {
            Console.WriteLine("Something went wrong");
        }
    }

    public void UpdateSession(RunSession session)
    {
        var updatedSession = _repository.SessionExists(session.Id);

        if (updatedSession is false)
        {
            Console.WriteLine("this runsession does not exist");
            return;
        }

        _repository.Update(session);
    }

    public void DeleteSession(int id)
    {
        var session = _repository.GetById(id);
        if (session is null)
        {
            Console.WriteLine("no session with such id");
            return;
        }

        _repository.Delete(session);
    }

    public List<RunSession> GetSessions()
    {
        return _repository.GetAll().ToList();
    }

    public RunSession GetSessionById(int id)
    {
        var session = _repository.GetById(id);

        ArgumentNullException.ThrowIfNull(session, nameof(id));

        return session;
    }
}
