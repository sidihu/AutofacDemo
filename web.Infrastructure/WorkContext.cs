using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Web.Infrastructure
{
    public class WorkContext
    {
        public static IContainer Container = null;

        //static WorkContext()
        //{
        //    var baseType = typeof(IService);
        //    var assemblyList = AppDomain.CurrentDomain.GetAssemblies().ToList();
        //    var service = assemblyList.SelectMany(c => c.GetTypes()).Where(c => baseType.IsAssignableFrom(c) && c != baseType);

        //    string dllPath = System.IO.Path.GetDirectoryName(new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath) + "\\Achieve.dll";
        //    var assembly = System.Reflection.Assembly.LoadFile(dllPath);

        //    var builder = new ContainerBuilder();
        //    builder.RegisterAssemblyTypes(assemblyList.ToArray())
        //        .Where(c => baseType.IsAssignableFrom(c) && c != baseType)
        //        .AsImplementedInterfaces().InstancePerLifetimeScope();

        //    builder.RegisterAssemblyTypes(assembly)
        //        .Where(c => baseType.IsAssignableFrom(c) && c != baseType)
        //        .AsImplementedInterfaces().InstancePerLifetimeScope();

        //    iContainer = builder.Build();
        //    builder.RegisterModule(new Autofac.Configuration.ConfigurationSettingsReader("autofac"));

        //}

        public static IService GetServiceObject()
        {
            //if (iContainer != null)
            return Container.ResolveNamed<IService>("MyService");
        }

        public static IConsumer GetConsumerObject()
        {
            //if (iContainer != null)
            return Container.ResolveNamed<IConsumer>("MyConsumer");
        }
    }
}
