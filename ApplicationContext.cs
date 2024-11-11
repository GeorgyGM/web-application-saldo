using Microsoft.EntityFrameworkCore;
public class ApplicationContext : DbContext
{

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();   // создаем базу данных при первом обращении
        //Database.EnsureDeleted();
         //{ Database.EnsureDeleted(); }
    }
    ~ApplicationContext() { Database.EnsureDeleted(); }
    //public ApplicationContext
    public DbSet<saldoRow> saldoRows { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    
    
    
   /*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Nam = "Tom", Age = 37 },
                new User { Id = 2, Nam = "Bob", Age = 41 },
                new User { Id = 3, Nam = "Sam", Age = 24 }
        );
        modelBuilder.Entity<saldoRow>().ToTable("Users", "log");
    }*/
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<saldoRow>().HasData(
            new saldoRow { Id = 1, perio = "May 2024" , saldoIncome = 0, nachisleno = 50, 
                           perer = -1, itogoNach = 49, oplach = 5, saldoOutcome = 44 },
            new saldoRow
            {
                Id = 2,
                perio = "May 2024",
                saldoIncome = 0,
                nachisleno = 50,
                perer = -1,
                itogoNach = 49,
                oplach = 5,
                saldoOutcome = 44
               }); 
               modelBuilder.Entity<saldoRow>().ToTable("saldoRows", "log");
    }
}