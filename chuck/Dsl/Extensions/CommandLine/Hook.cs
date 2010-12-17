namespace chuck.Dsl.Extensions.CommandLine
{
    public static class Hook
    {
        public static CommandLineOptions CommandLine(this StepConfiguration step, string command)
        {
            return new CommandLineOperationBuilder(step, command);
        }
    }
}