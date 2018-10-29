using Crowe.HelloWorld.Business.Interfaces;
using Crowe.HelloWorld.Data;
using Crowe.HelloWorld.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crowe.HelloWorld.Business.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        IHelloWorldRepository _helloWorldRepository;

        public HelloWorldService(IHelloWorldRepository helloWorldRepository)
        {
            _helloWorldRepository = helloWorldRepository;
        }

        public Data.Models.HelloWorld Read()
        {
            return _helloWorldRepository.Read();
        }

        public bool Write(string description)
        {
            return _helloWorldRepository.Write(description);
        }
    }
}
