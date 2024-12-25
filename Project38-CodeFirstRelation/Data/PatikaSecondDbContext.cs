using Microsoft.EntityFrameworkCore;

namespace Project38_CodeFirstRelation.Data
{
    public class PatikaSecondDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=123456eda;Database=PatikaCodeFirstDb2");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
                entity.Property(x => x.Username).IsRequired().HasMaxLength(150);
                entity.Property(x => x.Email).IsRequired();
            });

            modelBuilder.Entity<User>().HasData
                   (
                     new User { Id = 1, Username = "Ferdi Tayfur", Email = "ferdi01adana@gmail.com" },
                     new User { Id = 2, Username = "Kamuran Akkor", Email = "kamurannkoor@gmail.com" },
                     new User { Id = 3, Username = "Neşet Ertaş", Email = "nesedertask@gmail.com" }
                   );

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Title).IsRequired().HasMaxLength(100);
                entity.Property(x => x.Content).IsRequired().HasMaxLength(150);
            });
            modelBuilder.Entity<Post>().HasData
                    (
                          new Post { Id = 1, Title = "Aşk", Content = "Bana sor yalnızlığı, ayrılığı bana sor\r\nMutluluğu bilirsin, mutsuzluğu bana sor", UserId = 1 },
                          new Post { Id = 2, Title = "Özlem", Content = "Datlı dillim, güler yüzlüm, ey ceylan gözlüm\r\nGöğnüm hep seni arıyor, neredesin sen?", UserId = 3 },
                          new Post { Id = 3, Title = "Umut", Content = "Sevenin halinden sevenler anlar\r\nGel gör şu halimi bir teselli ver", UserId = 2 },
                          new Post { Id = 4, Title = "İsyan", Content = "Aşka susayan gönlümü\r\nSeveceksen sev yeter", UserId = 2 }
                    );

            using (var db = new PatikaSecondDbContext())
            {
                try
                {
                    db.Database.OpenConnection();
                    Console.WriteLine("Veritabanı bağlantısı başarılı!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Veritabanı bağlantısı başarısız: {ex.Message}");
                }
            }

        }

    }
}
