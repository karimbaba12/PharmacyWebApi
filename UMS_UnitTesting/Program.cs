using UMS_DAL.Models;
using UMS_DAL.Repositories.Faculties;


var context = new UmsContext();
FacultyRepository facultyRepository = new FacultyRepository(context);

var faculties = facultyRepository.GetAll();

foreach (var faculty in faculties)
{
    Console.WriteLine("Name: " + faculty.FacultyName + ", Dean: " + faculty.DeanName);
}
