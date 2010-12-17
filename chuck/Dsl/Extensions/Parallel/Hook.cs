namespace chuck.Dsl.Extensions.Parallel
{
    using System;
    using System.Collections.Generic;

    public static class Hook
    {
        public static void ProcessInParallel<ENTITY>(this OperationConfiguration operation, IList<ENTITY> items, Action<ENTITY> toDo)
        {
            new ParallelTaskBuilder<ENTITY>(operation, items, toDo);
        }
    }
}