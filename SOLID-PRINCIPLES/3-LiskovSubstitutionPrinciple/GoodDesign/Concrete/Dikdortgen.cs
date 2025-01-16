using SOLID_PRINCIPLES._3_LiskovSubstitutionPrinciple.GoodDesign.Abstract;


namespace SOLID_PRINCIPLES._3_LiskovSubstitutionPrinciple.GoodDesign.Concrete
{
    public class Dikdortgen: Sekil
    {
        public int Width { get; set; }
        public double DikdortgenAlan()
        {
            return Width * Edge;
        }
    }
}
