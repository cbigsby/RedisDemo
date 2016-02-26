using System.Collections.Generic;
using IQ.Catalogs.Web.Api.Contract.v1;

namespace RedisDemo.Services
{
    public interface ICatalogService
    {
        IEnumerable<CatalogItemResource> GetCatalogItems(int companyId);
    }
}