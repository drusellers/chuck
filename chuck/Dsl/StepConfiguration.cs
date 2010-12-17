namespace chuck.Dsl
{
    using System;

    public interface StepConfiguration
    {
        void AddOperation(string name, Action<OperationConfiguration> cfg);
    }
}