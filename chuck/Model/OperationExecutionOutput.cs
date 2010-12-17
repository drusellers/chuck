namespace chuck.Model
{
    public class OperationExecutionOutput
    {
        public OperationExecutionOutput(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public ExecutionOutputStatus Status { get; private set; }
        public string Notes { get; set; }
    }
}