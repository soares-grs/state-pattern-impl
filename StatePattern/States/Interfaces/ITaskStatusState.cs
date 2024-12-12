using System;
using Task = StatePatternImpl.Models.Task;

namespace StatePatternImpl.States.Interfaces;

public interface ITaskStatusState
{
    void Create(Task task);
    void Start(Task task);
    void Conclude(Task task);
}
