using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Director : User
    {
        public Director(string username, string password) : base(username, password)
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine("Not Allowed!");
        }
    }
}
