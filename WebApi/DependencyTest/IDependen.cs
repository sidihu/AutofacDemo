using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.DependencyTest
{
    public interface IDependen
    {
        Guid InstanceId { get; }
    }
}
