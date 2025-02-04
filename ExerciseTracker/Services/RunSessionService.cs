using ExerciseTracker.Models;
using ExerciseTracker.Repositories.Interfaces;
using System;
namespace ExerciseTracker.Services;

internal class RunSessionService
{
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
}
