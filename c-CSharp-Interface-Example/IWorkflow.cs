using System.Collections.Generic;

namespace Interface
{
    public interface IWorkflow
    {
        void Add(ITask task);

        void Remove(ITask task);

        IEnumerable<ITask> GetTasks();
    }
}