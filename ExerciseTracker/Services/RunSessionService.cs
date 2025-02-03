using ExerciseTracker.Models;
using ExerciseTracker.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Services;

internal class RunSessionService
{
    private readonly IRunSessionRepository _runSessionRepository;
    public RunSessionService(IRunSessionRepository repository)
    {
        _runSessionRepository = repository;
    }
    public RunSession CreateSession(DateTime start, DateTime end, int distanceInMeters)
    {
        var session = new RunSession()
        {
            DateStart = start,
            DateEnd = end,
            Duration = end - start,
            DistanceInMeter = distanceInMeters
        };

        return session;
    }

    public RunSession UpdateSession(RunSession session)
    {
        var existingSession = _runSessionRepository.GetById(session.Id);
        ArgumentNullException.ThrowIfNull(existingSession, nameof(session));

        return existingSession;
    }
}
