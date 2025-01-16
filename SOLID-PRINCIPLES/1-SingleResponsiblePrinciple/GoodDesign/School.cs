using SOLID_PRINCIPLES._1_SingleResponsiblePrinciple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._1_SingleResponsiblePrinciple.GoodDesign
{
    public class School : ISchool
    {
        string save;
        public void AddSchool(SchoolModel school)
        {
            StringBuilder sb = new StringBuilder();
            
            try
            {
                sb.Append(school.Id); sb.AppendLine();
                sb.Append(school.Name); sb.AppendLine();
                sb.Append(school.Address); sb.AppendLine();
                sb.Append(school.FoundingYear); sb.AppendLine();

                save = BuildLog(sb.ToString());
                LogFile(@"C:\Users\genme\OneDrive\Masaüstü\solid\SOLID-PRINCIPLES\SOLID-PRINCIPLES\1-SingleResponsiblePrinciple\GoodDesign\SchoolLog.txt", save);

                Console.WriteLine($"School insert successfull => {school.Id}");
                LogFile(@"C:\Users\genme\OneDrive\Masaüstü\solid\SOLID-PRINCIPLES\SOLID-PRINCIPLES\1-SingleResponsiblePrinciple\GoodDesign\SchoolLog.txt", save);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message:" + ex.Message);
                LogFile(@"C:\Users\genme\OneDrive\Masaüstü\solid\SOLID-PRINCIPLES\SOLID-PRINCIPLES\1-SingleResponsiblePrinciple\GoodDesign\SchoolLog.txt", save);
            }
        }
        

        public void LogFile(string filePath, string log)
        {
            File.WriteAllText(filePath, log);
        }

        public string BuildLog(string information)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Date:");
            sb.Append(DateTime.Now.ToString());
            sb.AppendLine();
            sb.Append("Information:").Append(information);
            return sb.ToString();
        }
    }
}
