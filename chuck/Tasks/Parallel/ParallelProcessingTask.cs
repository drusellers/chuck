namespace chuck.Tasks.Parallel
{
    using System;
    using System.Collections.Generic;

    public class ParallelProcessingTask<ENTITY>
    {
        private readonly IList<ENTITY> _workItems;
        private readonly Action<ENTITY> _action;

        public ParallelProcessingTask(IList<ENTITY> workItems, Action<ENTITY> action)
        {
            _workItems = workItems;
            _action = action;
        }

        public void Execute()
        {
            
        }
    }
}