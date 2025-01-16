using SOLID_PRINCIPLES._2_OpenClosedPrinciple.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._2_OpenClosedPrinciple.Concrete
{
    public class Water : GoodDrink
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 3.50;
        }
    }
}
