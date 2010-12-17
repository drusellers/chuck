namespace chuck.Dsl
{
    using Model;

    public class OperationConfigurator :
        OperationConfiguration
    {
        private Operation _operation;

        public OperationConfigurator(string name)
        {
            _operation = new Operation(name);
        }

        public void AddTask(Task instance)
        {
            _operation.AddTask(instance);
        }

        public void AddTask<TTask>()
        {
            //how to add task?
        }

        public Operation Build()
        {
            return _operation;
        }
    }
}