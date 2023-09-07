using Entites;
using Microsoft.EntityFrameworkCore;

namespace NetCoreWebApplication.Data
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<User> Users { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-7C8PUIC; Database=NetCoreWebApplication; Trusted_Connection=True; TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    IsActive = true,
                    Name = "Admin",
                    Password = "123456",
                    UserName = "Admin",
                    Email= "admin@NetCoreWebApplication.net",
                    Phone = "1234567890",
                    SurName = "1234567890"
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
