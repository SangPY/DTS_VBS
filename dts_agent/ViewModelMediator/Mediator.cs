using dts_agent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_agent.ViewModelMediator
{
    public sealed class Mediator
    {
        private static readonly Mediator instance = new Mediator();

        private MultiDictionary<Tuple<string, int>, BaseModel> internalList = new MultiDictionary<Tuple<string, int>, BaseModel>();

        static Mediator()
        {
        }

        public Mediator()
        { }

        public static Mediator Instance
        {
            get { return instance; }
        }

        public void Register(BaseModel viewModel, string message, int id = 0)
        {
            internalList.AddValue(new Tuple<string, int>(message, id), viewModel);
        }

        public void UnRegister(BaseModel viewModel, string message, int id = 0)
        {
            var viewModelsToUnregister = internalList.Where(t => t.Key.Item1 == message && t.Key.Item2 == id);

            if (viewModelsToUnregister != null)
            {
                try
                {
                    foreach (var model in viewModelsToUnregister)
                    {
                        internalList.Remove(model.Key);
                    }
                }
                catch { }
            }
        }

        public void ClearInternalList()
        {
            internalList.Clear();
        }
    }
}