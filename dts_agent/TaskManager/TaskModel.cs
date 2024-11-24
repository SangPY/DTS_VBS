using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dts_agent.TaskManager
{
    public class TaskModel<T> : TaskModel
    {
        public Task<T> Task { get; set; }
    }

    public class TaskModel
    {
        public Guid ID { get; set; }

        public string ViewModel { get; set; }

        public string Name { get; set; }

        public CancellationTokenSource CancellationTokenSource { get; set; }

        public bool IsCriticalTask { get; set; }
    }
}