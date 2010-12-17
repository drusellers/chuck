namespace chuck
{
    using Tasks.Incremental;

    public static class Extensions
    {
        public static RowCount Rows(this int value)
        {
            return new RowCount(value);
        }
    }
}