using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.DependencyTest
{
    public class Dependen : IDependen
    {
        public Guid InstanceId { get; }

        public Dependen()
        {
            this.InstanceId = Guid.NewGuid();
        }
    }
}