using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AbpCompanyName.AbpProjectName.EntityFrameworkCore
{
    public static class AbpProjectNameDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpProjectNameDbContext> builder, string connectionString)
        {
            builder.UseSqlite(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpProjectNameDbContext> builder, DbConnection connection)
        {
            builder.UseSqlite(connection);
        }
    }
}
