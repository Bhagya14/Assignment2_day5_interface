using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_interface_assignment
{
    class Managerclass
    {
        public void Getemployee(IManagerEmp obj)
        {
            int empid = obj.Getempid();
            Console.WriteLine("empid:" + empid);
            int empexp = obj.Getempexp();
            Console.WriteLine("empexp:" + empexp);
            string project = obj.Getempprojectdetails();
            Console.WriteLine("project detials" + project);

        }
    }
}
