using System;
using System.Collections.Generic;
using System.Text;

namespace Crowe.HelloWorld.Business.Interfaces
{
    public interface IHelloWorldService
    {
        Data.Models.HelloWorld Read();
        bool Write(string description);
    }
}
