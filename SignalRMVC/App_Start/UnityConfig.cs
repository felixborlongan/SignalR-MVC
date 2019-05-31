using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using SignalRInterface;
using SignalRDAL;
using SignalRModel;
using Unity.Injection;
using Microsoft.AspNet.SignalR;

namespace SignalRMVC
{
    public static class UnityConfig
    {
        public static IUnityContainer RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IRepository, DBContext>();
            container.RegisterType<IDataAccessLayer<Chat>, ChatDAL>();
            container.RegisterType<IDataAccessLayer<User>, UserDAL>();  
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            //GlobalHost.DependencyResolver = new SignalRUnityDependencyResolver(container);

            return container;
        }
    }
}