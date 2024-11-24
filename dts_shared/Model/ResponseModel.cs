using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_shared.Model
{
    public class ResponseModel
    {
        /// <summary>
        ///     HTTP status code.
        /// </summary>
        public int HttpStatusCode { get; set; }

        /// <summary>
        ///     Response from server as string.
        /// </summary>
        public string Result { get; set; }
    }
}