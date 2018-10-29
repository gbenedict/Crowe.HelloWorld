using Crowe.HelloWorld.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crowe.HelloWorld.Data.Interfaces
{
    public interface IHelloWorldRepository
    {
        Models.HelloWorld Read();
        bool Write(string description);
    }
}
