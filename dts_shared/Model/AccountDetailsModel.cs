using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_shared.Model
{
    [Serializable]
    public class AccountDetailsModel
    {
        public string CustomerAccountId { get; set; }

        public string MemberType { get; set; }

        public int SecondsRemaining { get; set; }

        public string CustomerSessionId { get; set; }
    }
}