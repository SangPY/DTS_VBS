using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace dts_shared.Dispatcher
{
    public sealed class DispatcherManager
    {
        private static List<DispatcherOperation> _dispatcherOperationList;

        public static DispatcherManager Instance { get; } = new DispatcherManager();

        public void Add(DispatcherOperation operation)
        {
            if (_dispatcherOperationList == null)
                _dispatcherOperationList = new List<DispatcherOperation>();

            _dispatcherOperationList.Add(operation);
        }

        public void AbortAll()
        {
            if (_dispatcherOperationList != null)
            {
                foreach (var operation in _dispatcherOperationList)
                    operation.Abort();

                _dispatcherOperationList = new List<DispatcherOperation>();
            }
        }
    }
}