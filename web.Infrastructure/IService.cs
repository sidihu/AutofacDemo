using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Infrastructure
{
    public interface IService : IDependency
    {
        Guid InstanceId { get; }

        string CreateService(string param);

        void WriteService(string param);
    }
}
