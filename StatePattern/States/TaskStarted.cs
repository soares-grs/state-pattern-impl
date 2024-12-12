using System;
using StatePatternImpl.States.Interfaces;

namespace StatePatternImpl.States;

public class TaskStarted : ITaskStatusState
{
    public void Create(Models.Task task)
    {
        throw new InvalidOperationException("The task has already been created.");
    }

    public void Start(Models.Task task)
    {
        throw new InvalidOperationException("The task cannot be started twice");
    }

    public void Conclude(Models.Task task)
    {
        task.Status = new TaskConcluded();
    }
}
