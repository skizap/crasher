using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crasher.Model
{
    public abstract class AttackSettings
    {
        public static string Url { get; set; } = "none";
        public static AttackType Mode { get; set; } = AttackType.ClientRequest;
        public static bool Threading { get; set; } = true;
        public static int Threads { get; set; } = 10;
    }
}
