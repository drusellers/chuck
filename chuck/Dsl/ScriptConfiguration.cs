namespace chuck.Dsl
{
    using System;

    public interface ScriptConfiguration
    {
        void AddStep(string name, Action<StepConfiguration> cfg);
        void RunInATransaction();
    }
}