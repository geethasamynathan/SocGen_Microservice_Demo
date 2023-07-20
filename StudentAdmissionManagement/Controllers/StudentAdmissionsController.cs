using Microsoft.AspNetCore.Mvc;
using StudentAdmissionManagement.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionsController : ControllerBase
    {
        // GET: api/<StudentAdmissionsController>
        [HttpGet]
        public IEnumerable<StudentAdmissionDetailModel> Get()
        {
            StudentAdmissionDetailModel studentAdmission1=new StudentAdmissionDetailModel();
            StudentAdmissionDetailModel studentAdmission2=new StudentAdmissionDetailModel();
            studentAdmission1.StudentID = 123;
            studentAdmission1.StudentName = "Keerthana";
            studentAdmission1.StudentBranch = "CSE";
            studentAdmission1.DateOfJoining = DateTime.Now;
            studentAdmission2.StudentID = 124;
            studentAdmission2.StudentName = "Susheel";
            studentAdmission2.StudentBranch = "ECE";
            studentAdmission2.DateOfJoining = DateTime.Now;
            List<StudentAdmissionDetailModel> studentAdmissionDetailModels = new List<StudentAdmissionDetailModel>();
            studentAdmissionDetailModels.Add(studentAdmission1);
            studentAdmissionDetailModels.Add(studentAdmission2);
            return studentAdmissionDetailModels;

        }

        // GET api/<StudentAdmissionsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAdmissionsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAdmissionsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAdmissionsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
