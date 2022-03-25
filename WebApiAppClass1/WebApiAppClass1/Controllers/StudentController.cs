using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAppClass1.Models.Database;

namespace WebApiAppClass1.Controllers
{
    public class StudentController : ApiController
    {
        [Route("api/student/add")]
        [HttpPost]
        public string Post(Student s)
        {
            Api1Entities db = new Api1Entities();
            db.Students.Add(s);
            db.SaveChanges();
            return "Student Added";
        }
        [Route("api/student/get")]
        [HttpGet]
        public List<Student> Get()
        {
            Api1Entities db = new Api1Entities();
            var data = db.Students.ToList();
            return data;
        }
        [Route("api/student/get/{id}")]
        [HttpGet]
        public Student Get(int id)
        {
            Api1Entities db = new Api1Entities();
            Student student = db.Students.Find(id);
            return student;
        }
        [Route("api/student/update/{id}")]
        [HttpPut]
        public string Put(int id,Student update_student)
        {
            Api1Entities db = new Api1Entities();
            Student student = db.Students.Find(id);
            student.Name = update_student.Name;
            student.DOB = update_student.DOB;
            student.CGPA = update_student.CGPA;

            db.Entry(student).State = System.Data.EntityState.Modified;
            db.SaveChanges();

            return "Student Updated";
        }
        [Route("api/student/delete/{id}")]
        [HttpDelete]
        public string delete(int id)
        {
            Api1Entities db = new Api1Entities();
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return "Student Deleted";
        }
    }
}
