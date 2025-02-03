using ExerciseTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Repositories.Interfaces;

internal interface IRunSessionRepository : IRepository<RunSession>
{
    public RunSession? GetById(int id);
}
