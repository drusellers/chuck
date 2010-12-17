namespace chuck.Tasks.Incremental
{
    using System;

    public class IncrementalProcessingTask<ENTITY>
    {
        private readonly IIncrementer _incrementer;
        private readonly RowCount _rowCount;
        private readonly Action<ENTITY> _action;

        public IncrementalProcessingTask(IIncrementer incrementer, RowCount rowCount, Action<ENTITY> action)
        {
            _incrementer = incrementer;
            _action = action;
            _rowCount = rowCount;
        }

        public void Execute()
        {
            foreach (var batch in _incrementer.Incrementalize<ENTITY>(_rowCount))
            {
                foreach (ENTITY entity in batch.Data)
                {
                    _action(entity);
                }
            }
        }
    }
}