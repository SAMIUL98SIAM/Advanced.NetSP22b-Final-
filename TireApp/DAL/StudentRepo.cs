using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentRepo
    {
        static Api1Entities1 db;
        static StudentRepo()
        {
            db = new Api1Entities1();
        }

        public static List<Student> Get()
        {
            return db.Students.ToList();
        }

        public static Student Get(int id)
        {
            return db.Students.FirstOrDefault(e => e.id == id);
        }

        public static void Edit(Student student)
        {
            var ds = db.Students.FirstOrDefault(e => e.id == student.id);
            db.Entry(ds).CurrentValues.SetValues(student);
            db.SaveChanges();
        }

        public static void Delete(int id)
        {
            var ds = db.Students.FirstOrDefault(e => e.id == id);
            db.Students.Remove(ds);
            db.SaveChanges();
        }

        public static void Add(Student s)
        {
            db.Students.Add(s);
            db.SaveChanges();
        }
    }
}
