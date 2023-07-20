using Microsoft.AspNetCore.Mvc;
using StudentAttendanceManagement.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        // GET: api/<StudentAttendanceController>
        [HttpGet]
        public IEnumerable<StudentAttendanceDetailsModel> Get()
        {
            StudentAttendanceDetailsModel student1 = new StudentAttendanceDetailsModel();
            StudentAttendanceDetailsModel student2 = new StudentAttendanceDetailsModel();
            student1.StudentID = 123;
            student1.StudentName = "Keerthana";
            student1.AttendancePercentage = 90;
            student2.StudentID = 124;
            student2.StudentName = "Susheel";
            student2.AttendancePercentage = 91;
          
            List<StudentAttendanceDetailsModel> studentAttendances = new List<StudentAttendanceDetailsModel>();
            studentAttendances.Add(student1);
            studentAttendances.Add(student2);
            return studentAttendances;
        }

        // GET api/<StudentAttendanceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAttendanceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAttendanceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAttendanceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
