namespace chuck.Dsl
{
    using System;
    using Model;

    public class ScriptConfigurator :
        ScriptConfiguration
    {
        private Script _script;

        public ScriptConfigurator(string name)
        {
            _script = new Script(name);
        }

        public void AddStep(string name, Action<StepConfiguration> cfg)
        {
            var stepSpec = new StepConfigurator(name);
            cfg(stepSpec);
            _script.Steps.Add(stepSpec.Build());
        }

        public Script Build()
        {
            return _script;
        }

        public void BeforeRunning()
        {
            throw new NotImplementedException();
        }

        public void AfterRunning()
        {
            throw new NotImplementedException();
        }

        public void RunInATransaction()
        {
            throw new NotImplementedException();
        }
    }
}