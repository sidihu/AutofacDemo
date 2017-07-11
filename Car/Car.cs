using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Infrastructure;

namespace Car
{
    public class Car : ICar
    {
        public IService service { get; set; }

        public Car(IService service)
        {
            this.service = service;
        }
    }
}
