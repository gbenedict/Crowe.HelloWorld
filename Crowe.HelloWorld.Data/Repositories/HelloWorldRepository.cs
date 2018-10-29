using Crowe.HelloWorld.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crowe.HelloWorld.Data.Repositories
{
    public class HelloWorldRepository : IHelloWorldRepository
    {
        private DbContext _dbContext = null;
        
        public HelloWorldRepository(DbContext dbContext = null)
        {
            _dbContext = dbContext;
        }

        public Models.HelloWorld Read()
        {
            if (_dbContext == null)
                return new Models.HelloWorld { Description = "Hello World" };
            else
                throw new NotImplementedException();
        }

        public bool Write(string text)
        {
            if (_dbContext == null)
                return true;
            else
                throw new NotImplementedException();
        }
    }
}
