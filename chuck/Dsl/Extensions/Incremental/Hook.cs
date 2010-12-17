namespace chuck.Dsl.Extensions.Incremental
{
    using System;
    using Tasks.Incremental;

    public static class Hook
    {
        public static void IncrementallyProcess<ENTITY>(this OperationConfiguration operation, RowCount rows, Action<ENTITY> toDo)
        {
            new IncrementalTaskBuilder<ENTITY>(operation, rows, toDo);
        }
    }
}