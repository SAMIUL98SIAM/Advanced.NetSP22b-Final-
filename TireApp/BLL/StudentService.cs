using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    public class StudentService
    {
        public static List<StudentModel> Get()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentModel>();
                cfg.CreateMap<Product, ProductModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<StudentModel>>(StudentRepo.Get());
            return data;
        }

        public static List<string> GetNames()
        {
            /*var  sl = StudentRepo.Get();
            var data = (from v in sl select v.Name).ToList();*/
            var data = StudentRepo.Get().Select(e => e.Name).ToList();
            return data;
        }

        public static void Add(StudentModel s)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentModel, Student>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Student>(s);
            StudentRepo.Add(data);
        }
    }
}
