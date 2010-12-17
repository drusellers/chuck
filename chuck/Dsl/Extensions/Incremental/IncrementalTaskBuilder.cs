namespace chuck.Dsl.Extensions.Incremental
{
    using System;
    using Tasks.Incremental;

    public class IncrementalTaskBuilder<ENTITY>
    {

        private readonly IncrementalProcessingTask<ENTITY> _task;

        public IncrementalTaskBuilder(OperationConfiguration configuration, RowCount count, Action<ENTITY> action)
        {
            IIncrementer incrementer = null;
            _task = new IncrementalProcessingTask<ENTITY>(incrementer, count, action);

            configuration.AddTask(null);
        }
    }
}