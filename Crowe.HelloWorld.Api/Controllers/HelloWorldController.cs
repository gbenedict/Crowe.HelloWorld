using Crowe.HelloWorld.Business.Interfaces;
using Crowe.HelloWorld.Business.Services;
using Crowe.HelloWorld.Data;
using Crowe.HelloWorld.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Crowe.HelloWorld.Api.Controllers
{
    public class HelloWorldController : ApiController
    {
        private IHelloWorldService _helloWorldService;
        
        // For reference, I've stubbed out the basics of dependency injection without actually doing it.
        // We don't need it until we implement the db side.

        public HelloWorldController(DbContext dbContext)
        {
            _helloWorldService = new HelloWorldService(new HelloWorldRepository(dbContext));
        }

        public HelloWorldController()
        {
            _helloWorldService = new HelloWorldService(new HelloWorldRepository());            
        }

        public HelloWorldController(IHelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        [HttpGet]
        public IHttpActionResult Index()
        {
            var result = _helloWorldService.Read();
            var results = new List<Data.Models.HelloWorld>();
            results.Add(result);

            return Json(results);
        }
    }
}
