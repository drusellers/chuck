namespace chuck.Model
{
    using System.Collections.Generic;
    using log4net;

    public class Script
    {
        private static ILog _log = LogManager.GetLogger(typeof (Script));

        public Script(string name)
        {
            Name = name;
            Steps = new List<Step>();
        }

        public string Name { get; private set; }
        public IList<Step> Steps { get; private set; }

        public ScriptExecutionOutput Run()
        {
            var result = new ScriptExecutionOutput();

            foreach (var step in Steps)
            {
                _log.DebugFormat("Running step '{0}'", step.Name);
                var stepResult = step.Run();
                result.Add(stepResult);
            }

            return result;
        }

        public void Verify()
        {
            
        }

        public void Trace()
        {
            
        }
    }
}