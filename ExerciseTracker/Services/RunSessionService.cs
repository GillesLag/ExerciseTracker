using ExerciseTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
