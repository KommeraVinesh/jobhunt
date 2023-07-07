using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //endpoints
        [HttpGet,Route("GetStudents")]
        public string[] GetStudents()
        {
            return new string[]{ "rohan", "jason", "karan" };
        }

        //route is used to avoid AMBIGUITY ISSUES
        [HttpGet,Route("GetStudent/{id}")]
        public string GetStudent(string id)
        {
            return "Hello Rohan";
        }

        [HttpPost, Route("AddStudent/{student}")]
        public string AddStudent(string student) {
            return "Student Added";

        }
        [HttpPost, Route("AddStaff")]
        public object AddStaff(object staff)
        {
            return staff;

        }
        [HttpPut, Route("EditStudent")]
        public string UpdateStudent(object student)
        {
            return "student updated";
        }
        [HttpDelete, Route("DeleteStudent/{id}")]
        public string DeleteStudent(string id)
        {
            return "student deleted";
        }
    }
}
