using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = StudentService.GetNames();
            foreach (var name in data)
            {
                Console.WriteLine(name);
            }
        }
    }
}
