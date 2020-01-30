namespace Interface
{
    internal partial class Program
    {
        public class WorkFlowEngine
        {
            public void Run(IWorkflow workflow)
            {
                foreach (ITask I in workflow.GetTasks())
                {
                    I.Execute();
                }
            }
        }
    }
}