using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Infrastructure;

namespace Plug.Consumer
{
    public class MyConsumer :IConsumer
    {
        public string CreateConsumer(string param)
        {
            return $"Create Consumer :{param}";
        }

        public void WriteConsumer(string param)
        {
            Console.Write($"Consumer is {param}");
            Console.ReadLine();
        }
    }
}
