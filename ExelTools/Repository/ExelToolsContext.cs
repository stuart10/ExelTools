using System.Data.Entity;
using ExelTools.Models;

namespace ExelTools.Repository
{
public class ExelToolsContext : DbContext
    {
        public ExelToolsContext() : base("LiveExelDatabase")
        {
        }

        public DbSet<ToolsProduct> ToolsProducts { get; set; }
    }
}