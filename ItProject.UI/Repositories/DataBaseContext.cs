namespace ItProject.UI.Infrastructure.Repositories;

public class DataBaseContext : DbContext
{
    public DataBaseContext(DbContextOptions<DataBaseContext> configure) : base(configure)
    {
    }
}
