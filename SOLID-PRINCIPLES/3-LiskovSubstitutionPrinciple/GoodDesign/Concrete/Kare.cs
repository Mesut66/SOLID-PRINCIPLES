using SOLID_PRINCIPLES._3_LiskovSubstitutionPrinciple.GoodDesign.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._3_LiskovSubstitutionPrinciple.GoodDesign.Concrete
{
    public class Kare: Sekil
    {
        public double KareAlan()
        {
            return Edge * Edge;
        }
    }
}
