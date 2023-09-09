namespace Pathfinder_API.Databases;

public class PathfinderContext : DbContext
{
    public PathfinderContext(DbContextOptions<PathfinderContext> options)
       : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        base.OnConfiguring(options);
        IConfigurationRoot config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

        options.UseSqlServer(config.GetConnectionString("default"));

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }

    public DbSet<UserModel> Users { get; set; }
}