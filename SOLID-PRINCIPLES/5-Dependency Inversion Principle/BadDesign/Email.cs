using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._5_Dependency_Inversion_Principle.BadDesign
{
    public class Email
    {
        public void Send(string message)
        {
            //... send e-mail
            Console.WriteLine("E-mail has been sent");
        }
    }
}
