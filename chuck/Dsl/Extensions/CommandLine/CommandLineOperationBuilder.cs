namespace chuck.Dsl.Extensions.CommandLine
{
    using Tasks.CommandLine;

    public class CommandLineOperationBuilder :
        CommandLineOptions
    {
        private readonly StepConfiguration _step;
        private readonly CommandLineTask _task;

        public CommandLineOperationBuilder(StepConfiguration step, string command)
        {
            _step = step;
            _task = new CommandLineTask(command);
            _step.AddOperation("command line task", opCfg =>
            {
                opCfg.AddTask(_task);
            });
        }

        public CommandLineOptions Args(string args)
        {
            _task.Args = args;
            return this;
        }

        public CommandLineOptions ExecutableIsLocatedAt(string path)
        {
            _task.ExecutableIsLocatedAt = path;
            return this;
        }

        public CommandLineOptions WorkingDirectory(string path)
        {
            _task.WorkingDirectory = path;
            return this;
        }
    }
}