using System.Linq;
using ExelTools.Models;

namespace ExelTools.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        public IQueryable<ToolsProduct> GetProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}