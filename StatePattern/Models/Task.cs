using System;
using StatePatternImpl.States;
using StatePatternImpl.States.Interfaces;

namespace StatePatternImpl.Models;

public class Task(string title)
{
    public string Title { get; set; } = title;

    public ITaskStatusState Status { get; set; } = new TaskCreated();

    public void Start()
    {
        Status.Start(this);
    }
    public void Conclude()
    {
        Status.Conclude(this);
    }
}
