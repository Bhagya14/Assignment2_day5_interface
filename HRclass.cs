using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_interface_assignment
{
    class HRclass
    {
        public void Getemployee(IHREMP obj)
        {
            string address = obj.Getempaddress();
            Console.WriteLine("address" + address);
            int salary = obj.Getempsalary();
            Console.WriteLine("salary" + salary);
            int empid = obj.Getempid();
            Console.WriteLine("empid" + empid);

        }
    }
}
