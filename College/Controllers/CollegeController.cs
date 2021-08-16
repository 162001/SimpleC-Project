using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using College.Models;

namespace College.Controllers
{
    public class CollegeController : ApiController
    {
        public CollegeEntities x = new CollegeEntities();
        [HttpGet]
        public List<Student> GetStudents()
        {
            return x.Students.ToList();
        }
        public IHttpActionResult PostStudent([FromBody] Student student)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            else
            {
                x.Students.Add(student);
            }
            try
            {
                x.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (StudentExists(student))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }    
            }
            return CreatedAtRoute("DefaultApi", new { id = student.stu_id }, student);
        }

        private bool StudentExists(Student student)
        {
            return x.Students.Count(e => e.stu_id == student.stu_id) > 0;
        }
    }
}
