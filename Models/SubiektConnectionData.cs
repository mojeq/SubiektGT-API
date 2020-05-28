using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubiektGT_API.Models
{
    public class SubiektConnectionData
    {
        public string SubiektSqlConnection { get; set; }
        public SubiektConnectionData()
        {
            SubiektSqlConnection = "Data source=LAPTOP-6E2UURS8\\INSERTGT; database =terrasklep; User id =sa; Password =alpinus1;";
        }
    }
}
