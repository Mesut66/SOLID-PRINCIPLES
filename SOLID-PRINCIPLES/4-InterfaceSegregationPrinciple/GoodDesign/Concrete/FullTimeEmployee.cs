﻿
using SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.BadDesign.Interfaces;

namespace SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.GoodDesign.Concrete
{
    public class FullTimeEmployee: IFullTimeWorkerSalary
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal Status { get; set; }
        public decimal HourlyRate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal HoursInMonth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal CalaculateWorkedSalary() => MonthlySalary + Status;

        public decimal CalculateNetSalary()
        {
            throw new NotImplementedException();
        }
    }
}
