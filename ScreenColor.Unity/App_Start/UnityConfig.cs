using System.Web.Mvc;
using ScreenColor.Common.Interfaces;
using ScreenColor.Common.Services;
using Unity;
using Unity.Mvc5;

namespace ScreenColor.Unity
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IColorService, GreenService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}