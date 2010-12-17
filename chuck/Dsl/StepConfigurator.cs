namespace chuck.Dsl
{
    using System;
    using Model;

    public class StepConfigurator :
        StepConfiguration
    {
        private string _name;

        public StepConfigurator(string name)
        {
            _name = name;
        }

        public void AddOperation(string name, Action<OperationConfiguration> cfg)
        {
            throw new NotImplementedException();
        }

        public Step Build()
        {
            throw new NotImplementedException();
        }
    }
}