using Microsoft.AspNetCore.Mvc;
using Academy_2023.Data;
using Academy_2022.Repositories;
using Academy_2022.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Academy_2022.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        public static List<Course> Courses = new List<Course>();

        public CourseController() 
        {
            //Courses = new List<Course>();
        }
        // GET: api/<CourseController>
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return Courses;
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult<Course> Get(int id)
        {
            foreach(var course in Courses)
            {
                if(course.Id == id) return Ok(course);
            }

            return NotFound();
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Course data)
        {
            Courses.Add(data);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Course data)
        {
            foreach (var course in Courses)
            {
                if (course.Id == id)
                {
                    course.Name = data.Name;
                    course.Description = data.Description;

                    return Ok();
                }
            }

            return NoContent();
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            foreach (var course in Courses)
            {
                if (course.Id == id)
                {
                    Courses.Remove(course);

                    return NoContent();
                }
            }

            return NotFound();
        }
    }
}
