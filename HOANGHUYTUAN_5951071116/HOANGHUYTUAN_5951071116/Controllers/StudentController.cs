using HOANGHUYTUAN_5951071116.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HOANGHUYTUAN_5951071116.Controllers
{
    public class StudentController : ApiController
    {
        List<Student> studentsList = new List<Student>();

        public IEnumerable<Student> Get()
        {
            studentsList.Add(new Student { Msv = "5951071116", Ten = "Tuấn", DiaChi = "Gia Lai", Email = "Htuan8232@gmail.com" });
            return studentsList;
        }

        // GET: api/Weather/5
        public Student Get(int id)
        {
            return new Student
            {
                Msv = $"{id}",
                Ten = "tuan",
                DiaChi = "Gia Lai",
                Email="htuan8232@gmail.com"
            }; ;
        }
    }
}
