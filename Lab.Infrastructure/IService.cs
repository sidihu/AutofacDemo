using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Infrastructure
{
    public interface IService: IDependency
    {
        string CreateString(string param);

        void WriteString(string param);
    }
}
