using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crasher.Model
{
    public class Attack
    {
        /**
         * Metodo costruttore che definisce un attacco ad un obbiettivo.
         * **/
        public Attack(string url, AttackType mode)
        {
            AttackSettings.Mode = mode;
            AttackSettings.Url = url;
        }

        /**
         * Metodo che starta l'attacco desiderato
         * **/
        public void Start()
        {
            if (AttackSettings.Mode == AttackType.ClientRequest)
                Attacks.ClientRequest.Start();
            else if (AttackSettings.Mode == AttackType.Mirror)
                Attacks.Mirror.Start();
        }

        /**
         * Metodo che ferma l'attacco
         * **/
        public void Stop()
        {
            if (AttackSettings.Mode == AttackType.ClientRequest)
                Attacks.ClientRequest.Stop();
            else if (AttackSettings.Mode == AttackType.Mirror)
                Attacks.Mirror.Stop();
        }
    }
}
