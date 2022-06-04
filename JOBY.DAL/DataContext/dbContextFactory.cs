using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace JOBY.DAL.DataContext
{
    class dbContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string [] args)
        {
            AppConfiguration appConfiguration = new AppConfiguration();
            var opsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            opsBuilder.UseSqlServer(appConfiguration.sqlConnectionString);
            return new DatabaseContext(opsBuilder.Options);
        }
    }
}
