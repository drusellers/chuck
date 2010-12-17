namespace chuck.Model
{
    using System;
    using System.Collections.Generic;

    public class Step
    {
        public Step(string name)
        {
            Name = name;
            Tasks = new List<Operation>();
            ErrorBehavior = ErrorBehavior.ContinuesOnError;
        }

        public string Name { get; private set; }
        public IList<Operation> Tasks { get; private set; }
        public ErrorBehavior ErrorBehavior { get; private set; }

        public void StopsOnError()
        {
            ErrorBehavior = ErrorBehavior.StopsOnError;
        }

        public void AddTask(string name, Func<OperationExecutionOutput> action)
        {
            //Task -> (VerifyTask, ExecuteTask)
            //Tasks.Add(new Operation(name, action));
        }

        public StepExecutionOutput Run()
        {
            var result = new StepExecutionOutput(Name);
            foreach (var task in Tasks)
            {
                var taskOutput = task.Action();
                result.AddTaskOutput(taskOutput);
            }
            return result;
        }
    }
}