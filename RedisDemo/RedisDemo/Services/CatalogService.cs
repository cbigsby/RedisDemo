using System.Collections.Generic;
using IQ.Catalogs.Client;
using IQ.Catalogs.Web.Api.Contract.v1;

namespace RedisDemo.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly ICatalogsClient _catalogsClient;

        public CatalogService(ICatalogsClient catalogsClient)
        {
            _catalogsClient = catalogsClient;
        }

        public IEnumerable<CatalogItemResource> GetCatalogItems(int companyId)
        {
            return _catalogsClient.GetAllCatalogItems(companyId);
        }
    }
}