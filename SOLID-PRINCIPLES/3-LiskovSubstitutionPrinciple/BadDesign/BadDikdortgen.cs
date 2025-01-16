

namespace SOLID_PRINCIPLES._3_LiskovSubstitutionPrinciple.BadDesign
{
    //Bu üst sınıf olsun
    public class BadDikdortgen
    {
        public virtual int Height { get; set; } //virtual ovvaride edebilirsin
        public virtual int Width { get; set; }
    }
}
