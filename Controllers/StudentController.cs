// The Controller handles the requests and returns that happen when someone calls the Endpoint
// It calls the Interface to match it's Method to what the request is asking for, and returns the output

using API_Database.Models;
using API_Database.Services.Students;
using Microsoft.AspNetCore.Mvc; // Added with [ApiController]

namespace API_Database.Controllers;

[ApiController] // Telling dotnet to read this file as an Api Controller
[Route("[controller]")] // Removing the need to type controller to access this file

public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService; // A saved reference of our Interface

    public StudentController(IStudentService studentService) // Constructor - runs first when the class is called
    // Injecting our Interface into our Controller named studentService
    {
        // Saving a reference to our Interface to a field named _studentService so when we call it, we can access it's Methods
        _studentService = studentService;
    }

    [HttpGet] // use Get to get/pull data
    [Route("FetchQuest")] // Route name does not have to match Method name, but Routes give a specific Address to each Method
    public List<Student> GetStudents()
    {
        // Accessing the GetStudents() from our Interface
        return _studentService.GetStudents();
    }

    [HttpPost] // use Post to add Data
    [Route("AddStudent/{studentName}")] // To pass data through Routes add /{parameter name}
    public List<Student> AddStudent(string studentName)
    {
        return _studentService.AddStudent(studentName);
    }

    [HttpDelete] // use Delete to delete data - not really don't do this
    [Route("DeleteStudent/{studentName}")]
    public List<Student> DeleteStudent(string studentName)
    {
        return _studentService.DeleteStudent(studentName);
    }

    [HttpPut] // use Put to update data
    [Route("EditStudent/{oldName}/{newName}")]
    public List<Student> UpdateStudent(string oldName, string newName)
    {
        return _studentService.UpdateStudent(oldName, newName);
    }
}
