using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : ApiController
    {
        IList<Student> studentList = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                CourseId = 1,
                UserName= "Nil",
                Age= 30
            },
            new Student()
            {
                Id = 2,
                CourseId = 2,
                UserName= "Satya",
                Age= 22
            },
            new Student()
            {
                Id = 3,
                CourseId = 1,
                UserName= "Deboshree",
                Age= 27
            }
        };

        public IList<Student> GetAllStudent()
        {
            return studentList;
        }

        public IList<Student> GetById(long id)
        {
            IList<Student> studentListByCourseId = studentList.Where(st => st.CourseId == id).ToList();
            if (studentListByCourseId.Count > 0)
            {
                return studentListByCourseId;
            }
            else
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

        }

    }
}
