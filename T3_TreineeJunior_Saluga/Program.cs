using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T3_TreineeJunior_Salyga
{
    class Program
    {
        static void Main(string[] args)
        {

            Company firm = new Company();
            firm.Lst = new List<Employee>();
            for (; ; )
            {
                Console.WriteLine(@"Chose what you want to do: 1 - Add employee to company; 2 - Delete employee;
                                      3 - Сheck if this employee works in company; 4 - Print all employees same type;
                                      5 - Get namber employees of same type; 6 - Print list of all employees");
                string chose = Console.ReadLine();
                switch (chose)
                {
                    case "1":                                             //Add employee to company
                            Console.WriteLine(  @"Add Employee to company.  For exit press 0
                                              Enter name of employee");
                            string name = Console.ReadLine();              // Can add checking by regular expression
                            Console.WriteLine("Choose type of employee. Worker - press 1, Manager - 2, Brigadier - 3");
                            string type = Console.ReadLine();
                            string patternType = "[1-3]";
                            if (!Regex.IsMatch(type, patternType))
                            {
                                Console.WriteLine("Incorrect choose");
                                break;
                            }
                            Console.WriteLine("Enter experience of employee in years");
                            string ex = Console.ReadLine();
                            string patternExp = "[0-70]";
                            if (!Regex.IsMatch(ex, patternExp))
                            {
                                Console.WriteLine("Incorrect choose");
                                break;
                            }
                            int exp = Convert.ToInt32(ex);
                            if (type == "1")
                                firm.Lst += new Worker(name, exp);
                            else if (type == "2")
                                firm.Lst += new Manager(name, exp);
                            else if (type == "3")
                                firm.Lst += new Brigadier(name, exp);
                                          
                        break;
                    case "2":                                                 //Delete employee
                        if (firm.Lst.Count == 0)
                            { 
                                Console.WriteLine("Firm has no employee");
                                break;
                            }
                            else
                            {
                            Console.WriteLine(@"Delete Employee. 
                                               Enter name of employee");
                            string DelName = Console.ReadLine();
                            Console.WriteLine("Choose type of employee. Worker - press 1, Manager - 2, Brigadier - 3");
                            string type2 = Console.ReadLine();
                            Console.WriteLine("Enter experience of employee in years");
                            string ex2 = Console.ReadLine();
                            int exp2 = Convert.ToInt32(ex2);
                            if (type2 == "1")
                                firm.Lst -= new Worker(DelName, exp2);
                            else if (type2 == "2")
                                firm.Lst -= new Manager(DelName, exp2);
                            else if (type2 == "3")
                                firm.Lst -= new Brigadier(DelName, exp2);
                            }
                          break;
                    case "3":                                             //Check do emloyee work in company
                        Console.WriteLine(@"Enter name of employee");
                        string nameSearch = Console.ReadLine();
                        firm.Lst.Search(nameSearch);                     // Extension method
                        break;
                    case "4":                                            //Print all employees same type
                        Console.WriteLine("Choose type of emloyees. Worker - press 1, Manager - 2, Brigadier - 3");
                        string str = Console.ReadLine();
                        List<Employee> typeEmp = new List<Employee>(); 
                        switch (str)
                        {
                            case "1":
                                typeEmp = firm.AllNameType<Worker>(firm.Lst);
                            break;
                            case "2":
                                typeEmp = firm.AllNameType<Manager>(firm.Lst);
                            break;
                            case "3":
                                typeEmp = firm.AllNameType<Brigadier>(firm.Lst);
                            break;
                            default:
                                Console.WriteLine("Incorrect choose");
                                break;
                        }
                        typeEmp.Print();
                        break;
                    case "5":                                              //Get namber employees of same type
                        Console.WriteLine("Choose type of emloyees. Worker - press 1, Manager - 2, Brigadier - 3");
                        string str2 = Console.ReadLine();
                        int number = 0;
                        string ChooseType = "?";
                        switch (str2)
                        {
                            case "1":
                                number = firm.TypeCount<Worker>(firm.Lst);
                                ChooseType = "worker";
                                break;
                            case "2":
                                number = firm.TypeCount<Manager>(firm.Lst);
                                ChooseType = "manager";
                                break;
                            case "3":
                                number = firm.TypeCount<Brigadier>(firm.Lst);
                                ChooseType = "brigadier";
                                break;
                            default:
                                Console.WriteLine("You did not a choose");
                                break;
                        }
                        Console.WriteLine($"Number of {ChooseType} is {number}");
                        break;
                    case "6":                                        // Print list of all employees
                        if (firm.Lst.Count == 0)
                        { Console.WriteLine("Firm has no employee"); }
                        else firm.Lst.Print();                       // Extension method                                             
                        break;
                    default:
                        Console.WriteLine("You did not a choose");
                        break;
                }
             }
        }

    }
}
  