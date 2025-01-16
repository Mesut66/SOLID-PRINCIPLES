

namespace SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.GoodDesign.Interfaces
{
    public interface IFullTimeWorkerSalary: IBaseWorker
    {
        decimal MonthlySalary { get; set; }
        decimal Status { get; set; }
        decimal CalculateNetSalary();
    }
}
