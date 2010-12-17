namespace chuck.Tasks.Incremental
{
    using System.Diagnostics;

    [DebuggerDisplay("{_count}")]
    public class RowCount
    {
        private int _count;

        public RowCount(int count)
        {
            _count = count;
        }
    }
}