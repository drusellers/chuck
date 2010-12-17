namespace chuck.Model
{
    public interface Task
    {
        string Name { get; }
        void Execute();
    }

    public interface VerifyTask :
        Task
    {
        
    }
    public interface ExecuteTask :
        Task
    {
        
    }
    public interface TraceTask :
        Task
    {
        
    }
}