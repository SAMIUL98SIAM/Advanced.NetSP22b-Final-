using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class PersonController : ApiController
    {
        [HttpGet]
        public List<string> Get()
        {
            List<string> names = new List<string>();
            names.Add("Siam");
            names.Add("Akib");
            names.Add("Hasib");
            names.Add("Razib");

            return names;
        }


        [HttpGet]
        public string Get(int id)
        {
            return "Name " + id;
        }
        [HttpPost]
        public string Post()
        {
            return "Posted ";
        }

        public string Put(string name,int id)
        {
            return "Posted " + name +  " ID: "+ id;
        }

        public string Delete(string name,int id)
        {
            return "Delete " + name + " " + id;
        }


    }
}
