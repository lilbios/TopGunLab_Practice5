using FlowerDelivery.Web.App_Start;
using Ninject;
using Ninject.Web.Mvc;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FlowerDelivery.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
          
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var registrationModule = new NinjectWebCommon();
            var kernel = new StandardKernel(registrationModule);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));


        }
    }
}
