namespace chuck
{
    using System;
    using Dsl;
    using Model;

    public static class ScriptBuilder
    {
        public static Script Build(string name, Action<ScriptConfiguration> cfg)
        {
            var sc = new ScriptConfigurator(name);
            cfg(sc);

            return sc.Build();
        }
    }
}