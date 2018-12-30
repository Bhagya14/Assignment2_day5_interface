using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_interface_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           
                employee obj = new employee("bhagya", "bangalore", 25000, "mainroad", "dotnet", 2, 34558765, "CUB", 25);

                HRclass obj1 = new HRclass();
                obj1.Getemployee(obj);
                Managerclass obj2 = new Managerclass();
                obj2.Getemployee(obj);
                Accountclass obj3 = new Accountclass();
                obj3.Getemployee(obj);
                Console.ReadLine();
            }
        }
    }

