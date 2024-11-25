using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Employee : User
    {
        
        public string DepName { get; protected set; }

        public Employee(string username, string password, string departmentName) : base(username, password)
        {
            DepName = departmentName;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Employee: {Username}");
            Console.WriteLine($"Department: {DepName}");
        }
    }
}
