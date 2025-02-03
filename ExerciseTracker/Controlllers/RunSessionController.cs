using ExerciseTracker.Repositories;
using ExerciseTracker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Controlllers;

internal class RunSessionController
{
    private readonly RunSessionRepository _repository;
    private readonly RunSessionService _service = new RunSessionService();
    public RunSessionController(RunSessionRepository repository)
    {
        _repository = repository;
    }

    public void AddRunSession(DateTime start, DateTime end, int meters)
    {
        var session = _service.CreateSession(start, end, meters);

        if (_repository.Add(session) == 0)
        {
            throw new Exception();
        }
    }
}
