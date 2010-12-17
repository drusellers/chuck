namespace chuck.Tasks.Incremental
{
    using System.Collections.Generic;

    public class Increment<ENTITY>
    {
        public int CurrentIncrementNumber { get; set; }
        public IList<ENTITY> Data { get; set; }
    }
}