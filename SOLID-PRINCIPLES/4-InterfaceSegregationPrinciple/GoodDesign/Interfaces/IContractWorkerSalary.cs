

namespace SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.GoodDesign.Interfaces
{
    public interface IContractWorkerSalary: IBaseWorker
    {
        decimal HourlyRate { get; set; }
        decimal HoursInMonth { get; set; }
        decimal CalaculateWorkedSalary();
    }
}
