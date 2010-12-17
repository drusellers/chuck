namespace chuck.Dsl
{
    using Model;

    public interface OperationConfiguration
    {
        void AddTask(Task instance);
        void AddTask<TTask>();
    }
}