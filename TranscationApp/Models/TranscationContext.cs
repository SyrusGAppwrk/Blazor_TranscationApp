using Microsoft.EntityFrameworkCore;

namespace TranscationApp.Models
{
    public partial class TranscationContext : DbContext
    {
        public TranscationContext(DbContextOptions<TranscationContext> options) : base(options)
            {

             }

        public DbSet<TranscationModel> Transactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=APPWRK20; Database=SyrusTransactionApp; Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TranscationModel>(entity =>
            {
                entity.Property(e => e.id).ValueGeneratedOnAdd();
                entity.Property(e => e.Date).HasDefaultValueSql("(getdate())");
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
