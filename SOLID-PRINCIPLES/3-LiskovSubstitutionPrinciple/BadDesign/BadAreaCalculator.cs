
namespace SOLID_PRINCIPLES._3_LiskovSubstitutionPrinciple.BadDesign
{
    public class BadAreaCalculator
    {
        public static double CalculateArea(BadDikdortgen badDikdortgen)
        {
            return badDikdortgen.Height * badDikdortgen.Width;
        }

        public static double CalculateArea(BadKare badKare)
        {
            return badKare.Height * badKare.Width;
        }
    }
}
