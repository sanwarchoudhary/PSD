using PDC.Business.Class;
using PDC.Business.Interface;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace PDC.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IProduct, Product>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}