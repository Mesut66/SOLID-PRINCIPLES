

namespace SOLID_PRINCIPLES._3_LiskovSubstitutionPrinciple.BadDesign
{
    public class BadKare: BadDikdortgen
    {

        int _height;
        int _width;

        public override int Height
        {
            get => _height;
            set => _height = value;
        }

        public override int Width
        {
            get => _width;
            set => _width = value; 
        }
    }
}
