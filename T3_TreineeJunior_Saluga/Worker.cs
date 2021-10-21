using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_TreineeJunior_Salyga
{
    class Worker : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Worker makes products");
        }
        public Worker(string name, int experience) : base(name, experience)
        { }
    }
}
