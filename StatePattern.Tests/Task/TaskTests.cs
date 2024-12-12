using System;
using StatePatternImpl.States;

namespace StatePatternImpl.Tests.Tests.Task;

public class TaskTests
{
    [Fact]
    public void TaskMustStartWithTypeCreated() {
        Models.Task task = new("Some Task");

        Assert.True(task.Status is TaskCreated, "Task must be started with status created");
    }

    [Fact]
    public void CannotInvokeConcludeMethodWhenTaskHasCreatedStatus() {
        Models.Task task = new("Some Task");

        Assert.Throws<InvalidOperationException>(task.Conclude);
    }

    [Fact]
    public void TaskCannotBeStartedTwice() {
        Models.Task task = new("Some Task");
        task.Start();
        Assert.Throws<InvalidOperationException>(task.Start);
    }

    [Fact]
    public void TaskCannotBeConcludedTwice() {
        Models.Task task = new("Some Task");
        task.Start();
        task.Conclude();
        Assert.Throws<InvalidOperationException>(task.Conclude);
    }

    [Fact]
    public void CompletedTaskCannotReturnToStartedState() {
        Models.Task task = new("Some Task");
        task.Start();
        task.Conclude();
        Assert.Throws<InvalidOperationException>(task.Start);
    }

}
