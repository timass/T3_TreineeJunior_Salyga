using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_TreineeJunior_Salyga
{
   public abstract class Employee
    {
        public string Name { get; private set; }
        public int Experience { get; private set; }
        public abstract void Work();
        public Employee(string name, int experience)
        {
            Name = name;
            Experience = experience;
        }
        public static List<Employee> operator +(List<Employee> list, Employee man)
        {
            list.Add(man);
            return list;
        }
        public static List<Employee> operator -(List<Employee> list, Employee man)
        {

            int number = -1;
            for (int i = 0; i < list.Count; i++) 
            {
                if (list[i].Name == man.Name && list[i].Experience == man.Experience && list[i].GetType() == man.GetType())   //Also we can reboot "=="
                    number = i;
            }
            if (number == -1)
                Console.WriteLine("This employee dosen't work in company ");
            else
            {
                Console.WriteLine($"Employee {list[number].Name} was removed");
                list.RemoveAt(number);
            }
            return list;
        }
    }
    public static class EmployeePrint
    {
        public static void Print(this List<Employee> list)
        {
            if (list.Count == 0)
                Console.WriteLine("Employees number is 0");
            foreach (Employee item in list)
            {
                string str = item.GetType().ToString();
                if (str[str.Length - 3] == 'k')
                    str = "Worker";
                else if (str[str.Length - 3] == 'g')
                    str = "Manager";
                else if (str[str.Length - 3] == 'i')
                    str = "Brigadier";
                else Console.WriteLine("Incorrect type");
                Console.WriteLine($"Employee name: {item.Name}; Employee type: {str}; Employee experience: {item.Experience} years");
            }
        }
    }
    public static class EmployeeSearch
    { 
        public static void Search(this List<Employee> list, string str)
    {
       if(list.Any(t=> t.Name == str))
            Console.WriteLine("This Employee work in company" );
       else Console.WriteLine("This Employee doesn't work in company");
    }
  }
}
