

using SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.GoodDesign.Interfaces;

namespace SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.GoodDesign.Concrete
{
    public class ContractEmployee: IContractWorkerSalary
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal HoursInMonth { get; set; }
        public decimal CalaculateWorkedSalary() => HourlyRate * HoursInMonth;
    }
}
