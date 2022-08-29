using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace HandsOnControllerandModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        //Action Methods//EndPoints
        [HttpGet,Route("GetCourses")]
        public List<string> GetCourses()
        {
            return new List<string>() { "Angular", "React", "Asp.net Core WebAPI" };
        }
        [HttpGet,Route("GetCourseById/{id}")]
        public string GetCourse(int id)
        {
            return "React";
        }
        [HttpPost,Route("AddCourse")]
        public string Add()
        {
            return "Course Added";
        }
        [HttpPut,Route("EditCourse")]
        public string EditCourse()
        {
            return "Course Edited";
        }
        [HttpDelete,Route("DeleteCourse/{name}")]
        public string DeleteCourse(string name)
        {
            return "Course Deleted";
        }

    }
}
