using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class StudentModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public double CGPA { get; set; }
        public int Product_id { get; set; }

        public virtual ProductModel Product { get; set; }
    }
}
