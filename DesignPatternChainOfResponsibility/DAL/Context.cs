using Microsoft.EntityFrameworkCore;

namespace DesignPatternChainOfResponsibility.DAL
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;initial catalog=AkademiPlusChainOf;integrated security=true");
        }

        public DbSet<CustomerProcess>  CustomerProcesses{ get; set; }
    }
}
