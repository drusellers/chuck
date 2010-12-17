namespace Demo
{
    using System;
    using chuck;
    using chuck.Dsl.Extensions.CommandLine;
    using chuck.Model;

    public class Runner
    {
        public void Take1()
        {
            log4net.Config.BasicConfigurator.Configure();

            var script = ScriptBuilder.Build("script name", cfg =>
            {
                //stops on error?

                //multiple transactions per script? - no
                //requries all steps to be transactional?
                cfg.RunInATransaction();

                cfg.AddStep("pre-checks", step=>
                    {
                        
                    });


                cfg.AddStep("server one", step =>
                {
                    step.CommandLine("ping")
                        .Args("www.google.com");

                    step.AddOperation("Name", operation =>
                    {
                        operation.AddTask(new DummyTask());
                        int i = 0;
                    });
                });



                cfg.AddStep("post-checks", step =>
                {
                    step.AddOperation("name 2", operation =>
                    {
                        Console.WriteLine("dru 2");                       
                        operation.AddTask<DummyTask>();
                    });

                    //step.IncrementallyProcess<object>(500.Rows(), o =>
                    //{
                    //    //do stuff
                    //});

//                    IList<object> workInput = new List<object>();
//                    step.ProcessInParallel(workInput, i => { });
                    int i = 0;
                });

            });
            
            



            //output result
            var output = script.Run();

            Console.WriteLine("[{0}]:'{1}'", output.Status, output.Name);
            foreach (var executionOutput in output)
            {
                Console.WriteLine("  [{0}]:'{1}'",executionOutput.Status, executionOutput.Name);
                foreach (var taskExecutionOutput in executionOutput)
                {
                    Console.WriteLine("    [{0}]:'{1}'->{2}", taskExecutionOutput.Status, taskExecutionOutput.Name, taskExecutionOutput.Notes);
                }
                
            }
            Console.WriteLine("steps {0}",output.StepCount());
            
        }
    }

    public class DummyTask :
        Task
    {
        public string Name
        {
            get { return "dummy"; }
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
