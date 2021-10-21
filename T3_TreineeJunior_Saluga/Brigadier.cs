using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_TreineeJunior_Salyga
{
    class Brigadier : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Materials are buyed");
        }
        public void Check()
        {
            Console.WriteLine("Workers are checked");
        }
        public Brigadier(string name, int experience) : base(name, experience)
        { }
    }
}
