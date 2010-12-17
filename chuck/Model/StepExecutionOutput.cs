namespace chuck.Model
{
    using System.Collections;
    using System.Collections.Generic;

    public class StepExecutionOutput :
        IEnumerable<OperationExecutionOutput>
    {
        private readonly IList<OperationExecutionOutput> _taskOutput;

        public StepExecutionOutput(string name)
        {
            Name = name;
            _taskOutput = new List<OperationExecutionOutput>();
        }

        public string Name { get; private set; }
        public ExecutionOutputStatus Status { get; private set; }

        public void AddTaskOutput(OperationExecutionOutput output)
        {
            _taskOutput.Add(output);
        }

        public IEnumerator<OperationExecutionOutput> GetEnumerator()
        {
            foreach (var taskExecutionOutput in _taskOutput)
            {
                yield return taskExecutionOutput;
            }
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}