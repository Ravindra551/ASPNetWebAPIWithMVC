using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASPNetWebAPIWithMVC.Controllers
{
    public class HelloWorldController : ApiController
    {
        public string Get()
        {
            return "Hello World";
        }

        // GET api/HelloWorld/id
        public string Get(string id)
        {
            return "Hello " + id;
        }
    }
}
