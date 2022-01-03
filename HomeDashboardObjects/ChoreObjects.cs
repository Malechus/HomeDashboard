using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDashboardObjects
{
    public class ChoreObjects
    {
        public class ChoreEvent
        {
            public string ChoreName { get; set; }

            public string ChoreDay { get; set; }

            public string Person { get; set; }

            public TimeSpan? ChoreTime { get; set; }
        }
    }
}
