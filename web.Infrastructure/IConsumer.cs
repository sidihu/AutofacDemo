using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Infrastructure
{
    public interface IConsumer : IDependency
    {
        string CreateConsumer(string param);

        void WriteConsumer(string param);
    }
}
