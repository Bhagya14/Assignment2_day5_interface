using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_interface_assignment
{
    class Accountclass
    {
        public void Getemployee(IAccountEmp obj)
        {
            int accno = obj.Getempaccountno();
            Console.WriteLine("accno:" + accno);
            int empid = obj.Getempid();
            Console.WriteLine("empid:" + empid);
            int salary = obj.Getempsalary();
            Console.WriteLine("empsalary:" + salary);

        }
    }
}
