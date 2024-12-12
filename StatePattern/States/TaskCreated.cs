using System;
using StatePatternImpl.States.Interfaces;

namespace StatePatternImpl.States;

public class TaskCreated : ITaskStatusState
{
    public void Create(Models.Task task)
    {
        throw new InvalidOperationException("The task has already been created.");
    }

    public void Start(Models.Task task)
    {
        task.Status = new TaskStarted();
    }

    public void Conclude(Models.Task task)
    {
        throw new InvalidOperationException("The task cannot go from created to completed directly.");
    }
}
