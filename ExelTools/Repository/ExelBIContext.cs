using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ExelBI.Models
{
    public class ExelBIContext :DbContext
    {
        public ExelBIContext(DbContextOptions<ExelBIContext> options) : base(options) // video 0704 07:10
        {

        }

        public DbSet<WebProduct> WebProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=TARSAPPIE\\EXELCORE;Integrated Security=False;User ID=sa;Password=5N8bjkly8#;Initial Catalog=stu;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}
