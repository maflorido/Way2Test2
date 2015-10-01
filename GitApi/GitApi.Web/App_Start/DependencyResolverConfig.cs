using Autofac;
using Autofac.Integration.Mvc;
using GitApi.Web.GitRepositorios;
using System.Web.Mvc;

namespace GitApi.Web
{
    public class DependencyResolverConfig
    {
        public static void Config()
        {
            ContainerBuilder builder = new ContainerBuilder();
            var assembly = typeof(DependencyResolverConfig).Assembly;

            builder.RegisterControllers(assembly);

            builder.RegisterModelBinders(assembly);
            builder.RegisterModelBinderProvider();
            builder.RegisterFilterProvider();

            builder.RegisterType<GitRepositoriosConfig>().AsSelf();
            builder.RegisterType<GitClient>().AsSelf();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
        
        
    }
}