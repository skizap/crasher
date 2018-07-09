using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crasher.Model
{
    public abstact class AttackStats
    {
        public bool Started { get; set; } = false;
        public int RequestSent { get; set; } = 0;
        public int RequestDone { get; set; } = 0;
    }
}
