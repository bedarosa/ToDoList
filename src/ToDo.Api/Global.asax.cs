using System.Web;
using System.Web.Http;

namespace ToDo.Api
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            ToDoList.CrossCutting.SimpleInjector.RegisterDIContainer();
        }
    }
}
