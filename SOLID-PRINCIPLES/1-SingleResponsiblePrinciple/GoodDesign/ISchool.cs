using SOLID_PRINCIPLES._1_SingleResponsiblePrinciple.Model;


namespace SOLID_PRINCIPLES._1_SingleResponsiblePrinciple.GoodDesign
{
    public interface ISchool
    {
        void AddSchool(SchoolModel school);
        void LogFile(string filePath, string log);
    }
}
