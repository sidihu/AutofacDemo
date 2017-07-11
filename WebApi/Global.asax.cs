using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Web.Infrastructure;
using WebApi.DependencyTest;
using Autofac.Integration.Mvc;

namespace WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        // Provider that holds the application container.
        //static IContainerProvider _containerProvider;

        //// Instance property that will be used by Autofac HttpModules
        //// to resolve and inject dependencies.
        //public IContainerProvider ContainerProvider
        //{
        //    get { return _containerProvider; }
        //}

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            #region webconfig 配置模式
            //var builder = new ContainerBuilder();
            ////autofac4.0版本之前可以使用如下方式注册模块  4.0版本之后使用参考http://www.cnblogs.com/caoyc/p/6370650.html
            //builder.RegisterModule(new Autofac.Configuration.ConfigurationSettingsReader("autofac"));
            //WorkContext.Container = builder.Build();
            #endregion

            //var builder = new ContainerBuilder();
            //builder.RegisterType<Dependen>().As<IDependen>();
            //WorkDependen.container = builder.Build();

            //实现依赖注入
            RegisterService();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));

        }

        private void RegisterService()
        {
            var builder = new ContainerBuilder();

            var baseType = typeof(IDependen);
            var assemblys = AppDomain.CurrentDomain.GetAssemblies().ToList();
            
            //var AllServices = assemblys
            //    .SelectMany(s => s.GetTypes())
            //    .Where(p => baseType.IsAssignableFrom(p) && p != baseType);

            //注册mvc容器的实现  
            builder.RegisterControllers(assemblys.ToArray());

            builder.RegisterAssemblyTypes(assemblys.ToArray())
                   .Where(t => baseType.IsAssignableFrom(t) && t != baseType)
                   .AsImplementedInterfaces().InstancePerLifetimeScope();
            //注册MVC容器 
            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }
    }
}
