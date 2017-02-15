using System.Linq;
using ExelTools.Models;

namespace ExelTools.Repository
{
    public interface IProductsRepository
    {
        IQueryable<ToolsProduct> GetProducts();
    }
}