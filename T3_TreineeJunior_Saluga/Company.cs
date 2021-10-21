using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_TreineeJunior_Salyga
{
    class Company
    {
        public List<Employee> Lst = new List<Employee>();
        public List<Employee> AllNameType<T>(List<Employee> Lst)
        {
            List<Employee> list = new List<Employee>();
            foreach (var item in Lst)
            {
                if (item.GetType() == typeof(T))
                    list.Add(item);
            }
            return list;
        }
        public int TypeCount<T>(List<Employee> Lst)
        {
            int count = 0;
            foreach (var item in Lst)
            {
                if (item.GetType() == typeof(T))
                { count++; }
            }
            return count;
        }
     }
}
