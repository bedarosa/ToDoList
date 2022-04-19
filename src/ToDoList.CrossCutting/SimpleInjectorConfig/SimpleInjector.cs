using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System.Web.Http;
using ToDoList.Data.Context;
using ToDoList.Data.Repository;
using ToDoList.Data.Repository.Interfaces;
using ToDoList.Service;
using ToDoList.Service.AutoMapper;
using ToDoList.Service.Interfaces;

namespace ToDoList.CrossCutting
{
    public class SimpleInjector
    {
        public static void RegisterDIContainer()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static void InitializeContainer(Container container)
        {
            container.Register<ToDoContext>(Lifestyle.Scoped);
            container.Register<ITarefaRepository, TarefaRepository>(Lifestyle.Scoped);
            container.Register<ITarefaService, TarefaService>(Lifestyle.Scoped);

            container.RegisterSingleton(() => AutoMapperConfig.GetMapperConfiguration().CreateMapper(container.GetInstance));
        }
    }
}
