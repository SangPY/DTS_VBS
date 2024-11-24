using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_agent.ServiceProvider
{
    public abstract class ServiceProviderBase
    {
        public abstract string Decrypt(string encrytedValue);
    }
}