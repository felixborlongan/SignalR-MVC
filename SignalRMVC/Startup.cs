using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using SignalRDAL;
using SignalRInterface;
using SignalRModel;
using System.Web.Services.Description;
using Unity;

[assembly: OwinStartupAttribute(typeof(SignalRMVC.Startup))]
namespace SignalRMVC
{
    public partial class Startup
    { 
        public void Configuration(IAppBuilder app)
        {
            IUnityContainer container = UnityConfig.RegisterComponents();
            
            GlobalHost.DependencyResolver.Register(typeof(ChatHub), () => new ChatHub(container.Resolve<IDataAccessLayer<User>>(), container.Resolve<IDataAccessLayer<Chat>>()));

            app.MapSignalR();
        }
    }
}
