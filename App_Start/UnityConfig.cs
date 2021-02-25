using API.BAL;
using API.DAL;
using API.Entity;
using API.Repository;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace WebAPITest
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IDBContext, DBContext>();
            container.RegisterType<IStudentBAL, StudentBAL>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}