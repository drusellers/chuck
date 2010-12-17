namespace chuck.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Operation
    {
        private IList<Task> _tasks;

        public Operation(string name)
        {
            _tasks = new List<Task>();
            Name = name;
        }

        public string Name { get; private set; }
        public Func<OperationExecutionOutput> Action { get; private set; }


        public IList<VerifyTask> VerificationTasks()
        {
            return _tasks.Cast<VerifyTask>().ToList();
        }
        public IList<ExecuteTask> ExecuteTasks()
        {
            return _tasks.Cast<ExecuteTask>().ToList();
        }

        public void AddTask(Task instance)
        {
            _tasks.Add(instance);
        }
    }
}