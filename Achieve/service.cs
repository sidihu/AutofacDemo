using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Infrastructure;

namespace Achieve
{
    public class service : IService
    {
        public string CreateString(string param)
        {
            return param;
        }

        public void WriteString(string param)
        {
            Console.Write($"param is {param}");
            Console.ReadLine();
        }
    }
}
