using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using ScreenColor.Common.Interfaces;
using ScreenColor.Common.Services;

namespace ScreenColor.Autofac
{
    public class AutofacConfig
    {
        public static IContainer Setup()
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            var builder = new ContainerBuilder();

            RegisterDependencies(currentAssembly, builder);

            var container = builder.Build();
            var resolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(resolver);

            return container;
        }

        public static void RegisterDependencies(Assembly currentAssembly, ContainerBuilder builder)
        {
            // Register your MVC controllers.
            builder.RegisterControllers(currentAssembly);

            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();

            builder.RegisterType<RedService>().As<IColorService>().InstancePerLifetimeScope();
        }

    }
}