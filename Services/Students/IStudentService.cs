// Our Interface is the blueprint for our Service
// It defines the Methods, return types, and parameters, but not the logic

using API_Database.Models;

namespace API_Database.Services.Students;

public interface IStudentService
{
    List<Student> GetStudents();
    List<Student> AddStudent(string studentName);
    List<Student> DeleteStudent(string studentName);
    List<Student> UpdateStudent(string oldName, string newName);
}