using Microsoft.EntityFrameworkCore;
using OnlineMarketWebAPI.Models;

namespace OnlineMarketWebAPI.DataBaseContext
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

        protected ApplicationDBContext()
        {
        }

        public virtual DbSet<Carbrand> carbrands { get; set; }
        public virtual DbSet<Carbudget> carbudget { get; set; }
        public virtual DbSet<Carfuel> carfuel { get; set; }
        public virtual DbSet<Carkmdriven> carkmdriven { get; set; }
        public virtual DbSet<Carnoofowner> carnoofowner { get; set; }
        public virtual DbSet<State> state { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
