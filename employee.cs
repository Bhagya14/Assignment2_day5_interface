using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_interface_assignment
{
    class employee: IHREMP, IManagerEmp, IAccountEmp
    {
        private int empid;
        private string empname;
        private string empcity;
        private int empsal;
        private string empaddress;
        private string empprojectdetails;
        private int empexp;
        private int empaccno;
        private string empbankname;
        private int empage;

        private static int count = 1000;
        public employee(string empname, string empcity, int empsal, string empaddress, string empprojectdetails, int empexp, int empaccno, string empbankname, int empage)
        {
            this.empid = employee.count;
            this.empname = empname;
            this.empcity = empcity;
            this.empaddress = empaddress;
            this.empsal = empsal;
            this.empprojectdetails = empprojectdetails;
            this.empexp = empexp;
            this.empaccno = empaccno;
            this.empbankname = empbankname;
            this.empage = empage;

        }

        public string Getempaddress()
        {
            return this.empaddress;
        }

        public int Getempsalary()
        {
            return this.empsal;
        }

        public int Getempid()
        {
            return this.empid;
        }

        public int Getempexp()
        {
            return this.empexp;
        }

        public string Getempprojectdetails()
        {
            return this.empprojectdetails;
        }

        public int Getempaccountno()
        {
            return this.empaccno;
        }
    }
}
