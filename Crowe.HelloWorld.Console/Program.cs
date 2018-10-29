using Crowe.HelloWorld.Business.Services;
using Crowe.HelloWorld.Data;
using Crowe.HelloWorld.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowe.HelloWorld.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldService helloWorldService;

            string dataSource = ConfigurationManager.AppSettings["DataSource"];

            switch (dataSource)
            {
                case "memory":
                    helloWorldService = new HelloWorldService(new HelloWorldRepository());
                    break;
                case "database":
                    DbContext dbContext = new DbContext(); // This is faked do show you where it could go.
                    helloWorldService = new HelloWorldService(new HelloWorldRepository(dbContext));
                    break;
                default:
                    throw new NotImplementedException();
            }

            System.Console.WriteLine(helloWorldService.Read().Description);
            System.Console.ReadLine();
        }
    }
}
