using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Infrastructure;

namespace AutoFacDemo
{
    class Program
    {
        public static IService service { get; set; }

        //public void a()
        //{
        //    this.service.WriteString("aa");
        //}
        static void Main(string[] args)
        {
            service =  WorkContext.GetServiceObject();
            service.WriteString("aa");
            //Program p = new Program();
            //p.a();
        }


        public void GetCar()
        {
           //ICar c = 
        }
    }
}
