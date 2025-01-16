

namespace SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.BadDesign.Interfaces
{
    public interface IBaseWorker
    {
        string ID { get; set; }
        string Name { get; set; }
        string Email { get; set; }
    }
}
