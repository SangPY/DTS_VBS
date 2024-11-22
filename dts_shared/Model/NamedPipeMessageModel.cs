using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_shared.Model
{
    [Serializable]
    public class NamedPipeMessageModel
    {
        public string Message { get; set; }

        public Guid MessageID { get; set; }

        public object Data { get; set; }
    }
}