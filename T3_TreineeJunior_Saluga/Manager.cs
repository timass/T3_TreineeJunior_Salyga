using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_TreineeJunior_Salyga
{
    class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager collects orders");
        }
        public void Tesk()
        {
            Console.WriteLine("Task is given" );
        }
        public Manager(string name, int experience) : base(name, experience)
        { }
    }
}
