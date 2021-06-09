using Catalog.API.Entities;

namespace Catalog.API.Data
{
    public class CatalogContextBase
    {

        public MongoDB.Driver.IMongoCollection<Product> Products { get; }
    }
}