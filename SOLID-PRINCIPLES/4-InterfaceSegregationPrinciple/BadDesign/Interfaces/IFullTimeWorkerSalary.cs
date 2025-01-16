

namespace SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.BadDesign.Interfaces
{
    public interface IFullTimeWorkerSalary :IBaseWorker
    {
        public decimal HourlyRate { get; set; }
        public decimal HoursInMonth { get; set; }
        decimal MonthlySalary { get; set; }
        decimal Status { get; set; }
        decimal CalculateNetSalary();
        decimal CalaculateWorkedSalary();
    }
}
