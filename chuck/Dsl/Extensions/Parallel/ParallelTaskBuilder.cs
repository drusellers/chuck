namespace chuck.Dsl.Extensions.Parallel
{
    using System;
    using System.Collections.Generic;
    using Tasks.Parallel;

    public class ParallelTaskBuilder<ENTITY>
    {

        private readonly ParallelProcessingTask<ENTITY> _task;

        public ParallelTaskBuilder(OperationConfiguration configuration, IList<ENTITY> workLoad, Action<ENTITY> action)
        {
            _task = new ParallelProcessingTask<ENTITY>(workLoad, action);

            configuration.AddTask(null);
        }
    }
}