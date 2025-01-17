using SOLID_PRINCIPLES._5_Dependency_Inversion_Principle.GoodDesign;


namespace SOLID_PRINCIPLES._5_Dependency_Inversion_Principle.GoodDesign
{
    public class Email : IMessageType
    {
        public void Send(string message)
        {
            //... send e-mail
            Console.WriteLine("E-mail has been sent");
        }
    }
}
