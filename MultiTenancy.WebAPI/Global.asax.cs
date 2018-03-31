using MultiTenancy.WebAPI.App_Start;
using System.Web.Http;
using WebApi.StructureMap;

namespace MultiTenancy.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.UseStructureMap(x =>
            {
                x.AddRegistry<BaseRegistry>();
            });
        }
    }
}