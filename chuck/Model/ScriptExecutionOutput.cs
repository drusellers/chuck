namespace chuck.Model
{
    using System.Collections;
    using System.Collections.Generic;

    public class ScriptExecutionOutput :
        IEnumerable<StepExecutionOutput>
    {
        private readonly IList<StepExecutionOutput> _stepResults;

        public ScriptExecutionOutput()
        {
            _stepResults = new List<StepExecutionOutput>();
        }

        public string Name { get; private set; }
        public ExecutionOutputStatus Status { get; private set; }

        public void Add(StepExecutionOutput result)
        {
            _stepResults.Add(result);
        }

        public int StepCount()
        {
            return _stepResults.Count;
        }

        public IEnumerator<StepExecutionOutput> GetEnumerator()
        {
            foreach (var result in _stepResults)
            {
                yield return result;
            }
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}