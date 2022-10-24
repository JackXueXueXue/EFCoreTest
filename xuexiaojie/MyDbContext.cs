using Microsoft.EntityFrameworkCore;
using xuexiaojie.Models;

namespace xuexiaojie
{
    public class MyDbContext : DbContext
    {
        public DbSet<item> item { get; set; }

        public DbSet<E_order> E_order { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //var connStr = AppSettings.GetAppSetting("DbConnectionString");
            optionsBuilder.UseSqlServer("Data Source = XueComputer\\Xue;Initial Catalog = TestDb;User ID=sa;Password=123456;Encrypt=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //从当前程序集加载所有的IEntityTypeConfiguration
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

    }
}
