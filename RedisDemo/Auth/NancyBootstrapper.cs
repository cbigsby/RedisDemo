using System.Reflection;
using IQ.Catalogs.Client;
using Nancy;
using Nancy.Responses.Negotiation;
using Nancy.TinyIoc;
using Nancy.Bootstrapper;
using RedisDemo.Services;

namespace RedisDemo.Auth
{
    public class NancyBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            var tokenSource = new HardCodedTokenSource();

            var clientFactory = new CatalogsClientFactory("Redis Demo", Assembly.GetCallingAssembly())
                {
                    ServiceTokenSource = tokenSource,
                };

            container.Register<ICatalogsClientFactory, CatalogsClientFactory>(clientFactory);
            container.Register<ICatalogService, CatalogService>();

            base.ApplicationStartup(container, pipelines);
        }

        protected override NancyInternalConfiguration InternalConfiguration
        {
            get
            {
                var processors = new[]
                    {
                        typeof (JsonProcessor)
                    };

                return NancyInternalConfiguration.WithOverrides(x => x.ResponseProcessors = processors);
            }
        }
    }
}