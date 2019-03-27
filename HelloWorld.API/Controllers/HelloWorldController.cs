using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using HelloWorldAPI.Models;

namespace HelloWorld.API.Controllers
{
    public class HelloWorldController : ApiController
    {
        // modify the type of the db field
        private IHelloWorldAPIContext db = new HelloWorldAPIContext();

        // add these contructors
        public HelloWorldController() { }

        public HelloWorldController(IHelloWorldAPIContext context)
        {
            db = context;
        }

        // GET api/documentation
        /// <summary>
        /// This is how we create a documentation
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult GetHelloWorld()
        {
            Message msg = new Message { Content = " Hello World!" };
            return Json(msg);
        }

        
    }
}