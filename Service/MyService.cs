using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Infrastructure;

namespace Plug.Service
{
    public class MyService :IService
    {
        public Guid InstanceId { get; private set; }

        public MyService()
        {
            this.InstanceId = Guid.NewGuid();
        }

        public string CreateService(string param)
        {
            return $"Create Service :{param}";
        }

        public void WriteService(string param)
        {
            Console.Write($"Service is {param}");
            Console.ReadLine();
        }
    }
}
