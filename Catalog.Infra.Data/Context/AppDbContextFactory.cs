using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Catalog.Infra.Data.Context
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>

    {

        public ApplicationDbContext CreateDbContext(string[] args)

        {

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS2019; Initial Catalog=sales-catalog; User Id=sa; Password=admin123; MultipleActiveResultSets=true;");

            return new ApplicationDbContext(optionsBuilder.Options);

        }

    }
}