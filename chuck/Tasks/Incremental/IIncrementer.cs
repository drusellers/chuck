namespace chuck.Tasks.Incremental
{
    using System.Collections.Generic;

    public interface IIncrementer
    {
        IEnumerable<Increment<T>> Incrementalize<T>(RowCount count);
    }
}