// The Service handles the logic

using API_Database.Data;
using API_Database.Models;

namespace API_Database.Services.Students;

// When we inherit from IStudentService, we have to follow the blueprint that it laid out, all of the Methods, their names, return types, and parameters
public class StudentService : IStudentService
{
    private readonly DataContext _db;

    public StudentService(DataContext db)
    {
        _db = db;
    }

    public List<Student> AddStudent(string studentName)
    {
        Student newStudent = new();
        newStudent.Name = studentName;

        _db.Students.Add(newStudent);
        _db.SaveChanges();

        return _db.Students.ToList();
    }

    public List<Student> DeleteStudent(string studentName)
    {
        var student = _db.Students.FirstOrDefault(foundStudent => foundStudent.Name == studentName);
        if(student != null) {
            _db.Students.Remove(student);
            _db.SaveChanges();
        }

        return _db.Students.ToList();
    }

    public List<Student> GetStudents()
    {
        return _db.Students.ToList();
    }

    public List<Student> UpdateStudent(string oldName, string newName)
    {
        var student = _db.Students.FirstOrDefault(foundStudent => foundStudent.Name == oldName);
        if(student != null){
            student.Name = newName;
            _db.SaveChanges();
        }
        return _db.Students.ToList();
    }
}