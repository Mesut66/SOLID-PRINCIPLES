

namespace SOLID_PRINCIPLES._5_Dependency_Inversion_Principle.BadDesign
{
    public class Sms
    {
        public void Send(string message)
        {
            //... send sms
            Console.WriteLine("Sms has been sent");
        }
    }
}
