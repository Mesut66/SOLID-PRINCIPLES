using SOLID_PRINCIPLES._1_SingleResponsiblePrinciple.GoodDesign;
using SOLID_PRINCIPLES._1_SingleResponsiblePrinciple.Model;

SchoolModel model = new SchoolModel();

model.Id = 1;
model.Name = "Reşat Nuri";
model.Address = "EyüpSultan";
model.FoundingYear = DateTime.Now;

School school = new School();

school.AddSchool(model);
