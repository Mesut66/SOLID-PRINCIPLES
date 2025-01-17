

namespace SOLID_PRINCIPLES._5_Dependency_Inversion_Principle.GoodDesign
{
    public class Sms : IMessageType
    {
        public void Send(string message)
        {
            //... send sms
            Console.WriteLine("Sms has been sent");
        }
    }
}
