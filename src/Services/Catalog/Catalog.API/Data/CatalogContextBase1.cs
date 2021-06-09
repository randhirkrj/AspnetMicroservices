using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextBase1
    {

       public IMongoCollection<Entities.Product> Products { get; }
    }
}