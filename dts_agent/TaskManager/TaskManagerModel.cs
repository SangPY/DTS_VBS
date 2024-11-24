using dts_agent.Components.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using dts_shared.Dispatcher;
using System.Windows;
using dts_agent.StandardMessage;
using dts_agent.ViewModelMediator;
using dts_agent.Cache;

namespace dts_agent.TaskManager
{
    public sealed class TaskManagerModel<T> : BaseViewModel
    {
        public static TaskManagerModel<T> Instance { get; } = new TaskManagerModel<T>();

        public async Task<T> Run(Task<T> task, CancellationTokenSource cancellationTokenSource, string viewModel = "", int timeOut = int.MaxValue, bool isCriticalTask = false)
        {
            Guid taskID = Guid.NewGuid();

            TaskModel<T> taskModel = new TaskModel<T>
            {
                ID = taskID,
                Task = task,
                CancellationTokenSource = cancellationTokenSource,
                ViewModel = viewModel,
                Name = task.ToString(),
                IsCriticalTask = isCriticalTask
            };

            TaskManagerModel.TaskList.Add(taskModel);

            if (timeOut != int.MaxValue)
            {
                if (await Task.WhenAny(task, Task.Delay(timeOut * 1000)) == task)
                {
                    TaskManagerModel.TaskList.Remove(taskModel);
                    return task.Result;
                }

                CancelTaskByID(taskID);
                DispatcherManager.Instance.Add(Application.Current.Dispatcher.BeginInvoke((Action)delegate
                {
                    ShowConfirmationWindow(DtsMessageResource.CurrentResourceManager.GetString("ErrorRequestTimedOut"), Messages.ErrorConfirmation);
                }));
                return default;
            }

            if (await Task.WhenAny(task, Task.Delay(DataCacheContext.AsyncTimeout * 1000)) == task)
            {
                TaskManagerModel.TaskList.Remove(taskModel);
                return task.Result;
            }

            CancelTaskByID(taskID);
            DispatcherManager.Instance.Add(Application.Current.Dispatcher.BeginInvoke((Action)delegate
            {
                ShowConfirmationWindow(DtsMessageResource.CurrentResourceManager.GetString("ErrorRequestTimedOut"), Messages.ErrorConfirmation);
            }));
            return default(T);
        }

        public void CancelTaskByID(Guid id)
        {
            foreach (TaskModel<T> task in TaskManagerModel.TaskList)
            {
                if (task.ID == id)
                {
                    task.CancellationTokenSource.Cancel();
                    TaskManagerModel.TaskList.Remove(task);
                    break;
                }
            }
        }
    }

    public abstract class TaskManagerModel
    {
        public static List<TaskModel> TaskList = new List<TaskModel>();
    }
}