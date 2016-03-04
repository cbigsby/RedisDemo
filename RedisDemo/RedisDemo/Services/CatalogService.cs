using System.Collections.Generic;
using IQ.Catalogs.Client;
using IQ.Catalogs.Web.Api.Contract.v1;
using IQ.Phoenix.ServiceClient.Common;

namespace RedisDemo.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly ICatalogsClient _catalogsClient;

        public CatalogService(ICatalogsClientFactory catalogsClientFactory)
        {
            _catalogsClient = catalogsClientFactory.Create(TokenSource.Service);
        }

        public IEnumerable<CatalogItemResource> GetCatalogItems(int companyId)
        {
            return _catalogsClient.GetAllCatalogItems(companyId);
        }
    }
}