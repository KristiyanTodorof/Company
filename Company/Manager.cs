using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Manager : User
    {
        
        public List<Employee> Employees { get; protected set; }
        public string Email { get; protected set; }

        public Manager(string username, string password, string email) : base(username, password)
        {
            Email = email;
            Employees = new List<Employee>();
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Manager: {Username}");
            foreach (var employee in Employees)
            {
                Console.WriteLine($"Name: {employee.Username}, Department: {employee.DepName} ");
            }
        }
    }
}
