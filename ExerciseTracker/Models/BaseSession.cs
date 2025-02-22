﻿namespace ExerciseTracker.Models;

internal class BaseSession
{
    public int Id { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
    public TimeSpan Duration { get; set; }
}
