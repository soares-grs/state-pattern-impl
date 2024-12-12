using System;
using StatePatternImpl.States.Interfaces;

namespace StatePatternImpl.States;

public class TaskConcluded : ITaskStatusState
{
    public void Create(Models.Task task)
    {
        throw new InvalidOperationException("The task is completed");
    }

    public void Start(Models.Task task)
    {
        throw new InvalidOperationException("The task is completed");
    }

    public void Conclude(Models.Task task)
    {
        throw new InvalidOperationException("The task is completed");
    }
}
