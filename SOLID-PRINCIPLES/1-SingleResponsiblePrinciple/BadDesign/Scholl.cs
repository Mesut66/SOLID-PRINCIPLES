using SOLID_PRINCIPLES._1_SingleResponsiblePrinciple.Model;
using System.Text;


namespace SOLID_PRINCIPLES._1_SingleResponsiblePrinciple.BadDesign
{
    public class Scholl
    {
        public void AddSchool(SchoolModel school)

        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(school.Id); sb.AppendLine();
                sb.Append(school.Name); sb.AppendLine();
                sb.Append(school.Address); sb.AppendLine();
                sb.Append(school.FoundingYear); sb.AppendLine();
                File.WriteAllText(@"C:\SchoolLog.txt", sb.ToString());

            }
            catch (Exception ex)
            {
                sb = new StringBuilder();
                sb.Append("Error Date:");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Error Message:");
                sb.Append(ex.Message);
                File.WriteAllText(@"C:\SchoolLog.txt", ToString());
                Console.WriteLine("Warning Error!");
            }
        }
    }
}
