using Nancy;
using RedisDemo.Services;

namespace RedisDemo.Endpoints
{
    public class CatalogEndpoint : NancyModule
    {
        private readonly ICatalogService _catalogService;

        public CatalogEndpoint(ICatalogService catalogService)
        {
            _catalogService = catalogService;

            Get["/"] = _ => "hello world";
            Get["/companies({companyId})/catalog"] = _ => GetCompanyCatalog(_.companyId);
        }

        private dynamic GetCompanyCatalog(int companyId)
        {
            return _catalogService.GetCatalogItems(companyId);
        }
    }
}